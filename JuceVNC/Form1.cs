using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace JuceVNC
{
    public partial class VNC : Form
    {
        Form2 form2;
        private NotifyIcon notifyIcon1 = new NotifyIcon();
        private ContextMenu contextMenu1 = new ContextMenu();
        private bool Auth = false;
        private System.Windows.Forms.MenuItem mI1;
        private System.Windows.Forms.MenuItem mI2;
        private System.Windows.Forms.MenuItem mI3;
    

        public VNC()
        {
            InitializeComponent();
            generatePass();
            createIconMenuStructure();
            this.Resize += new System.EventHandler(this.Form1_Resize);

        }

        public void createIconMenuStructure()
        {
            // Add menu items to shortcut menu.
            /*contextMenu1.MenuItems.Add("&Open Application");
            contextMenu1.MenuItems.Add("S&uspend Application");
            contextMenu1.MenuItems.Add("E&xit");
            */
            this.mI1 = new System.Windows.Forms.MenuItem();
            this.mI2 = new System.Windows.Forms.MenuItem();
            this.mI3 = new System.Windows.Forms.MenuItem();

            contextMenu1.MenuItems.AddRange(
                    new System.Windows.Forms.MenuItem[] { this.mI1, this.mI2, this.mI3 });
            this.mI1.Index = 0;
            this.mI1.Text = "O&pen Application";
            this.mI1.Click += new System.EventHandler(this.menuItem1_Click);
            
            this.mI2.Index = 1;
            this.mI2.Text = "L&og Out";
            this.mI2.Click += new System.EventHandler(this.menuItem2_Click);
            
            this.mI3.Index = 2;
            this.mI3.Text = "E&xit";
            this.mI3.Click += new System.EventHandler(this.menuItem3_Click);

            // Set properties of NotifyIcon component.
            notifyIcon1.Icon = Properties.Resources.eye;
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "VNC";
            notifyIcon1.Visible = true;
            notifyIcon1.ContextMenu = contextMenu1;
            notifyIcon1.DoubleClick += new EventHandler(this.notifyIcon_DoubleClick);
            
        }
        private void notifyIcon_DoubleClick(object Sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;

        }
        private void menuItem1_Click(object Sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;

        }
        private void menuItem2_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.Close();
        }
        private void menuItem3_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.Close();
        }

       
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Computer c = new Computer();
            /*
             if (c.Name != null)
                System.Console.WriteLine(c.Name);
            else {
                System.Console.WriteLine("error");
            }
             */
        }

        private void generatePass() {
            string text = "aAbBcCdDeEfFgGhHiIjJhHkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ01234567890123456789";
            text = Shuffle(text); //shuffle the above symbols using shuffle() method.  
            text = text.Remove(6); //cut the string size according to the chosen trackbar value.  
            etMyPassword.Text = text; 
        }

        private void btnUpdatePas_Click(object sender, EventArgs e)
        {
            generatePass();
            //ContextMenu cm = new ContextMenu();
            //cm.MenuItems.Add("Item 1");
            //cm.MenuItems.Add("Item 2");

            //tvMyPassword.ContextMenu = cm;
            
        }

        

        private void btnReg_Click(object sender, EventArgs e)
        {

        }
        static string Shuffle(string input)
        {
            var q = from c in input.ToCharArray()
                    orderby Guid.NewGuid()
                    select c;
            string s = string.Empty;
            foreach (var r in q)
                s += r;
            return s;
        }

        private void btnShowPanel_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new Form2(Auth);
                form2.FormClosing += form2_FormVNCClosing;
                //form2.MdiParent = Main.ActiveForm; 
                form2.Show();
                form2.Left = this.Right;
                form2.Top = this.Top;
            } else {
                form2.Close();
            }
        }

        public void form2_FormVNCClosing(object sender, FormClosingEventArgs e) {
            form2 = null;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;

            } else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void VNC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
                // Call method to save file...
            }
        }



    }
}
