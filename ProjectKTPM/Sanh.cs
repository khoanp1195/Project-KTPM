
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
    public partial class Sanh : Form
    {
        public Sanh()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
             DangKy si = new DangKy();
            this.Hide();
            si.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn si = new SignIn();
            this.Hide();
            si.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DangKy si = new DangKy();
            this.Hide();
            si.Show();
        }
    }
}
