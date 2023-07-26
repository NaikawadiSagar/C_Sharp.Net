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
    public partial class Frm_Add_Student_Details : Form
    {
        public Frm_Add_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-Q02I964;Initial Catalog=Student_Mangement_System_DB;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
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

        void Clear_Controls()
        {
           /// tb_RNO.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "10 - 6 - 2023";
            cmb_Course_Name.SelectedIndex = -1;

            tb_RNO.Focus();

            Auto_Increment();
        }
        private void Only_Numric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
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

            Cmd.CommandText = "Select Count(*) from  tbl_Student_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0)
            {
                /// Max StdId

                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Student_Id) from tbl_Student_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt++;
            }

            else
            { 
                Cnt = 101;
            }
            tb_RNO.Text = Convert.ToString(Cnt);
            Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_RNO.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into tbl_Student_Details Values(@Id, @Nm, @MobNo, @Dob, @Course)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value =        tb_RNO.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value =    tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value =      dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Clear_Controls();
            }

            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con_Close();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_Student_Details obj = new frm_View_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Frm_Add_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_UserName.Text = Comman_Content.Log_UName;
            Auto_Increment();
            tb_Name.Focus();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Exit ?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(Res == DialogResult.Yes)
            {
                frm_Login_Form obj = new frm_Login_Form();
                obj.Show();
                this.Hide();
            }

        }
    }
}
