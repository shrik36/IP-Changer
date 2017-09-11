namespace IP_Change
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gbIPSettings1 = new System.Windows.Forms.GroupBox();
            this.btnPSettings1 = new System.Windows.Forms.Button();
            this.txtDefaultGateway1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprefferedDNS1 = new System.Windows.Forms.TextBox();
            this.txtSubnet1 = new System.Windows.Forms.TextBox();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbIPSettings2 = new System.Windows.Forms.GroupBox();
            this.btnPSettings2 = new System.Windows.Forms.Button();
            this.txtDefaultGateway2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprefferedDNS2 = new System.Windows.Forms.TextBox();
            this.txtSubnet2 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkLoadCurrentIP = new System.Windows.Forms.CheckBox();
            this.gbIPSettings1.SuspendLayout();
            this.gbIPSettings2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIPSettings1
            // 
            this.gbIPSettings1.Controls.Add(this.btnPSettings1);
            this.gbIPSettings1.Controls.Add(this.txtDefaultGateway1);
            this.gbIPSettings1.Controls.Add(this.label4);
            this.gbIPSettings1.Controls.Add(this.txtprefferedDNS1);
            this.gbIPSettings1.Controls.Add(this.txtSubnet1);
            this.gbIPSettings1.Controls.Add(this.txtIP1);
            this.gbIPSettings1.Controls.Add(this.label3);
            this.gbIPSettings1.Controls.Add(this.label2);
            this.gbIPSettings1.Controls.Add(this.label1);
            this.gbIPSettings1.Location = new System.Drawing.Point(12, 38);
            this.gbIPSettings1.Name = "gbIPSettings1";
            this.gbIPSettings1.Size = new System.Drawing.Size(644, 140);
            this.gbIPSettings1.TabIndex = 0;
            this.gbIPSettings1.TabStop = false;
            this.gbIPSettings1.Text = "IP Settings 1";
            // 
            // btnPSettings1
            // 
            this.btnPSettings1.Location = new System.Drawing.Point(440, 30);
            this.btnPSettings1.Name = "btnPSettings1";
            this.btnPSettings1.Size = new System.Drawing.Size(148, 93);
            this.btnPSettings1.TabIndex = 4;
            this.btnPSettings1.Text = "Set Default";
            this.btnPSettings1.UseVisualStyleBackColor = true;
            this.btnPSettings1.Click += new System.EventHandler(this.btnPSettings1_Click);
            // 
            // txtDefaultGateway1
            // 
            this.txtDefaultGateway1.Location = new System.Drawing.Point(114, 78);
            this.txtDefaultGateway1.Name = "txtDefaultGateway1";
            this.txtDefaultGateway1.Size = new System.Drawing.Size(141, 20);
            this.txtDefaultGateway1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Default Gateway";
            // 
            // txtprefferedDNS1
            // 
            this.txtprefferedDNS1.Location = new System.Drawing.Point(114, 104);
            this.txtprefferedDNS1.Name = "txtprefferedDNS1";
            this.txtprefferedDNS1.Size = new System.Drawing.Size(141, 20);
            this.txtprefferedDNS1.TabIndex = 3;
            this.txtprefferedDNS1.Text = "8.8.8.8";
            // 
            // txtSubnet1
            // 
            this.txtSubnet1.Location = new System.Drawing.Point(114, 50);
            this.txtSubnet1.Name = "txtSubnet1";
            this.txtSubnet1.Size = new System.Drawing.Size(141, 20);
            this.txtSubnet1.TabIndex = 1;
            // 
            // txtIP1
            // 
            this.txtIP1.Location = new System.Drawing.Point(114, 26);
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(141, 20);
            this.txtIP1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preffered DNS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subnet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // gbIPSettings2
            // 
            this.gbIPSettings2.Controls.Add(this.btnPSettings2);
            this.gbIPSettings2.Controls.Add(this.txtDefaultGateway2);
            this.gbIPSettings2.Controls.Add(this.label5);
            this.gbIPSettings2.Controls.Add(this.txtprefferedDNS2);
            this.gbIPSettings2.Controls.Add(this.txtSubnet2);
            this.gbIPSettings2.Controls.Add(this.txtIP2);
            this.gbIPSettings2.Controls.Add(this.label6);
            this.gbIPSettings2.Controls.Add(this.label7);
            this.gbIPSettings2.Controls.Add(this.label8);
            this.gbIPSettings2.Location = new System.Drawing.Point(12, 184);
            this.gbIPSettings2.Name = "gbIPSettings2";
            this.gbIPSettings2.Size = new System.Drawing.Size(644, 140);
            this.gbIPSettings2.TabIndex = 1;
            this.gbIPSettings2.TabStop = false;
            this.gbIPSettings2.Text = "IP Settings 2";
            // 
            // btnPSettings2
            // 
            this.btnPSettings2.Location = new System.Drawing.Point(439, 25);
            this.btnPSettings2.Name = "btnPSettings2";
            this.btnPSettings2.Size = new System.Drawing.Size(148, 93);
            this.btnPSettings2.TabIndex = 4;
            this.btnPSettings2.Text = "Set Default";
            this.btnPSettings2.UseVisualStyleBackColor = true;
            this.btnPSettings2.Click += new System.EventHandler(this.BtnPSettings2_Click);
            // 
            // txtDefaultGateway2
            // 
            this.txtDefaultGateway2.Location = new System.Drawing.Point(113, 73);
            this.txtDefaultGateway2.Name = "txtDefaultGateway2";
            this.txtDefaultGateway2.Size = new System.Drawing.Size(141, 20);
            this.txtDefaultGateway2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Default Gateway";
            // 
            // txtprefferedDNS2
            // 
            this.txtprefferedDNS2.Location = new System.Drawing.Point(113, 99);
            this.txtprefferedDNS2.Name = "txtprefferedDNS2";
            this.txtprefferedDNS2.Size = new System.Drawing.Size(141, 20);
            this.txtprefferedDNS2.TabIndex = 3;
            this.txtprefferedDNS2.Text = "8.8.8.8";
            // 
            // txtSubnet2
            // 
            this.txtSubnet2.Location = new System.Drawing.Point(113, 45);
            this.txtSubnet2.Name = "txtSubnet2";
            this.txtSubnet2.Size = new System.Drawing.Size(141, 20);
            this.txtSubnet2.TabIndex = 1;
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(113, 21);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(141, 20);
            this.txtIP2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Preffered DNS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Subnet";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "IP";
            // 
            // chkLoadCurrentIP
            // 
            this.chkLoadCurrentIP.AutoSize = true;
            this.chkLoadCurrentIP.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoadCurrentIP.Location = new System.Drawing.Point(185, 12);
            this.chkLoadCurrentIP.Name = "chkLoadCurrentIP";
            this.chkLoadCurrentIP.Size = new System.Drawing.Size(257, 21);
            this.chkLoadCurrentIP.TabIndex = 2;
            this.chkLoadCurrentIP.Text = "Check to load current IP in IP Settings 1";
            this.chkLoadCurrentIP.UseVisualStyleBackColor = true;
            this.chkLoadCurrentIP.CheckedChanged += new System.EventHandler(this.chkLoadCurrentIP_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 332);
            this.Controls.Add(this.chkLoadCurrentIP);
            this.Controls.Add(this.gbIPSettings2);
            this.Controls.Add(this.gbIPSettings1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbIPSettings1.ResumeLayout(false);
            this.gbIPSettings1.PerformLayout();
            this.gbIPSettings2.ResumeLayout(false);
            this.gbIPSettings2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIPSettings1;
        private System.Windows.Forms.GroupBox gbIPSettings2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.TextBox txtprefferedDNS1;
        private System.Windows.Forms.TextBox txtSubnet1;
        private System.Windows.Forms.TextBox txtDefaultGateway1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPSettings1;
        private System.Windows.Forms.Button btnPSettings2;
        private System.Windows.Forms.TextBox txtDefaultGateway2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprefferedDNS2;
        private System.Windows.Forms.TextBox txtSubnet2;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkLoadCurrentIP;
    }
}

