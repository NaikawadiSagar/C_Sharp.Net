using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_Sysytem
{
    public partial class frm_View_Employee_List : Form
    {
        public frm_View_Employee_List()
        {
            InitializeComponent();
        }

        private void frm_View_Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Management_System_DBDataSet.tbl_Employee_Details' table. You can move, or remove it, as needed.
            this.tbl_Employee_DetailsTableAdapter.Fill(this.employee_Management_System_DBDataSet.tbl_Employee_Details);

            lbl_UName.Text = Common_Content.Log_UName;

        }

        private void dgv_View_Employee_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
