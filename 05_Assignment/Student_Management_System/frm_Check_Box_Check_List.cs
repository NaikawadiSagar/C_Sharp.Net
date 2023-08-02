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
    public partial class frm_Check_Box_Check_List : Form
    {
        public frm_Check_Box_Check_List()
        {
            InitializeComponent();
        }
        private void frm_Check_Box_Check_List_Load(object sender, EventArgs e)
        {
            lbl_Name.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            cmb_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_English.Checked = false;
            cb_French.Checked = false;

            for(int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true;

            if(tb_Name.Text != "")
            {
                Result += tb_Name.Text + " is From Department ";
                lbl_Name_Error.Visible = false;
            }

            else
            {
                lbl_Name_Error.Text = " Enter Employee Name";
                lbl_Name_Error.Visible = true;
                Flag = false;
            }

            if(cmb_Department.Text != "")
            {
                Result += cmb_Department.Text;
                lbl_Deparatment_Error.Visible = false;

            }
            else
            {
                lbl_Deparatment_Error.Visible = true;
                Flag = false;
            }

            if(rb_Male.Checked == true)
            {
                Result += " is" + rb_Male.Text + " And He Knows ";
                lbl_Gender_Error.Visible = false;
            }

            else if(rb_Female.Checked == true)
            {
                Result += ", is " + rb_Female.Text + " And She Knows ";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Visible = true;
                Flag = false;
            }

            if(cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text + ", ";
                lbl_Languages_Error.Visible = false;
            }

            if(cb_Hindi.Checked == true)
            {
                Result += cb_Hindi.Text + ", ";
                lbl_Languages_Error.Visible = false;
            }

            if(cb_English.Checked == true)
            {
                Result += cb_English.Text + ", ";
                lbl_Languages_Error.Visible = false;
            }

            if(cb_French.Checked == true)
            {
                Result += cb_French.Text + ", ";
                lbl_Languages_Error.Visible = false;
            }

            else
            {
                lbl_Languages_Error.Visible = true;
                Flag = true;
            }

            int Cnt = clb_Hobbies.CheckedItems.Count;

            if(Cnt > 0)
            {
                lbl_Hobbies_Error.Visible = true; ;
                Result += "And Has Hobbies As ";
            }

            else
            {
                lbl_Hobbies_Error.Visible = false;
                Flag = false;
            }

            for(int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                if(clb_Hobbies.GetItemChecked(i))
                {
                    if(Cnt > 1)
                    {
                        Result += clb_Hobbies.Items[i] + " ,";
                    } 

                    else
                    {
                        Result += clb_Hobbies.Items[i] + " ,";
                    }

                    Cnt--;
                }
            }

            if(Flag == false)
            {
                lbl_OutPut_Submit.Visible = false;

            }

            else
            {
                lbl_OutPut_Submit.Text = Result;
                lbl_OutPut_Submit.Visible = true;
            }
        }
    }
}
