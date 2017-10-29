namespace JuceVNC
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
            this.edPartnerID = new System.Windows.Forms.TextBox();
            this.etMyID = new System.Windows.Forms.TextBox();
            this.rbRemoteControl = new System.Windows.Forms.RadioButton();
            this.rbDataTransfer = new System.Windows.Forms.RadioButton();
            this.panelGroupRB = new System.Windows.Forms.Panel();
            this.panelMyData = new System.Windows.Forms.Panel();
            this.btnUpdatePas = new System.Windows.Forms.Button();
            this.panelPartnerData = new System.Windows.Forms.Panel();
            this.btnShowPanel = new System.Windows.Forms.Button();
            this.tvAllowRemoteControl = new System.Windows.Forms.Label();
            this.tvControlRemoteComputer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGroupRB.SuspendLayout();
            this.panelMyData.SuspendLayout();
            this.panelPartnerData.SuspendLayout();
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
            // edPartnerID
            // 
            this.edPartnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edPartnerID.Location = new System.Drawing.Point(3, 34);
            this.edPartnerID.Name = "edPartnerID";
            this.edPartnerID.Size = new System.Drawing.Size(219, 26);
            this.edPartnerID.TabIndex = 5;
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
            this.panelMyData.Location = new System.Drawing.Point(12, 147);
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
            this.panelPartnerData.Controls.Add(this.edPartnerID);
            this.panelPartnerData.Location = new System.Drawing.Point(247, 147);
            this.panelPartnerData.Name = "panelPartnerData";
            this.panelPartnerData.Size = new System.Drawing.Size(225, 185);
            this.panelPartnerData.TabIndex = 10;
            // 
            // btnShowPanel
            // 
            this.btnShowPanel.Location = new System.Drawing.Point(397, 427);
            this.btnShowPanel.Name = "btnShowPanel";
            this.btnShowPanel.Size = new System.Drawing.Size(75, 23);
            this.btnShowPanel.TabIndex = 23;
            this.btnShowPanel.Text = "Show Panel";
            this.btnShowPanel.UseVisualStyleBackColor = true;
            this.btnShowPanel.Click += new System.EventHandler(this.btnShowPanel_Click);
            // 
            // tvAllowRemoteControl
            // 
            this.tvAllowRemoteControl.AutoSize = true;
            this.tvAllowRemoteControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvAllowRemoteControl.Location = new System.Drawing.Point(12, 113);
            this.tvAllowRemoteControl.Name = "tvAllowRemoteControl";
            this.tvAllowRemoteControl.Size = new System.Drawing.Size(192, 24);
            this.tvAllowRemoteControl.TabIndex = 24;
            this.tvAllowRemoteControl.Text = "Allow Remote Control";
            // 
            // tvControlRemoteComputer
            // 
            this.tvControlRemoteComputer.AutoSize = true;
            this.tvControlRemoteComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvControlRemoteComputer.Location = new System.Drawing.Point(243, 113);
            this.tvControlRemoteComputer.Name = "tvControlRemoteComputer";
            this.tvControlRemoteComputer.Size = new System.Drawing.Size(229, 24);
            this.tvControlRemoteComputer.TabIndex = 25;
            this.tvControlRemoteComputer.Text = "Control Remote Computer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(240, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 300);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 1);
            this.panel2.TabIndex = 27;
            // 
            // VNC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvControlRemoteComputer);
            this.Controls.Add(this.tvAllowRemoteControl);
            this.Controls.Add(this.btnShowPanel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label tvMyID;
        private System.Windows.Forms.Label tvMyPassword;
        private System.Windows.Forms.Label tvPartnerID;
        private System.Windows.Forms.TextBox etMyPassword;
        private System.Windows.Forms.TextBox edPartnerID;
        private System.Windows.Forms.TextBox etMyID;
        private System.Windows.Forms.RadioButton rbRemoteControl;
        private System.Windows.Forms.RadioButton rbDataTransfer;
        private System.Windows.Forms.Panel panelGroupRB;
        private System.Windows.Forms.Panel panelMyData;
        private System.Windows.Forms.Panel panelPartnerData;
        private System.Windows.Forms.Button btnUpdatePas;
        private System.Windows.Forms.Button btnShowPanel;
        private System.Windows.Forms.Label tvAllowRemoteControl;
        private System.Windows.Forms.Label tvControlRemoteComputer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

