using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net;
using System.Threading.Tasks;
namespace JuceVNC
{
    public partial class Form2 : Form
    {
        private bool Auth = false;
        ContextMenu cm;
        private System.Windows.Forms.MenuItem menuComputer1;
        private System.Windows.Forms.MenuItem menuComputer2;
        private string token;
        
        
        public Form2(bool auth)
        {
            token = "";
            InitializeComponent();
            initContextMenu();
            System.Console.WriteLine(auth);
            this.Auth = auth;
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
           
        }
        private void menuComputer2_Click(object Sender, EventArgs e)
        {
           
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            if (Auth)
            {
                lbNamePC.Visible = true;
            }
            else {
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

        static async Task MainAsyncAuthorization(User user)
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
                var result = await client.PostAsync("/users/register", content);
                string resultContent = await result.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent);
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
                else {
                    Console.WriteLine(result.Content.ReadAsAsync<Auth>().Result.Message);
                    return null;
                }
                
            }
        }

        private void lLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogPanel.Visible = true;
            regPanel.Visible = false;

           

            /*
            string postData = "ver=1&cmd=abf";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Post the data to the right place.
            Uri target = new Uri("http://localhost:8080/users/register"); 
            WebRequest request = WebRequest.Create(target);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            using (var dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
               //Do what you need to do with the response.
            }
            */
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

            //Task.Run(() => MainAsyncLogIn(email, password));
            this.token = MainAsyncLogIn(email, password).Result;
            if (token != null)
            {

            }
            else { 
            
            }
            System.Console.WriteLine("token = " + token);
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = etLogin.Text.ToString();
            user.Password = etPassword.Text.ToString();
            user.ConfirmPassword = etConfirmPassword.Text.ToString();
            user.Email = etEmail.Text.ToString();
            user.Organization = etOrganization.Text.ToString();

            Task.Run(() => MainAsyncAuthorization(user));
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
        }

        private void lbNamePC_MouseUp(object sender, MouseEventArgs e)
        {
            int location = lbNamePC.IndexFromPoint(e.Location);
            if (e.Button == MouseButtons.Right)
            {
                lbNamePC.SelectedIndex = location;                //Index selected
                cm.Show(lbNamePC, e.Location);   //Show Menu
            }
        }

    }
}
