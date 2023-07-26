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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
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
        private void frm_Login_Form_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter Valid Username && Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from tbl_Std_Login_Details where User_Name = @Unm And Password = @Pwd";

            Cmd.Parameters.Add("Unm", SqlDbType.NVarChar).Value = tb_UserName.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if(Cnt > 0)
            {
                MessageBox.Show("Login Successful", "Wellcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Comman_Content.Log_UName = tb_UserName.Text;

                MDI_Student_App Obj = new MDI_Student_App();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid Username Or Password";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_UserName.Clear();
            tb_Password.Clear();

            Con_Close();
        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {
            lbl_Note.Visible = true;
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
