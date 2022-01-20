using ProjectKTPM.DAO;
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
    public partial class Employee_Dependence : Telerik.WinControls.UI.RadForm
    {
        public Employee_Dependence()
        {
            InitializeComponent();
        }

        private void Employee_Dependence_Load(object sender, EventArgs e)
        {
            List<DiaDiemPhongBan> thanNhans = new DiaDiemPhongBanBUS().GetAll();
           gvthannhan.DataSource = thanNhans;
 
        }

        private void gvthannhan_Click(object sender, EventArgs e)
        {

        }
    }
}
