namespace JewsVNC
{
    partial class VNC
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VNC));
            this.btnConnect = new System.Windows.Forms.Button();
            this.tvMyID = new System.Windows.Forms.Label();
            this.tvMyPassword = new System.Windows.Forms.Label();
            this.tvPartnerID = new System.Windows.Forms.Label();
            this.etMyPassword = new System.Windows.Forms.TextBox();
            this.etPartnerID = new System.Windows.Forms.TextBox();
            this.etMyID = new System.Windows.Forms.TextBox();
            this.rbRemoteControl = new System.Windows.Forms.RadioButton();
            this.rbDataTransfer = new System.Windows.Forms.RadioButton();
            this.panelGroupRB = new System.Windows.Forms.Panel();
            this.panelMyData = new System.Windows.Forms.Panel();
            this.btnUpdatePas = new System.Windows.Forms.Button();
            this.panelPartnerData = new System.Windows.Forms.Panel();
            this.tvAllowRemoteControl = new System.Windows.Forms.Label();
            this.tvControlRemoteComputer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNamePC = new System.Windows.Forms.ListBox();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.lSignUp = new System.Windows.Forms.LinkLabel();
            this.gbAuth = new System.Windows.Forms.GroupBox();
            this.etLogPass = new System.Windows.Forms.TextBox();
            this.tvLogEmail = new System.Windows.Forms.Label();
            this.etLogEmail = new System.Windows.Forms.TextBox();
            this.tvLogPass = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.regPanel = new System.Windows.Forms.Panel();
            this.lLogIn = new System.Windows.Forms.LinkLabel();
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
            this.btnReg = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addComputerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGroupRB.SuspendLayout();
            this.panelMyData.SuspendLayout();
            this.panelPartnerData.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.gbAuth.SuspendLayout();
            this.regPanel.SuspendLayout();
            this.gbRegistration.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(2, 132);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(220, 30);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect to partner";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tvMyID
            // 
            this.tvMyID.AutoSize = true;
            this.tvMyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvMyID.Location = new System.Drawing.Point(3, 11);
            this.tvMyID.Name = "tvMyID";
            this.tvMyID.Size = new System.Drawing.Size(73, 20);
            this.tvMyID.TabIndex = 1;
            this.tvMyID.Text = "Your - ID";
            // 
            // tvMyPassword
            // 
            this.tvMyPassword.AutoSize = true;
            this.tvMyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvMyPassword.Location = new System.Drawing.Point(3, 45);
            this.tvMyPassword.Name = "tvMyPassword";
            this.tvMyPassword.Size = new System.Drawing.Size(78, 20);
            this.tvMyPassword.TabIndex = 2;
            this.tvMyPassword.Text = "Password";
            // 
            // tvPartnerID
            // 
            this.tvPartnerID.AutoSize = true;
            this.tvPartnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvPartnerID.Location = new System.Drawing.Point(6, 11);
            this.tvPartnerID.Name = "tvPartnerID";
            this.tvPartnerID.Size = new System.Drawing.Size(82, 20);
            this.tvPartnerID.TabIndex = 3;
            this.tvPartnerID.Text = "Partner ID";
            // 
            // etMyPassword
            // 
            this.etMyPassword.Location = new System.Drawing.Point(108, 43);
            this.etMyPassword.Name = "etMyPassword";
            this.etMyPassword.ReadOnly = true;
            this.etMyPassword.Size = new System.Drawing.Size(104, 26);
            this.etMyPassword.TabIndex = 4;
            this.etMyPassword.Text = "123Lolkek";
            // 
            // etPartnerID
            // 
            this.etPartnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.etPartnerID.Location = new System.Drawing.Point(3, 34);
            this.etPartnerID.Name = "etPartnerID";
            this.etPartnerID.Size = new System.Drawing.Size(219, 26);
            this.etPartnerID.TabIndex = 5;
            // 
            // etMyID
            // 
            this.etMyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.etMyID.Location = new System.Drawing.Point(82, 8);
            this.etMyID.Name = "etMyID";
            this.etMyID.ReadOnly = true;
            this.etMyID.Size = new System.Drawing.Size(130, 26);
            this.etMyID.TabIndex = 6;
            this.etMyID.Text = "123456789";
            // 
            // rbRemoteControl
            // 
            this.rbRemoteControl.AutoSize = true;
            this.rbRemoteControl.Checked = true;
            this.rbRemoteControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRemoteControl.Location = new System.Drawing.Point(3, 3);
            this.rbRemoteControl.Name = "rbRemoteControl";
            this.rbRemoteControl.Size = new System.Drawing.Size(139, 24);
            this.rbRemoteControl.TabIndex = 0;
            this.rbRemoteControl.TabStop = true;
            this.rbRemoteControl.Text = "Remote Control";
            this.rbRemoteControl.UseVisualStyleBackColor = true;
            // 
            // rbDataTransfer
            // 
            this.rbDataTransfer.AutoSize = true;
            this.rbDataTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDataTransfer.Location = new System.Drawing.Point(3, 30);
            this.rbDataTransfer.Name = "rbDataTransfer";
            this.rbDataTransfer.Size = new System.Drawing.Size(115, 24);
            this.rbDataTransfer.TabIndex = 1;
            this.rbDataTransfer.Text = "File Transfer";
            this.rbDataTransfer.UseVisualStyleBackColor = true;
            // 
            // panelGroupRB
            // 
            this.panelGroupRB.Controls.Add(this.rbDataTransfer);
            this.panelGroupRB.Controls.Add(this.rbRemoteControl);
            this.panelGroupRB.Location = new System.Drawing.Point(3, 66);
            this.panelGroupRB.Name = "panelGroupRB";
            this.panelGroupRB.Size = new System.Drawing.Size(219, 60);
            this.panelGroupRB.TabIndex = 8;
            // 
            // panelMyData
            // 
            this.panelMyData.Controls.Add(this.btnUpdatePas);
            this.panelMyData.Controls.Add(this.tvMyID);
            this.panelMyData.Controls.Add(this.tvMyPassword);
            this.panelMyData.Controls.Add(this.etMyID);
            this.panelMyData.Controls.Add(this.etMyPassword);
            this.panelMyData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMyData.Location = new System.Drawing.Point(12, 132);
            this.panelMyData.Name = "panelMyData";
            this.panelMyData.Size = new System.Drawing.Size(218, 80);
            this.panelMyData.TabIndex = 9;
            // 
            // btnUpdatePas
            // 
            this.btnUpdatePas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatePas.BackgroundImage")));
            this.btnUpdatePas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdatePas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdatePas.Location = new System.Drawing.Point(82, 43);
            this.btnUpdatePas.Name = "btnUpdatePas";
            this.btnUpdatePas.Size = new System.Drawing.Size(25, 25);
            this.btnUpdatePas.TabIndex = 9;
            this.btnUpdatePas.UseVisualStyleBackColor = true;
            this.btnUpdatePas.Click += new System.EventHandler(this.btnUpdatePas_Click);
            // 
            // panelPartnerData
            // 
            this.panelPartnerData.Controls.Add(this.panelGroupRB);
            this.panelPartnerData.Controls.Add(this.btnConnect);
            this.panelPartnerData.Controls.Add(this.tvPartnerID);
            this.panelPartnerData.Controls.Add(this.etPartnerID);
            this.panelPartnerData.Location = new System.Drawing.Point(247, 132);
            this.panelPartnerData.Name = "panelPartnerData";
            this.panelPartnerData.Size = new System.Drawing.Size(225, 185);
            this.panelPartnerData.TabIndex = 10;
            // 
            // tvAllowRemoteControl
            // 
            this.tvAllowRemoteControl.AutoSize = true;
            this.tvAllowRemoteControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvAllowRemoteControl.Location = new System.Drawing.Point(15, 26);
            this.tvAllowRemoteControl.Name = "tvAllowRemoteControl";
            this.tvAllowRemoteControl.Size = new System.Drawing.Size(192, 24);
            this.tvAllowRemoteControl.TabIndex = 24;
            this.tvAllowRemoteControl.Text = "Allow Remote Control";
            // 
            // tvControlRemoteComputer
            // 
            this.tvControlRemoteComputer.AutoSize = true;
            this.tvControlRemoteComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvControlRemoteComputer.Location = new System.Drawing.Point(243, 26);
            this.tvControlRemoteComputer.Name = "tvControlRemoteComputer";
            this.tvControlRemoteComputer.Size = new System.Drawing.Size(229, 24);
            this.tvControlRemoteComputer.TabIndex = 25;
            this.tvControlRemoteComputer.Text = "Control Remote Computer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(240, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 350);
            this.panel1.TabIndex = 26;
            // 
            // lbNamePC
            // 
            this.lbNamePC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNamePC.FormattingEnabled = true;
            this.lbNamePC.ItemHeight = 20;
            this.lbNamePC.Location = new System.Drawing.Point(478, 26);
            this.lbNamePC.Name = "lbNamePC";
            this.lbNamePC.Size = new System.Drawing.Size(244, 384);
            this.lbNamePC.TabIndex = 28;
            this.lbNamePC.Visible = false;
            this.lbNamePC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbNamePC_MouseDoubleClick);
            // 
            // LogPanel
            // 
            this.LogPanel.Controls.Add(this.lSignUp);
            this.LogPanel.Controls.Add(this.gbAuth);
            this.LogPanel.Controls.Add(this.btnAuth);
            this.LogPanel.Location = new System.Drawing.Point(492, 87);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(219, 218);
            this.LogPanel.TabIndex = 29;
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
            // regPanel
            // 
            this.regPanel.Controls.Add(this.lLogIn);
            this.regPanel.Controls.Add(this.gbRegistration);
            this.regPanel.Controls.Add(this.btnReg);
            this.regPanel.Location = new System.Drawing.Point(491, 35);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(220, 365);
            this.regPanel.TabIndex = 30;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 31;
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
            // VNC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.lbNamePC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvControlRemoteComputer);
            this.Controls.Add(this.tvAllowRemoteControl);
            this.Controls.Add(this.panelPartnerData);
            this.Controls.Add(this.panelMyData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VNC";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VNC_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelGroupRB.ResumeLayout(false);
            this.panelGroupRB.PerformLayout();
            this.panelMyData.ResumeLayout(false);
            this.panelMyData.PerformLayout();
            this.panelPartnerData.ResumeLayout(false);
            this.panelPartnerData.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.gbAuth.ResumeLayout(false);
            this.gbAuth.PerformLayout();
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.gbRegistration.ResumeLayout(false);
            this.gbRegistration.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label tvMyID;
        private System.Windows.Forms.Label tvMyPassword;
        private System.Windows.Forms.Label tvPartnerID;
        private System.Windows.Forms.TextBox etMyPassword;
        private System.Windows.Forms.TextBox etPartnerID;
        private System.Windows.Forms.TextBox etMyID;
        private System.Windows.Forms.RadioButton rbRemoteControl;
        private System.Windows.Forms.RadioButton rbDataTransfer;
        private System.Windows.Forms.Panel panelGroupRB;
        private System.Windows.Forms.Panel panelMyData;
        private System.Windows.Forms.Panel panelPartnerData;
        private System.Windows.Forms.Button btnUpdatePas;
        private System.Windows.Forms.Label tvAllowRemoteControl;
        private System.Windows.Forms.Label tvControlRemoteComputer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbNamePC;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.LinkLabel lSignUp;
        private System.Windows.Forms.GroupBox gbAuth;
        private System.Windows.Forms.TextBox etLogPass;
        private System.Windows.Forms.Label tvLogEmail;
        private System.Windows.Forms.TextBox etLogEmail;
        private System.Windows.Forms.Label tvLogPass;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.LinkLabel lLogIn;
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
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addComputerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
    }
}

