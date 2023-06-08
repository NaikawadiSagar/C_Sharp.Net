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



namespace Employee_Management_Sysytem
{
    public partial class frm_Add_Employee : Form
    {
        public frm_Add_Employee()
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
        void Auto_Increment()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
                                                                                                                                                                                                                 
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From tbl_Employee_Details";

            Cnt = Convert.ToInt32( Cmd.ExecuteScalar() );

            Cmd.Dispose();

            if(Cnt > 0)
            {
                /// Max EmpId

                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Emp_Id) from tbl_Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt++;
            }
            else
            {
                Cnt = 101;
            }

            tb_Employee_Id.Text = Convert.ToString( Cnt );

            Con_Close();
        }
        void Clear_Controls()
        {
            tb_Employe_Name.Clear();
            tb_Employee_Mo_No.Clear();
            dtp_Date_Of_Birth.Text = "31-5-2023";
            cmb_Employee_Designation.SelectedIndex = -1;

            Auto_Increment();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Employee_Id.Text != "" && tb_Employe_Name.Text != "" && tb_Employee_Mo_No.Text != "" && cmb_Employee_Designation.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into tbl_Employee_Details Values(@Id,@Nm,@MobNo,@DOB,@Des)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Employee_Id.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Employe_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Employee_Mo_No.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Date_Of_Birth.Value.Date;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Employee_Designation.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }

            else
            {
                MessageBox.Show("1St Fill All Fileds", "Incomplete Info");
            }

            Con_Close();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Add_Employee_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Common_Content.Log_UName;

            Clear_Controls();

            tb_Employe_Name.Focus();
        }
        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            frm_View_Employee_List obj = new frm_View_Employee_List();
            obj.Show();
            this.Hide();
        }
        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form obj = new frm_Login_Form();
            obj.Show();
            this.Hide();
        }

        private void frm_Add_Employee_Load_1(object sender, EventArgs e)
        {
            Clear_Controls();
            lbl_UName.Text = Common_Content.Log_UName;

        }
    }
}
