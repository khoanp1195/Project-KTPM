using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;
using ProjectKTPM.MODEL;
using ProjectKTPM.BUS;
using System.Security.Cryptography;
using FireSharp.Interfaces;
using FireSharp.Config;
using FireSharp.Response;
using DoAnChuyenNganh;

namespace ProjectKTPM
{
    public partial class SignIn : Form
    {
        public Informations info = new Informations();
        public Operations opr = new Operations();
        public string Quyen;

        DataTable dt = new DataTable();
        IFirebaseClient client;

        Library library = new Library();

        public bool ConnectFireBase()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "mtqW68Ko0KJ4gZbypVAFXvVB21K49n7pd8GLlAB7",
                // Realtime Database
                BasePath = "https://ktpm-156ad-default-rtdb.asia-southeast1.firebasedatabase.app/",
            };
            client = new FireSharp.FirebaseClient(config);
            try
            {
                if (client != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUname_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;

        }

        private void tbPass_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            txtPassword.BackColor = Color.White;

            txtUsername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            DangKy si = new DangKy();
            this.Hide();
           si.Show();
        }
        public string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            if (ConnectFireBase())
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    string Username = txtUsername.Text.Trim();
                    string Password = library.MD5Hash(txtPassword.Text.Trim());
                    try
                    {
                        FirebaseResponse response = await client.GetAsync("accountss/" + Username);
                        User responseUser = response.ResultAs<User>();
                        User currentUser = new User()
                        {
                            Username = Username,
                            Password = Password
                        };
                        if (User.checkLogin(responseUser, currentUser))
                        {
                           // ResetData();
                            this.Hide();
                            //Sanh1 s = new Sanh1();
                            //s.Show();

                            Form1 frm = new Form1(responseUser.Username, responseUser.Rule);
                            frm.Show();
                        }
                        else
                        {
                            MessageBox.Show(User.error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lỗi kết nối với hệ thống. Vui lòng kiểm tra lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Account Account = new Account()
            //{
            //    username = tbUname.Text.Trim(),
            //    password = MD5Hash(tbPass.Text.Trim())

            //};
            //bool result = new AccountBUS().CheckAccount(Account);
            //if (result) 
            //{
            //     //Account.usernamee.ToString();
            //    new Sanh1().Show();
            //    this.Hide();
            //}
            //else MessageBox.Show("Sorry please again");

            //if (tbUname.Text.Trim() == "")
            //{
            //    MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbUname.Focus();
            //    return;
            //}
            //else if (tbUname.Text.Trim().Length < 1 || tbUname.Text.Trim().Length > 255)
            //{
            //    MessageBox.Show("Độ dài tối thiểu của tài khoản là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbUname.Focus();
            //    return;
            //}
            //else
            //{
            //    info.username = tbUname.Text;
            //};


            //if (tbPass.Text.Trim() == "")
            //{
            //    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbPass.Focus();
            //    return;
            //}
            //else if (tbPass.Text.Trim().Length < 6 || tbPass.Text.Trim().Length > 255)
            //{
            //    MessageBox.Show("Độ dài tối thiểu của mật khẩu là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbPass.Focus();
            //    return;
            //}
            //else
            //{
            //    info.password = tbPass.Text;
            //};


            //dt = opr.login(info);

            //if (dt.Rows.Count > 0)
            //{
            //    utype = dt.Rows[0][8].ToString().Trim();
            //    if (utype == "admin")
            //    {
            //        Informations.usernamee = dt.Rows[0]["Username"].ToString();
            //        this.Hide();
            //     Sanh1 mda = new Sanh1();
            //      mda.Show();
            //    }
            //    else
            //    {

            //        Informations.usernamee = dt.Rows[0]["Username"].ToString();
            //        Informations.namee = dt.Rows[0]["Name"].ToString();
            //        Informations.addresss = dt.Rows[0]["Address"].ToString();
            //        Informations.educationn = dt.Rows[0]["Education"].ToString();
            //        Informations.usertype = dt.Rows[0]["Usertype"].ToString();
            //        Informations.dobb = dt.Rows[0]["DOB"].ToString();
            //        Informations.genderr = dt.Rows[0]["Gender"].ToString();


            //        this.Hide();

            //       Sanh1 mde = new Sanh1();
            //      mde.Show();
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password !");
            //}
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            else if (txtUsername.Text.Trim().Length < 1 || txtUsername.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của tài khoản là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }
            else
            {
                info.Ten = txtUsername.Text;
            };


            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            else if (txtPassword.Text.Trim().Length < 6 || txtPassword.Text.Trim().Length > 255)
            {
                MessageBox.Show("Độ dài tối thiểu của mật khẩu là 6 và tối đa là 255", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            else
            {
                info.MK = MD5Hash(txtPassword.Text);
            };


            dt = opr.login(info);

            if (dt.Rows.Count > 0)
            {
                Quyen = dt.Rows[0][8].ToString().Trim();
                if (Quyen == "1")
                {
                   // Informations.username = dt.Rows[0]["Username"].ToString();
                    this.Hide();
                    Form1 mda = new Form1();
                    mda.Show();
                }
                else
                {

                    ////Informations.usernamee = dt.Rows[0]["Username"].ToString();
                    ////Informations.namee = dt.Rows[0]["Name"].ToString();
                    ////Informations.addresss = dt.Rows[0]["Address"].ToString();
                    ////Informations.educationn = dt.Rows[0]["Education"].ToString();
                    ////Informations.usertype = dt.Rows[0]["Usertype"].ToString();
                    ////Informations.dobb = dt.Rows[0]["DOB"].ToString();
                    ////Informations.genderr = dt.Rows[0]["Gender"].ToString();
                    // info.Quyenn = dt.Rows[0]["Quyen"].ToString();

                    //this.Hide();

                    //Sanh1 mde = new Sanh1();
                    //mde.Show();
                    MessageBox.Show("You aren't Admin, Please Contact Admin to be role !");
                }

            }
            else
            {
                MessageBox.Show("Invalid username or password !");
            }
        }
    }
}
