namespace JuceVNC
{
    partial class Form2
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
            this.btnReg = new System.Windows.Forms.Button();
            this.gbRegistration = new System.Windows.Forms.GroupBox();
            this.etConfirmPassword = new System.Windows.Forms.TextBox();
            this.etOrganization = new System.Windows.Forms.TextBox();
            this.etPassword = new System.Windows.Forms.TextBox();
            this.tvRegLogin = new System.Windows.Forms.Label();
            this.tvRegEmail = new System.Windows.Forms.Label();
            this.etEmail = new System.Windows.Forms.TextBox();
            this.tvRegOrg = new System.Windows.Forms.Label();
            this.etLogin = new System.Windows.Forms.TextBox();
            this.tvRegPass = new System.Windows.Forms.Label();
            this.tvRegConfPas = new System.Windows.Forms.Label();
            this.regPanel = new System.Windows.Forms.Panel();
            this.lLogIn = new System.Windows.Forms.LinkLabel();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.lSignUp = new System.Windows.Forms.LinkLabel();
            this.gbAuth = new System.Windows.Forms.GroupBox();
            this.etLogPass = new System.Windows.Forms.TextBox();
            this.tvLogEmail = new System.Windows.Forms.Label();
            this.etLogEmail = new System.Windows.Forms.TextBox();
            this.tvLogPass = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addComputerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNamePC = new System.Windows.Forms.ListBox();
            this.addPartnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRegistration.SuspendLayout();
            this.regPanel.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.gbAuth.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.Location = new System.Drawing.Point(3, 299);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(205, 40);
            this.btnReg.TabIndex = 17;
            this.btnReg.Text = "Registration";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // gbRegistration
            // 
            this.gbRegistration.Controls.Add(this.etConfirmPassword);
            this.gbRegistration.Controls.Add(this.etOrganization);
            this.gbRegistration.Controls.Add(this.etPassword);
            this.gbRegistration.Controls.Add(this.tvRegLogin);
            this.gbRegistration.Controls.Add(this.tvRegEmail);
            this.gbRegistration.Controls.Add(this.etEmail);
            this.gbRegistration.Controls.Add(this.tvRegOrg);
            this.gbRegistration.Controls.Add(this.etLogin);
            this.gbRegistration.Controls.Add(this.tvRegPass);
            this.gbRegistration.Controls.Add(this.tvRegConfPas);
            this.gbRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbRegistration.Location = new System.Drawing.Point(3, 3);
            this.gbRegistration.Name = "gbRegistration";
            this.gbRegistration.Size = new System.Drawing.Size(205, 290);
            this.gbRegistration.TabIndex = 16;
            this.gbRegistration.TabStop = false;
            this.gbRegistration.Text = "Registration";
            // 
            // etConfirmPassword
            // 
            this.etConfirmPassword.Location = new System.Drawing.Point(10, 253);
            this.etConfirmPassword.Name = "etConfirmPassword";
            this.etConfirmPassword.Size = new System.Drawing.Size(185, 26);
            this.etConfirmPassword.TabIndex = 20;
            // 
            // etOrganization
            // 
            this.etOrganization.Location = new System.Drawing.Point(10, 149);
            this.etOrganization.Name = "etOrganization";
            this.etOrganization.Size = new System.Drawing.Size(185, 26);
            this.etOrganization.TabIndex = 18;
            // 
            // etPassword
            // 
            this.etPassword.Location = new System.Drawing.Point(10, 201);
            this.etPassword.Name = "etPassword";
            this.etPassword.Size = new System.Drawing.Size(185, 26);
            this.etPassword.TabIndex = 19;
            // 
            // tvRegLogin
            // 
            this.tvRegLogin.AutoSize = true;
            this.tvRegLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvRegLogin.Location = new System.Drawing.Point(6, 22);
            this.tvRegLogin.Name = "tvRegLogin";
            this.tvRegLogin.Size = new System.Drawing.Size(48, 20);
            this.tvRegLogin.TabIndex = 11;
            this.tvRegLogin.Text = "Login";
            // 
            // tvRegEmail
            // 
            this.tvRegEmail.AutoSize = true;
            this.tvRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvRegEmail.Location = new System.Drawing.Point(6, 74);
            this.tvRegEmail.Name = "tvRegEmail";
            this.tvRegEmail.Size = new System.Drawing.Size(53, 20);
            this.tvRegEmail.TabIndex = 12;
            this.tvRegEmail.Text = "E-mail";
            // 
            // etEmail
            // 
            this.etEmail.Location = new System.Drawing.Point(10, 97);
            this.etEmail.Name = "etEmail";
            this.etEmail.Size = new System.Drawing.Size(185, 26);
            this.etEmail.TabIndex = 17;
            // 
            // tvRegOrg
            // 
            this.tvRegOrg.AutoSize = true;
            this.tvRegOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvRegOrg.Location = new System.Drawing.Point(6, 126);
            this.tvRegOrg.Name = "tvRegOrg";
            this.tvRegOrg.Size = new System.Drawing.Size(99, 20);
            this.tvRegOrg.TabIndex = 13;
            this.tvRegOrg.Text = "Organization";
            // 
            // etLogin
            // 
            this.etLogin.Location = new System.Drawing.Point(10, 45);
            this.etLogin.Name = "etLogin";
            this.etLogin.Size = new System.Drawing.Size(185, 26);
            this.etLogin.TabIndex = 16;
            // 
            // tvRegPass
            // 
            this.tvRegPass.AutoSize = true;
            this.tvRegPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvRegPass.Location = new System.Drawing.Point(6, 178);
            this.tvRegPass.Name = "tvRegPass";
            this.tvRegPass.Size = new System.Drawing.Size(78, 20);
            this.tvRegPass.TabIndex = 14;
            this.tvRegPass.Text = "Password";
            // 
            // tvRegConfPas
            // 
            this.tvRegConfPas.AutoSize = true;
            this.tvRegConfPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvRegConfPas.Location = new System.Drawing.Point(6, 230);
            this.tvRegConfPas.Name = "tvRegConfPas";
            this.tvRegConfPas.Size = new System.Drawing.Size(137, 20);
            this.tvRegConfPas.TabIndex = 15;
            this.tvRegConfPas.Text = "Confirm Password";
            // 
            // regPanel
            // 
            this.regPanel.Controls.Add(this.lLogIn);
            this.regPanel.Controls.Add(this.gbRegistration);
            this.regPanel.Controls.Add(this.btnReg);
            this.regPanel.Location = new System.Drawing.Point(30, 34);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(220, 376);
            this.regPanel.TabIndex = 18;
            this.regPanel.Visible = false;
            // 
            // lLogIn
            // 
            this.lLogIn.AutoSize = true;
            this.lLogIn.Location = new System.Drawing.Point(89, 342);
            this.lLogIn.Name = "lLogIn";
            this.lLogIn.Size = new System.Drawing.Size(34, 13);
            this.lLogIn.TabIndex = 24;
            this.lLogIn.TabStop = true;
            this.lLogIn.Text = "LogIn";
            this.lLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLogIn_LinkClicked);
            // 
            // LogPanel
            // 
            this.LogPanel.Controls.Add(this.lSignUp);
            this.LogPanel.Controls.Add(this.gbAuth);
            this.LogPanel.Controls.Add(this.btnAuth);
            this.LogPanel.Location = new System.Drawing.Point(30, 57);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(219, 218);
            this.LogPanel.TabIndex = 25;
            // 
            // lSignUp
            // 
            this.lSignUp.AutoSize = true;
            this.lSignUp.Location = new System.Drawing.Point(88, 191);
            this.lSignUp.Name = "lSignUp";
            this.lSignUp.Size = new System.Drawing.Size(42, 13);
            this.lSignUp.TabIndex = 23;
            this.lSignUp.TabStop = true;
            this.lSignUp.Text = "SignUp";
            this.lSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSignUp_LinkClicked);
            // 
            // gbAuth
            // 
            this.gbAuth.Controls.Add(this.etLogPass);
            this.gbAuth.Controls.Add(this.tvLogEmail);
            this.gbAuth.Controls.Add(this.etLogEmail);
            this.gbAuth.Controls.Add(this.tvLogPass);
            this.gbAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAuth.Location = new System.Drawing.Point(8, 3);
            this.gbAuth.Name = "gbAuth";
            this.gbAuth.Size = new System.Drawing.Size(205, 131);
            this.gbAuth.TabIndex = 21;
            this.gbAuth.TabStop = false;
            this.gbAuth.Text = "Authorization";
            // 
            // etLogPass
            // 
            this.etLogPass.Location = new System.Drawing.Point(10, 97);
            this.etLogPass.Name = "etLogPass";
            this.etLogPass.Size = new System.Drawing.Size(185, 26);
            this.etLogPass.TabIndex = 19;
            // 
            // tvLogEmail
            // 
            this.tvLogEmail.AutoSize = true;
            this.tvLogEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvLogEmail.Location = new System.Drawing.Point(6, 22);
            this.tvLogEmail.Name = "tvLogEmail";
            this.tvLogEmail.Size = new System.Drawing.Size(53, 20);
            this.tvLogEmail.TabIndex = 12;
            this.tvLogEmail.Text = "E-mail";
            // 
            // etLogEmail
            // 
            this.etLogEmail.Location = new System.Drawing.Point(10, 45);
            this.etLogEmail.Name = "etLogEmail";
            this.etLogEmail.Size = new System.Drawing.Size(185, 26);
            this.etLogEmail.TabIndex = 17;
            // 
            // tvLogPass
            // 
            this.tvLogPass.AutoSize = true;
            this.tvLogPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvLogPass.Location = new System.Drawing.Point(6, 74);
            this.tvLogPass.Name = "tvLogPass";
            this.tvLogPass.Size = new System.Drawing.Size(78, 20);
            this.tvLogPass.TabIndex = 14;
            this.tvLogPass.Text = "Password";
            // 
            // btnAuth
            // 
            this.btnAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuth.Location = new System.Drawing.Point(8, 140);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(205, 40);
            this.btnAuth.TabIndex = 22;
            this.btnAuth.Text = "Authorization";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComputerToolStripMenuItem1,
            this.logOutToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addComputerToolStripMenuItem1
            // 
            this.addComputerToolStripMenuItem1.Name = "addComputerToolStripMenuItem1";
            this.addComputerToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.addComputerToolStripMenuItem1.Text = "Add Partner";
            this.addComputerToolStripMenuItem1.Click += new System.EventHandler(this.addComputerToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // addComputerToolStripMenuItem
            // 
            this.addComputerToolStripMenuItem.Name = "addComputerToolStripMenuItem";
            this.addComputerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.addComputerToolStripMenuItem.Text = "Menu";
            // 
            // lbNamePC
            // 
            this.lbNamePC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNamePC.FormattingEnabled = true;
            this.lbNamePC.ItemHeight = 20;
            this.lbNamePC.Location = new System.Drawing.Point(12, 32);
            this.lbNamePC.Name = "lbNamePC";
            this.lbNamePC.Size = new System.Drawing.Size(260, 424);
            this.lbNamePC.TabIndex = 24;
            this.lbNamePC.Visible = false;
            // 
            // addPartnerToolStripMenuItem
            // 
            this.addPartnerToolStripMenuItem.Name = "addPartnerToolStripMenuItem";
            this.addPartnerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.lbNamePC);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.gbAuth.ResumeLayout(false);
            this.gbAuth.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.GroupBox gbRegistration;
        private System.Windows.Forms.TextBox etConfirmPassword;
        private System.Windows.Forms.TextBox etOrganization;
        private System.Windows.Forms.TextBox etPassword;
        private System.Windows.Forms.Label tvRegLogin;
        private System.Windows.Forms.Label tvRegEmail;
        private System.Windows.Forms.TextBox etEmail;
        private System.Windows.Forms.Label tvRegOrg;
        private System.Windows.Forms.TextBox etLogin;
        private System.Windows.Forms.Label tvRegPass;
        private System.Windows.Forms.Label tvRegConfPas;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.GroupBox gbAuth;
        private System.Windows.Forms.TextBox etLogPass;
        private System.Windows.Forms.Label tvLogEmail;
        private System.Windows.Forms.TextBox etLogEmail;
        private System.Windows.Forms.Label tvLogPass;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addComputerToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lSignUp;
        private System.Windows.Forms.LinkLabel lLogIn;
        private System.Windows.Forms.ListBox lbNamePC;
        private System.Windows.Forms.ToolStripMenuItem addPartnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addComputerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
    }
}