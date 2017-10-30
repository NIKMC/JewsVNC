using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net;
using System.Threading.Tasks;
using System.Management;
namespace JewsVNC
{
    public partial class VNC : Form
    {
        private NotifyIcon notifyIcon1 = new NotifyIcon();
        private ContextMenu contextMenu1 = new ContextMenu();
        private bool Auth = false;
        private System.Windows.Forms.MenuItem mI1;
        private System.Windows.Forms.MenuItem mI2;
        private System.Windows.Forms.MenuItem mI3;
        ContextMenu cm;
        private System.Windows.Forms.MenuItem menuComputer1;
        private System.Windows.Forms.MenuItem menuComputer2;
        private string token;
        private Computer computer = null;
        public VNC()
        {
            InitializeComponent();
            generatePassMacIp();
            checkAuth();
            createIconMenuStructure();
            this.Resize += new System.EventHandler(this.Form1_Resize);

            initContextMenu();
            token = "gcWtPVAgfMyWDcQjiiJe5fWyI7sNiGj3fhUiNpuFjrKVgGQMNgpGASNtQyfYN2ca8ZTQUYEbbRMp8Mh6";
            loadMachines();
            

        }

        private void initContextMenu()
        {
            cm = new ContextMenu();
            this.menuComputer1 = new System.Windows.Forms.MenuItem();
            this.menuComputer2 = new System.Windows.Forms.MenuItem();
            cm.MenuItems.AddRange(
                    new System.Windows.Forms.MenuItem[] { this.menuComputer1, this.menuComputer2 });
            this.menuComputer1.Index = 0;
            this.menuComputer1.Text = "R&emote Control";
            this.menuComputer1.Click += new System.EventHandler(this.menuComputer1_Click);

            this.menuComputer2.Index = 1;
            this.menuComputer2.Text = "F&ile Transfer";
            this.menuComputer2.Click += new System.EventHandler(this.menuComputer2_Click);

        }


        private void menuComputer1_Click(object Sender, EventArgs e)
        {
            if (computer != null) {
                etPartnerID.Text = computer.id;
            }
        }
        private void menuComputer2_Click(object Sender, EventArgs e)
        {

        }

        private void checkAuth()
        {
            if (Auth)
            {
                lbNamePC.Visible = true;
            }
            else
            {
                LogPanel.Visible = false;
                regPanel.Visible = false;
                menuStrip1.Visible = true;
                lbNamePC.Visible = true;
            }
        }

        private void lSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogPanel.Visible = false;
            regPanel.Visible = true;

        }


        static async Task<bool> MainAsyncAuthorization(User user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.197:8080");
                var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("email", user.Email),
                new KeyValuePair<string, string>("password", user.Password),
                new KeyValuePair<string, string>("password2", user.ConfirmPassword),
                new KeyValuePair<string, string>("company", user.Organization),
                new KeyValuePair<string, string>("name", user.Login)
            });
                var result = client.PostAsync("/users/register", content).Result;
                 if (result.IsSuccessStatusCode)
                 {
                     return true;
                 }
                 else
                 {
                     Console.WriteLine(result.Content.ReadAsStringAsync());
                     return false;
                 }
            }
        }

        static async Task<string> MainAsyncLogIn(string email, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.197:8080");
                var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("email", email),
                new KeyValuePair<string, string>("password", password)
            });
                var result = client.PostAsync("/users/login", content).Result;
                if (result.IsSuccessStatusCode)
                {
                    var resultContent = result.Content.ReadAsAsync<Auth>().Result;
                    Console.WriteLine(resultContent.Message + "| " + resultContent.Token);
                    return resultContent.Token;
                }
                else
                {
                    Console.WriteLine(result.Content.ReadAsAsync<Auth>().Result.Message);
                    return null;
                }

            }
        }

        static async Task<List<Computer>> Machines(string token)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.197:8080");
                var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("token", token)
            });
                var result = client.PostAsync("/machines", content).Result;
                if (result.IsSuccessStatusCode)
                {
                    var resultContent = result.Content.ReadAsAsync<List<Computer>>().Result;
                    System.Console.WriteLine("LLL");
                    return resultContent;
                }
                else
                {
                    Console.WriteLine(result.Content.ReadAsAsync<Auth>().Result.Message);
                    return null;
                }

            }
        }

        static async Task<string> RegisterMachines(string ip, string mac, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.197:8080");
                var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("ip", ip),
                new KeyValuePair<string, string>("mac", mac),
                new KeyValuePair<string, string>("password", password)
            });
                var result = client.PostAsync("/machines/register", content).Result;
                if (result.IsSuccessStatusCode)
                {
                    var resultContent = result.Content.ReadAsAsync<MachineID>().Result;
                    Console.WriteLine(resultContent.message + "| " + resultContent.ip);
                    return resultContent.ip;
                }
                else
                {
                    Console.WriteLine(result.Content.ReadAsAsync<MachineID>().Result.message);
                    return null;
                }

            }
        }

        private void loadMachines()
        { 
            List<Computer> machines = new List<Computer>(); 
            try {
                machines.AddRange(Machines(this.token).Result);
            }
            catch (AggregateException e)
            {
                Console.WriteLine("AggregateException Machines null" + e.Message);
            }
            if (machines != null && machines.Count != 0)
            {
                lbNamePC.DataSource = machines;
                lbNamePC.DisplayMember = "name";
                lbNamePC.ValueMember = "name";
                lbNamePC.ContextMenu = cm;
            }
            else {
                MessageBox.Show("No machines", "JewsVNC",
            MessageBoxButtons.OK);
            }
        }

        private void lLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogPanel.Visible = true;
            regPanel.Visible = false;

        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            /*
            LogPanel.Visible = false;
            regPanel.Visible = false;
            lbNamePC.Visible = true;
            */
            string email = etLogEmail.Text.ToString();
            string password = etLogPass.Text.ToString();

            this.token = MainAsyncLogIn(email, password).Result;
            if (token != null)
            {
                MessageBox.Show("You have successfully logged in!", "JewsVNC",
        MessageBoxButtons.OK);
                lbNamePC.Visible = true;
                LogPanel.Visible = false;
                regPanel.Visible = false;
                menuStrip1.Visible = true;
                
            }
            else
            {
                MessageBox.Show("User with this email doesn't exists or password incorrect!", "JewsVNC",
        MessageBoxButtons.OK);
            }
           
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = etLogin.Text.ToString();
            user.Password = etPassword.Text.ToString();
            user.ConfirmPassword = etConfirmPassword.Text.ToString();
            user.Email = etEmail.Text.ToString();
            user.Organization = etOrganization.Text.ToString();

            if (MainAsyncAuthorization(user).Result)
            {
                MessageBox.Show("You have successfully registered!", "JewsVNC",
       MessageBoxButtons.OK);
                lbNamePC.Visible = true;
                LogPanel.Visible = false;
                regPanel.Visible = false;
                menuStrip1.Visible = true;
            }
            else {
                MessageBox.Show("User with this Username/Email already exists or Passwords do not match!", "JewsVNC",
           MessageBoxButtons.OK);
            }
            
        }
        public static String GetMACAddress()
        {
            #region Get MAC Address
            try
            {
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                string MACAddress = String.Empty;
                foreach (ManagementObject mo in moc)
                {
                    if (MACAddress == String.Empty) // only return MAC Address from first card
                    {
                        if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
                    }
                    mo.Dispose();
                }

                MACAddress = MACAddress.Replace(":", "");
                return MACAddress;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            #endregion
        }



        private void addComputerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lbNamePC.Visible = false;
            LogPanel.Visible = true;
            regPanel.Visible = false;
            menuStrip1.Visible = false;
            token = "";
            computer = null;
            etPartnerID.Text = "";
        }



        private void lbNamePC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int item = lbNamePC.IndexFromPoint(e.Location);
            if (item >= 0)
            {
                
                System.Console.WriteLine("items =" + item + "|||" + this.lbNamePC.Items[item]);
                computer = (Computer)this.lbNamePC.Items[item];
                cm.Show(lbNamePC, e.Location);
            }
        }

       

        public void createIconMenuStructure()
        {
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
            notifyIcon1.Icon = JewsVNC.Properties.Resources.eye;
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

        private void generatePassMacIp() {
            string text = "aAbBcCdDeEfFgGhHiIjJhHkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ01234567890123456789";
            text = Shuffle(text); //shuffle the above symbols using shuffle() method.  
            text = text.Remove(6); //cut the string size according to the chosen trackbar value.  
            etMyPassword.Text = text;

            try
            {
                System.Console.WriteLine("MAC Address\t:\t" + GetMACAddress());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }

            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            for (int i = 0; i < localIPs.Length; i++)
            {
                if (localIPs[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    System.Console.WriteLine("IP = " + localIPs.GetValue(i).ToString());
            }

        }

        

        private void btnUpdatePas_Click(object sender, EventArgs e)
        {
            generatePassMacIp();
            //ContextMenu cm = new ContextMenu();
            //cm.MenuItems.Add("Item 1");
            //cm.MenuItems.Add("Item 2");

            //tvMyPassword.ContextMenu = cm;

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
