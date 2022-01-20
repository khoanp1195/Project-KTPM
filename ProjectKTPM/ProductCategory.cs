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
    public partial class ProductCategory : Telerik.WinControls.UI.RadForm
    {
        public ProductCategory()
        {
            InitializeComponent();
        }

        private void ProductCategory_Load(object sender, EventArgs e)
        {
            List<LOAI_SP> pROJECTs = new loaispBUS().GetAll();
            dv_loaisp.DataSource = pROJECTs;
        }

        private void dv_loaisp_SelectionChanged(object sender, EventArgs e)
        {
            if (dv_loaisp.SelectedRows.Count > 0)
            {
                int Id = int.Parse(dv_loaisp.SelectedRows[0].Cells["MALOAI"].Value.ToString());
                LOAI_SP lOAI_SP = new loaispBUS().GetDetails(Id);
                if (lOAI_SP != null)
                {
                    txt_MaLoai.Text = lOAI_SP.MALOAI.ToString();
                    txt_TenLoai.Text = lOAI_SP.Ten; ;
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            String keyword = txt_search.Text.Trim();
            List<LOAI_SP> lOAI_SPs = new List<LOAI_SP>();
            if (keyword.Length > 0)
            {
                lOAI_SPs = new loaispBUS().Search(keyword);
                dv_loaisp.DataSource = lOAI_SPs;
            }
            else
            {
                lOAI_SPs = new loaispBUS().GetAll();
                dv_loaisp.DataSource = lOAI_SPs;
            }
            //  List<Plane> planes = new PlaneBUS().Search(keyword);
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            LOAI_SP newLoai = new LOAI_SP()
            {
                MALOAI = int.Parse(txt_MaLoai.Text.Trim()),
                Ten = txt_TenLoai.Text.Trim(),
              

            };
            bool result = new loaispBUS().AddNew(newLoai);
            if (result)
            {
                List<LOAI_SP> lOAI_SPs = new loaispBUS().GetAll();
                dv_loaisp.DataSource = lOAI_SPs;
            }
            else MessageBox.Show("Sorry please again");
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            LOAI_SP newLoai = new LOAI_SP()
            {
                MALOAI = int.Parse(txt_MaLoai.Text.Trim()),
                Ten = txt_TenLoai.Text.Trim()
             
            };
            bool result = new loaispBUS().Update(newLoai);
            if (result)
            {
                List<LOAI_SP> lOAI_SPs = new loaispBUS().GetAll();
                dv_loaisp.DataSource = lOAI_SPs;
            }
            else MessageBox.Show("Please Again");
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chaa8c1 muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int Masp = int.Parse(txt_MaLoai.Text);
                bool result = new loaispBUS().Delete(Masp);
                if (result)
                {
                    List<LOAI_SP> sANPHAMs = new loaispBUS().GetAll();
                    dv_loaisp.DataSource = sANPHAMs;
                }
                else { MessageBox.Show("Sorry please again"); }
            }
        }
    }
}
