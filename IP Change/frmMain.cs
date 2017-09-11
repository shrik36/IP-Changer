using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Change
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// sets IP and Subnet of PC
        /// </summary>
        /// <param name="ip_address"></param>
        /// <param name="subnet_mask"></param>
        public void setIP(string ip_address, string subnet_mask)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject setIP;
                        ManagementBaseObject newIP =
                            objMO.GetMethodParameters("EnableStatic");

                        newIP["IPAddress"] = new string[] { ip_address };
                        newIP["SubnetMask"] = new string[] { subnet_mask };

                        setIP = objMO.InvokeMethod("EnableStatic", newIP, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }


                }
            }
        }

        /// <summary>
        /// sets DNS of PC
        /// </summary>
        /// <param name="NIC"></param>
        /// <param name="DNS"></param>
        public void setDNS(string NIC, string DNS)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].Equals(NIC))
                    {
                        try
                        {
                            ManagementBaseObject newDNS =
                                objMO.GetMethodParameters("SetDNSServerSearchOrder");
                            newDNS["DNSServerSearchOrder"] = DNS.Split(',');
                            ManagementBaseObject setDNS =
                                objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// sets default gateway of PC
        /// </summary>
        /// <param name="gateway"></param>
        public void setGateway(string gateway)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    try
                    {
                        ManagementBaseObject setGateway;
                        ManagementBaseObject newGateway =
                            objMO.GetMethodParameters("SetGateways");

                        newGateway["DefaultIPGateway"] = new string[] { gateway };
                        newGateway["GatewayCostMetric"] = new int[] { 1 };

                        setGateway = objMO.InvokeMethod("SetGateways", newGateway, null);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        void LoadDefaultIPSettingsFromConfig()
        {
            txtIP1.Text = ConfigurationManager.AppSettings["IP1"];
            txtSubnet1.Text = ConfigurationManager.AppSettings["Subnet1"];
            txtDefaultGateway1.Text = ConfigurationManager.AppSettings["DefaultGateway1"];
            if (ConfigurationManager.AppSettings["PrefferedDNS1"] != null)
                txtprefferedDNS1.Text = ConfigurationManager.AppSettings["PrefferedDNS1"];

            txtIP2.Text = ConfigurationManager.AppSettings["IP2"];
            txtSubnet2.Text = ConfigurationManager.AppSettings["Subnet2"];
            txtDefaultGateway2.Text = ConfigurationManager.AppSettings["DefaultGateway2"];
            if (ConfigurationManager.AppSettings["PrefferedDNS2"] != null)
                txtprefferedDNS2.Text = ConfigurationManager.AppSettings["PrefferedDNS2"];

            btnPSettings2.BackColor = btnPSettings1.BackColor = SystemColors.Control;
            btnPSettings2.Enabled = btnPSettings1.Enabled = true;
        }

        void LoadPCIPSettingsIntoSettings1()
        {
            NetworkInterface[] ni = NetworkInterface.GetAllNetworkInterfaces();
            bool allDataFound = false;
            foreach (var item in ni)
            {
                if (item.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    IPInterfaceProperties ipInterface = item.GetIPProperties();
                    foreach (UnicastIPAddressInformation unicastAddress in ipInterface.UnicastAddresses)
                    {
                        if (unicastAddress.Address.ToString() != "0.0.0.0")
                        {
                            txtIP1.Text = unicastAddress.Address.ToString();
                            allDataFound = true;
                        }
                        else
                            allDataFound = false;
                        if (unicastAddress.IPv4Mask.ToString() != "0.0.0.0")
                        {
                            txtSubnet1.Text = unicastAddress.IPv4Mask.ToString();
                            allDataFound = true;
                        }
                        else
                            allDataFound = false;
                    }
                }
            }

            if (allDataFound)
            {
                btnPSettings1.Enabled = false;
                btnPSettings1.BackColor = SystemColors.Control;
                btnPSettings2.Enabled = true;
                btnPSettings2.BackColor = Color.Green;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDefaultIPSettingsFromConfig();
        }

        private void btnPSettings1_Click(object sender, EventArgs e)
        {
            string nicName = "";
            NetworkInterface[] ni = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var item in ni)
            {
                if (item.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    nicName = item.Name;
                }
            }

            setIP(txtIP1.Text, txtSubnet1.Text);
            setGateway(txtDefaultGateway1.Text);
            setDNS(nicName, txtprefferedDNS1.Text);

            btnPSettings1.Enabled = false;
            btnPSettings1.BackColor = SystemColors.Control;
            btnPSettings2.Enabled = true;
            btnPSettings2.BackColor = Color.Green;
        }

        private void BtnPSettings2_Click(object sender, EventArgs e)
        {
            string nicName = "";
            NetworkInterface[] ni = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var item in ni)
            {
                if (item.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    nicName = item.Name;
                }
            }

            setIP(txtIP2.Text, txtSubnet2.Text);
            setGateway(txtDefaultGateway2.Text);
            setDNS(nicName, txtprefferedDNS2.Text);

            btnPSettings2.Enabled = false;
            btnPSettings2.BackColor = SystemColors.Control;
            btnPSettings1.Enabled = true;
            btnPSettings1.BackColor = Color.Green;
        }

        private void chkLoadCurrentIP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoadCurrentIP.Checked)
            {
                LoadPCIPSettingsIntoSettings1();
            }
            else
            {
                LoadDefaultIPSettingsFromConfig();
            }
        }
    }
}
