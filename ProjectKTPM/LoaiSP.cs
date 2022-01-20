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
    public partial class Department_Location : Telerik.WinControls.UI.RadForm
    {
        public Department_Location()
        {
            InitializeComponent();
        }

        private void Department_Location_Load(object sender, EventArgs e)
        {

            List<LOAI_SP> pROJECTs = new loaispBUS().GetAll();
            dv_loaisp.DataSource = pROJECTs;
        }
    }
}
