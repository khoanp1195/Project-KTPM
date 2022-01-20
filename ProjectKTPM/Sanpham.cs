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
    public partial class Sanpham : Form
    {
        public Sanpham()
        {
            InitializeComponent();
        }

        private void dv_Product_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            List<SANPHAM> pROJECTs = new ProductBUS().GetAll();
            dv_Product.DataSource = pROJECTs;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
