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
    public partial class KhachHang1 : Telerik.WinControls.UI.RadForm
    {
        public KhachHang1()
        {
            InitializeComponent();
        }

        private void lblChiTietLoaiPhong_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            //List<KHACHHANG> nhanViens = new KhachHangBUS().GetAll();
            //gv_khachhang.DataSource = nhanViens;


            new AccountBUS().ListenFirebase(gv_khachhang);
        }

        //private void gv_khachhang_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (KhachHang.SelectedRows.Count > 0)
        //    {
        //        int KH_ID = int.Parse(KhachHang.SelectedRows[0].Cells["KH_ID"].Value.ToString());
        //        KHACHHANG kHACHHANG = new KhachHangBUS().GetDetails(KH_ID);
        //        if (kHACHHANG != null)
        //        {
        //            txt_KHID.Text = kHACHHANG.KH_ID.ToString();
        //            txt_ten.Text = kHACHHANG.Ten.ToString();
        //            txt_pass.Text = kHACHHANG.MK.ToString();
        //            txt_Email.Text = kHACHHANG.Email.ToString();
        //            txt_dob.Text = kHACHHANG.Ngaysinh.ToString();
        //            txt_SDT.Text = kHACHHANG.SDT.ToString();
        //            txt_address.Text = kHACHHANG.Diachi.ToString();
        //            //txt_quyen.Text = kHACHHANG.Quyen.ToString();
        //            txt_trangthai.Text = kHACHHANG.Trangthai.ToString();


        //        }
        //    }
        //}

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //String keyword = txt_search.Text.Trim();
            //List<KHACHHANG> hOADONs = new List<KHACHHANG>();
            //if (keyword.Length > 0)
            //{
            //    hOADONs = new KhachHangBUS().Search(keyword);
            //    KhachHang.DataSource = hOADONs;
            //}
            //else
            //{
            //    hOADONs = new KhachHangBUS().GetAll();
            //    KhachHang.DataSource = hOADONs;
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User newAccount = new User()
            {
               Mssv = int.Parse(txt_KHID.Text.Trim()),
                Name = txt_ten.Text.Trim(),
            //    Password = txt_pass.Text.Trim(),
                Username = txt_Email.Text.Trim(),
                Age = int.Parse(txt_dob.Text.Trim()),
                Phone = int.Parse(txt_SDT.Text.Trim()),
                Address = txt_address.Text.Trim(),
              //  Rule = txt_quyen.Text.Trim(),
            };
            bool result = new AccountBUS().AddNew(newAccount);
            if (result)
            {
                MessageBox.Show("Add Success");
            }
            else
            {
                MessageBox.Show("Add Failed");
            }
            //KHACHHANG newKhachHang = new KHACHHANG()
            //{
            //    KH_ID = int.Parse(txt_KHID.Text.Trim()),
            //    Ten = txt_ten.Text.Trim(),
            //    MK = txt_pass.Text.Trim(),
            //    Email = txt_Email.Text.Trim(),
            //    Ngaysinh = DateTime.Parse(txt_dob.Text.Trim()),
            //    SDT = txt_SDT.Text.Trim(),
            //    Diachi = txt_address.Text.Trim(),
            //    Quyen = txt_quyen.Text.Trim(),
            //    Trangthai = int.Parse(txt_trangthai.Text.Trim()),


            //};
            //bool result = new KhachHangBUS().AddNew(newKhachHang);
            //if (result)
            //{
            //    List<KHACHHANG> kHACHHANGs = new KhachHangBUS().GetAll();
            //    gv_khachhang.DataSource = kHACHHANGs;
            //}
            //else MessageBox.Show("Sorry please again");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            User newUser = new User()
            {
               Mssv = int.Parse(txt_KHID.Text.Trim()),
                Name = txt_ten.Text.Trim(),
                Password = txt_pass.Text.Trim(),
                Username = txt_Email.Text.Trim(),
                Age = int.Parse(txt_dob.Text.Trim()),
                Phone = int.Parse(txt_SDT.Text.Trim()),
                Address = txt_address.Text.Trim(),
                Rule = txt_quyen.Text.Trim(),
           //     Image = int.Parse(txt_trangthai.Text.Trim()),
            };
            bool result = new AccountBUS().Update(newUser);
            if (result)
            {
                List<User> planes = new AccountBUS().GetAll();
                gv_khachhang.DataSource = planes;
            }
            else MessageBox.Show("Please Again");


            //KHACHHANG newKHACHHANG = new KHACHHANG()
            //{
            //    KH_ID = int.Parse(txt_KHID.Text.Trim()),
            //    Ten = txt_ten.Text.Trim(),
            //    MK = txt_pass.Text.Trim(),
            //    Email = txt_Email.Text.Trim(),
            //    Ngaysinh = DateTime.Parse(txt_dob.Text.Trim()),
            //    SDT = txt_SDT.Text.Trim(),
            //    Diachi = txt_address.Text.Trim(),
            //    Quyen = txt_quyen.Text.Trim(),
            //    Trangthai = int.Parse(txt_trangthai.Text.Trim()),

            //};
            //bool result = new KhachHangBUS().Update(newKHACHHANG);
            //if (result)
            //{
            //    List<KHACHHANG> kHACHHANGs = new KhachHangBUS().GetAll();
            //    gv_khachhang.DataSource = kHACHHANGs;
            //}
            //else MessageBox.Show("Please Again");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    int MAHD = int.Parse(txt_KHID.Text);
            //    bool result = new KhachHangBUS().Delete(MAHD);
            //    if (result)
            //    {
            //        List<KHACHHANG> hOADONs = new KhachHangBUS().GetAll();
            //        KhachHang.DataSource = hOADONs;
            //    }
            //    else { MessageBox.Show("Sorry please again"); }
            //}
        }

        private void gv_khachhang_SelectionChanged_1(object sender, EventArgs e)
        {
            if (gv_khachhang.SelectedRows.Count > 0)
            {
                int Mssv = int.Parse(gv_khachhang.SelectedRows[0].Cells["Mssv"].Value.ToString());
                User user = new AccountBUS().GetDetails(Mssv);
                if (user != null)
                {
                     txt_KHID.Text = user.Mssv.ToString();
                    txt_ten.Text = user.Name;
                    txt_Email.Text = user.Address;
                    txt_dob.Text = user.Age.ToString();
                    txt_SDT.Text = user.Phone.ToString();
                    txt_pass.Text = user.Password;
                    txt_quyen.Text = user.Rule;
                    txt_trangthai.Text = user.Gender;
                //   txt.Text = user.Password;


                }
            }
        }

        private void gv_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
