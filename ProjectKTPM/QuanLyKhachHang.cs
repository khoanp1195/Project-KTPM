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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            KhachHang1 em = new KhachHang1();
            this.Close();
  

            em.Show();
          
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            List<KHACHHANG> nhanViens = new KhachHangBUS().GetAll();
            dv_khachhang.DataSource = nhanViens;
        }
    }
}
