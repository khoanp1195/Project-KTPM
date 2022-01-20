using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKTPM
{
    public partial class Thongke : Form
    {
        public SqlConnection con = new SqlConnection("Data source =sql.bsite.net\\MSSQL2016; user id = minhquy_mydb; password=123456; initial catalog = minhquy_mydb");
        public Thongke()
        {
            InitializeComponent();
        }

        private void Thongke_Load(object sender, EventArgs e)
        {
          
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from SANPHAM", con);
                con.Open();
                da.Fill(dt);
                con.Close();
                MessageBox.Show("Do thanh cong");
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tong tien";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Date";
               chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series.Add("EX");
              chart1.Series["TongTien"]["DrawingStyle"] = "Cylinder";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["TongTien"].Points.AddXY(dt.Rows[i]["Ten"], dt.Rows[i]["Gia"]);
                  chart1.Series["EX"].Points.AddXY(dt.Rows[i]["Ten"], dt.Rows[i]["Gia"]);

                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
          //  // List<HoaDon> listhd = new HoaDonBUS().GetAll();
            //List<HOADON> hOADONs = new HoaDonBUS().GetAll();

            //   chart1.DataBind();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click_2(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from SANPHAM", con);
                con.Open();
                da.Fill(dt);
                con.Close();
                MessageBox.Show("Do thanh cong");
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Sản Phẩm";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = "Soluong";
                chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
             //   chart1.Series.Add("EX");
              //  chart1.Series["TongTien"]["DrawingStyle"] = "Cylinder";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    chart1.Series["Sản Phẩm"].Points.AddXY(dt.Rows[i]["Ten"], dt.Rows[i]["Soluong"]);
                //    chart1.Series["EX"].Points.AddXY(dt.Rows[i]["Ten"], dt.Rows[i]["Gia"]);

                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
}
