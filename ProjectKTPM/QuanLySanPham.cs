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
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {

            List<SANPHAM> pROJECTs = new ProductBUS().GetAll();
            dv_Product.DataSource = pROJECTs;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
          
        }

        private void dv_Product_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_2(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ProductCategory pc = new ProductCategory();
            pc.Show();

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //FormADD sps = new FormADD();
            //sps.Show();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            HoaDon p = new HoaDon();
            p.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblQuanLyPhong_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
