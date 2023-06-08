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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }
        private void frm_Login_Form_Load(object sender, EventArgs e)
        {
            lbl_Note.ForeColor = Color.Green;
            lbl_Note.Text = "Enter Valid Username && Password";
        }

        private void btn_Footer_Click(object sender, EventArgs e)
        { 
            if(tb_Username.Text == "Admin" && tb_Password.Text == "45")
            {
                MessageBox.Show("Login Successful");

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
        }

       
    }
}
