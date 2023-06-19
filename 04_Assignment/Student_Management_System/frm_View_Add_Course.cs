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
    public partial class frm_View_Add_Course : Form
    {
        public frm_View_Add_Course()
        {
            InitializeComponent();
        }

        private void frm_View_Add_Course_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Mangement_System_DBDataSet1.tbl_Add_Course' table. You can move, or remove it, as needed.
            this.tbl_Add_CourseTableAdapter.Fill(this.student_Mangement_System_DBDataSet1.tbl_Add_Course);

        }

    }
}
