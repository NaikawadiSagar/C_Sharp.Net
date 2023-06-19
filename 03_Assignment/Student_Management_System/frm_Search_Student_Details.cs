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
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
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

        void Enabled_Controls()
        {
            tb_Name.Enabled = false;
            tb_Mobile_Number.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Cousre_Name.Enabled = false;
        }

        void Disable_Controls()
        {
            tb_Roll_No.Enabled = true;
            tb_Name.Enabled = false;
            tb_Mobile_Number.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Cousre_Name.Enabled = false;
        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_Number.Clear();
            dtp_DOB.Text = "10 - 6 -2023";
            cmb_Cousre_Name.SelectedIndex = -1;

            tb_Roll_No.Focus();
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
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_Roll_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From tbl_Student_Details where Student_Id = @RNo";

                Cmd.Parameters.Add("RNO", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if(Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mobile_Number.Text = (Dr["Mobile_No"].ToString());
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    cmb_Cousre_Name.Text = Dr.GetString(Dr.GetOrdinal("Course"));

                    Disable_Controls();
                }

                else
                {
                    MessageBox.Show("No Student Found With Given Roll No", "INVALID",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

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
    }
}
