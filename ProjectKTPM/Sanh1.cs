using BEL;
using FireSharp.Config;
using FireSharp.Interfaces;
using ProjectKTPM.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKTPM
{
    public partial class Sanh1 : Form
    {
        // public Account a = new Account();
        public string Username = "";
        public string Rule = "";

        Library library = new Library();

        IFirebaseClient client;
        public Sanh1()
        {

            ConnectFireBase();
            InitializeComponent();
        }
        public Sanh1(string username, string rule)
        {
            InitializeComponent();
            ConnectFireBase();
            this.Username = username;
            this.Rule = rule;
        }
        public bool ConnectFireBase()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "mtqW68Ko0KJ4gZbypVAFXvVB21K49n7pd8GLlAB7",
                // Realtime Database
                BasePath = "https://ktpm-156ad-default-rtdb.asia-southeast1.firebasedatabase.app/",
            };
            client = new FireSharp.FirebaseClient(config);
            try
            {
                if (client != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        private void Sanh1_Load(object sender, EventArgs e)
        {
            if (Username != null && Username != "")
            {
                txtUsername.Text = "Xin chào " + Username;
            }
         //   txtUsername.Text = "WELCOME BACK " + Account.usernamee;
          //  lb_gender.Text = "" + Informations.genderr;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Sanh sanh = new Sanh();
            sanh.Show();
           this.Close();
        }

        private void Sanh1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Lien_He lh = new Lien_He();
            lh.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
