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
    public partial class Product : Telerik.WinControls.UI.RadForm
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {

            List<SANPHAM> pROJECTs = new ProductBUS().GetAll();
            dv_product.DataSource = pROJECTs;
        }

        private void gvDeparment_Click(object sender, EventArgs e)
        {

        }

        private void dv_department_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            // pages.SetPage("");
        }

        private void bunifuThinButton26_Click_1(object sender, EventArgs e)
        {
         
        }
      

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
           
        }

        private void dv_mahoadon_SelectionChanged(object sender, EventArgs e)
        {


            if (dv_product.SelectedRows.Count > 0)
            {
                int Id = int.Parse(dv_product.SelectedRows[0].Cells["MaSP"].Value.ToString());
                SANPHAM sANPHAM = new ProductBUS().GetDetails(Id);
                if (sANPHAM != null)
                {
                    txtMASP.Text = sANPHAM.MASP.ToString();
                    txtLoai.Text = sANPHAM.MALOAI.ToString();
                    txtPrice.Text = sANPHAM.Gia.ToString();
                    txtSL.Text = sANPHAM.Soluong.ToString();
                    txtDes.Text = sANPHAM.Mota;
                    txtImage.Text =   sANPHAM.Anh;
                    txtNameProduct.Text = sANPHAM.Ten; ;
                }
            }
        }

        private void txtMASP_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dv_product_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form1 p = new Form1();
            p.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            String keyword = txt_search.Text.Trim();
            List<SANPHAM> sANPHAMs = new List<SANPHAM>();
            if (keyword.Length > 0)
            {
                sANPHAMs = new ProductBUS().Search(keyword);
                dv_product.DataSource = sANPHAMs;
            }
            else
            {
                sANPHAMs = new ProductBUS().GetAll();
                dv_product.DataSource = sANPHAMs;
            }
            //  List<Plane> planes = new PlaneBUS().Search(keyword);
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SANPHAM newPlane = new SANPHAM()
            {
                MASP = int.Parse(txtMASP.Text.Trim()),
                Ten = txtNameProduct.Text.Trim(),
                Gia = int.Parse(txtPrice.Text.Trim()),
                Soluong = int.Parse(txtSL.Text.Trim()),
                Mota = txtDes.Text.Trim(),
                Anh = txtImage.Text.Trim(),
                MALOAI = int.Parse(txtLoai.Text.Trim()),

            };
            bool result = new ProductBUS().AddNew(newPlane);
            if (result)
            {
                List<SANPHAM> planes = new ProductBUS().GetAll();
                dv_product.DataSource = planes;
            }
            else MessageBox.Show("Sorry please again");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SANPHAM newProduct = new SANPHAM()
            {
                MASP = int.Parse(txtMASP.Text.Trim()),
                Ten = txtNameProduct.Text.Trim(),
                Gia = int.Parse(txtPrice.Text.Trim()),
                Soluong = int.Parse(txtSL.Text.Trim()),
                Mota = txtDes.Text.Trim(),
                Anh = txtImage.Text.Trim(),
                MALOAI = int.Parse(txtLoai.Text.Trim())
            };
            bool result = new ProductBUS().Update(newProduct);
            if (result)
            {
                List<SANPHAM> sANPHAMs = new ProductBUS().GetAll();
                dv_product.DataSource = sANPHAMs;
            }
            else MessageBox.Show("Please Again");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chaa8c1 muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int Masp = int.Parse(txtMASP.Text);
                bool result = new ProductBUS().Delete(Masp);
                if (result)
                {
                    List<SANPHAM> sANPHAMs = new ProductBUS().GetAll();
                    dv_product.DataSource = sANPHAMs;
                }
                else { MessageBox.Show("Sorry please again"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = ofd.FileName;
            }
        }
    }

    }

