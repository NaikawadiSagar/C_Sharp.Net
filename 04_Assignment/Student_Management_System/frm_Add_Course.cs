using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-Q02I964;Initial Catalog=Student_Mangement_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Course_Id.Text != "" && tb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into tbl_Add_Course values(@Id,@Nm)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Course_Id.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully");
            }

            else
            {
                MessageBox.Show("1st Fill All Fileds");
            }
        }

        private void btn_View_Course_List_Click(object sender, EventArgs e)
        {
            frm_View_Add_Course obj = new frm_View_Add_Course();
            obj.Show();
            this.Hide();
        }
    }
}
