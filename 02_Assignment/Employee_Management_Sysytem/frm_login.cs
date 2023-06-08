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

namespace Employee_Management_Sysytem
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-Q02I964;Initial Catalog=Employee_Management_System_DB;Integrated Security=True");

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
            lbl_Note.ForeColor = Color.Green;
            lbl_Note.Text = "Enter Valid Username && Password";
        }

        private void btn_Footer_Click(object sender, EventArgs e)
        { 
            
             Con_Open();

             int Cnt = 0;

             SqlCommand Cmd = new SqlCommand();

             Cmd.Connection = Con;

             Cmd.CommandText = "Select Count(*) from tbl_Login_Details where User_Name = @Unm And Password = @Pwd";

             Cmd.Parameters.Add("Unm", SqlDbType.VarChar).Value = tb_Username.Text;
             Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

             
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar() );
            

            if(Cnt > 0)
            {
                MessageBox.Show("Login Succesfully", "Wellcome");
                Common_Content.Log_UName = tb_Username.Text;
                frm_Add_Employee obj = new frm_Add_Employee();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Incorrect Username Or Password !!";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();

            Con_Close();
        }

       
    }
}
