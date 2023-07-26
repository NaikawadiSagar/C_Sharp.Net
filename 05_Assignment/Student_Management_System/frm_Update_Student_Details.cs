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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
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

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_Number.Clear();
            dtp_DOB.Text = "10 - 6 - 2023";
            cmb_Course_Name.SelectedIndex = -1;
        }

        void Enabled_Controls()
        {
            tb_Roll_No.Enabled = false;
            tb_Name.Enabled = true;
            tb_Mobile_Number.Enabled = true;
            dtp_DOB.Enabled = true;
            cmb_Course_Name.Enabled = true;
        }
        void Disable_Controls()
        {
            tb_Roll_No.Enabled = true;
            tb_Name.Enabled = false;
            tb_Mobile_Number.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Course_Name.Enabled = false;
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Name.Text != "" && tb_Mobile_Number.Text != "" && cmb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update tbl_Student_Details Set Name = @Nm, DOB = @Dob,Mobile_No = @MobNo,Course = @Course where Student_Id= @RNO";

                Cmd.Parameters.Add("RNO", SqlDbType.Int).Value = tb_Roll_No.Text;

                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_Number.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");

                Clear_Controls();

                Disable_Controls();

                tb_Roll_No.Focus();
            }

            else
            {
                MessageBox.Show("1st Fill Al  Fields");
            }

            Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Roll_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From tbl_Student_Details where Student_Id = @RNo";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mobile_Number.Text = (Dr["Mobile_No"].ToString());
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    cmb_Course_Name.Text = Dr.GetString(Dr.GetOrdinal("Course"));

                    Enabled_Controls();
                }

                else
                {
                    MessageBox.Show("No Student Found With Given Roll No", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    tb_Roll_No.Clear();
                    tb_Roll_No.Focus();
                }
            }
            
            else
            {
                  MessageBox.Show("1st Enter ROll No.", "Information Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Want To Exit ?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Login_Form obj = new frm_Login_Form();
                obj.Show();
                this.Hide();
            }
        }
    }
}
