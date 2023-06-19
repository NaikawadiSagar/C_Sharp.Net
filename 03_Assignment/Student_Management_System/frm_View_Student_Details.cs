using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Mangement_System_DBDataSet.tbl_Student_Details' table. You can move, or remove it, as needed.
            this.tbl_Student_DetailsTableAdapter.Fill(this.student_Mangement_System_DBDataSet.tbl_Student_Details);
            lbl_UserName.Text = Comman_Content.Log_UName;

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form Obj = new frm_Login_Form();
            Obj.Show();
            this.Hide();
        }
    }
}
