using ProjectKTPM.BUS;
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
    public partial class FormADD : Telerik.WinControls.UI.RadForm
    {
        public FormADD()
        {
            InitializeComponent();
        }

        private void FormADD_Load(object sender, EventArgs e)
        {
            List<SP_HD> sP_HDs = new SP_HDBUS().GetAll();
            gvSP_HD.DataSource = sP_HDs;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            SP_HD newSP_HD = new SP_HD()
            {
                MASP = txtMASP.Text.Trim(),
                MAHD = int.Parse(txtMAHD.Text.Trim()),
                Gia = int.Parse(txtGia.Text.Trim()),
                Soluong = int.Parse(txtSoLuong.Text.Trim()),
            
            };
            bool result = new SP_HDBUS().AddNew(newSP_HD);
            if (result)
            {
                List<SP_HD> sP_HDs = new SP_HDBUS().GetAll();
                gvSP_HD.DataSource = sP_HDs;
            }
            else MessageBox.Show("Sorry please again");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SP_HD newSP_HD = new SP_HD()
            {
                MASP = txtMASP.Text.Trim(),
                MAHD = int.Parse(txtMAHD.Text.Trim()),
                Gia = int.Parse(txtGia.Text.Trim()),
                Soluong = int.Parse(txtSoLuong.Text.Trim()),
              
         
            };
            bool result = new SP_HDBUS().Update(newSP_HD);
            if (result)
            {
                List<SP_HD> sP_HDs = new SP_HDBUS().GetAll();
                gvSP_HD.DataSource = sP_HDs;
            }
            else MessageBox.Show("Please Again");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chaa8c1 muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int MAHD = int.Parse(txtMAHD.Text);
                bool result = new SP_HDBUS().Delete(MAHD);
                if (result)
                {
                    List<SP_HD> sP_HDs = new SP_HDBUS().GetAll();
                    gvSP_HD.DataSource = sP_HDs;
                }
                else { MessageBox.Show("Sorry please again"); }
            }
        }

        private void gvSP_HD_SelectionChanged(object sender, EventArgs e)
        {
            if (gvSP_HD.SelectedRows.Count > 0)
            {
                int Id = int.Parse(gvSP_HD.SelectedRows[0].Cells["MAHD"].Value.ToString());
                 SP_HD sP_HD = new SP_HDBUS().GetDetails(Id);
                if (sP_HD != null)
                {
                    txtMASP.Text = sP_HD.MASP.ToString();
                    txtMAHD.Text = sP_HD.MAHD.ToString();
                    txtGia.Text = sP_HD.Gia.ToString();
                    txtSoLuong.Text = sP_HD.Soluong.ToString();
                    
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            String keyword = txt_search.Text.Trim();
            List<SP_HD> sP_HDs = new List<SP_HD>();
            if (keyword.Length > 0)
            {
                sP_HDs = new SP_HDBUS().Search(keyword);
                gvSP_HD.DataSource = sP_HDs;
            }
            else
            {
                sP_HDs = new SP_HDBUS().GetAll();
                gvSP_HD.DataSource = sP_HDs;
            }
            //  List<Plane> planes = new PlaneBUS().Search(keyword);
        }
    }
}
