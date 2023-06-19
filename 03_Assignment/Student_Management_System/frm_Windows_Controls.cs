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
    public partial class frm_Windows_Controls : Form
    {
        public frm_Windows_Controls()
        {
            InitializeComponent();
        }

        private void frm_Windows_Controls_Load(object sender, EventArgs e)
        {
            tb_Employee_Name.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = false;

            if(tb_Employee_Name.Text != "")
            {

                Result = tb_Employee_Name.Text;

                if(cmb_Emp_Dept.Text != "")
                {
                    Result += " from department " + cmb_Emp_Dept.Text + "is";

                    if(rb_Male.Checked == true)
                    {
                        Result += rb_Male.Text + " Candidate,Prefers Shift Timing ";
                    }

                    else if(rb_Female.Checked == true)
                    {
                        Result += rb_Female.Text + " Candidate,Prefers Shift Timing ";
                    }

                    else
                    {
                        MessageBox.Show(" Select Gender Of Employee ");
                        Flag = true;
                    }

                    if(rb_Shift_Morning.Checked == true)
                    {
                        Result += rb_Shift_Morning.Text + ".";
                    }

                    else if(rb_Shift_Evening.Checked == true)
                    {
                        Result += rb_Shift_Evening.Text + ".";
                    }

                    else if(rb_Shift_Time_Night.Checked == true)
                    {
                        Result += rb_Shift_Time_Night.Text + ".";
                    }

                    else
                    {
                        MessageBox.Show("Select Shift Time");
                        Flag = true;
                    }
                }
                else
                {
                    MessageBox.Show(" Select Employees Department ");
                    Flag = true;
                }
            }
            else
            {
                MessageBox.Show(" Enter Name OF Employee ");
                Flag = true;
            }

            if(Flag == false)
            {
                tb_Output.Text = Result;
            }
        }
    }
        
}
