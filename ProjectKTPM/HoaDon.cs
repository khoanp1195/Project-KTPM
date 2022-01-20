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
    public partial class HoaDon : Telerik.WinControls.UI.RadForm
    {
        public HoaDon()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Project_Load(object sender, EventArgs e)
        {

            List<HOADON> pROJECTs = new HoaDonBUS().GetAll();
            gvProject.DataSource = pROJECTs;
        }

        private void gvProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvProject_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            String keyword = txt_search.Text.Trim();
            List<HOADON> hOADONs = new List<HOADON>();
            if (keyword.Length > 0)
            {
                hOADONs = new HoaDonBUS().Search(keyword);
                gvProject.DataSource = hOADONs;
            }
            else
            {
                hOADONs = new HoaDonBUS().GetAll();
                gvProject.DataSource = hOADONs;
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int MAHD = int.Parse(txtMAHD.Text);
                bool result = new HoaDonBUS().Delete(MAHD);
                if (result)
                {
                    List<HOADON> hOADONs = new HoaDonBUS().GetAll();
                    gvProject.DataSource = hOADONs;
                }
                else { MessageBox.Show("Sorry please again"); }
            }
        }

        private void gvProject_SelectionChanged(object sender, EventArgs e)
        {
            if (gvProject.SelectedRows.Count > 0)
            {
                int MAHD = int.Parse(gvProject.SelectedRows[0].Cells["MAHD"].Value.ToString());
                HOADON hOADON = new HoaDonBUS().GetDetails(MAHD);
                if (hOADON != null)
                {
                    txtMAHD.Text = hOADON.MAHD.ToString();
                    txtNgayTao.Text = hOADON.Ngaytao.ToString();
                    txtKH.Text = hOADON.TenKH.ToString();
                    txtTongTien.Text = hOADON.Tongtien.ToString();
                    txt_trangthai.Text = hOADON.Trangthai.ToString();
                    txt_diachiKH.Text = hOADON.DiachiKH.ToString();

                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            HOADON newHOADON = new HOADON()
            {
                MAHD = int.Parse(txtMAHD.Text.Trim()),
                Ngaytao = DateTime.Parse(txtNgayTao.Text.Trim()),
                TenKH = txtKH.Text.Trim(),
                Tongtien = int.Parse(txtTongTien.Text.Trim()),
                Trangthai = int.Parse(txt_trangthai.Text.Trim()),
                DiachiKH =  txt_diachiKH.Text.Trim(),
   
            };
            bool result = new HoaDonBUS().AddNew(newHOADON);
            if (result)
            {
                List<HOADON> hOADONs = new HoaDonBUS().GetAll();
                gvProject.DataSource = hOADONs;
            }
            else MessageBox.Show("Sorry please again");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            HOADON newHOADON = new HOADON()
            {
                MAHD = int.Parse(txtMAHD.Text.Trim()),
                Ngaytao = DateTime.Parse(txtNgayTao.Text.Trim()),
                TenKH = txtKH.Text.Trim(),
                Tongtien = int.Parse(txtTongTien.Text.Trim()),
                Trangthai = int.Parse(txt_trangthai.Text.Trim()),
                DiachiKH = txt_diachiKH.Text.Trim(),

            };
            bool result = new HoaDonBUS().Update(newHOADON);
            if (result)
            {
                List<HOADON> hOADONs = new HoaDonBUS().GetAll();
                gvProject.DataSource = hOADONs;
            }
            else MessageBox.Show("Please Again");
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Thongke tk = new Thongke();
            tk.Show();        }
    }
}
