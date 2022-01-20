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
    public partial class Lien_He : Form
    {
        public Lien_He()
        {
            InitializeComponent();
        }

        private void Lien_He_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Sanh1 s = new Sanh1();
            s.Show();
            this.Close();
        }
    }
}
