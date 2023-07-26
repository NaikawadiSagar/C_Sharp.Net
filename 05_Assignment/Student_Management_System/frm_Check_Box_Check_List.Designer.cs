
namespace Student_Management_System
{
    partial class frm_Check_Box_Check_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Emp_General_Details = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Emp_Dept = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.lbl_Know_Lang = new System.Windows.Forms.Label();
            this.gb_Known_Lang = new System.Windows.Forms.GroupBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_OutPut_Submit = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Name_Error = new System.Windows.Forms.Label();
            this.lbl_Deparatment_Error = new System.Windows.Forms.Label();
            this.lbl_Gender_Error = new System.Windows.Forms.Label();
            this.lbl_Languages_Error = new System.Windows.Forms.Label();
            this.lbl_Hobbies_Error = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.gb_Gender.SuspendLayout();
            this.gb_Known_Lang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Emp_General_Details
            // 
            this.lbl_Emp_General_Details.AutoSize = true;
            this.lbl_Emp_General_Details.BackColor = System.Drawing.Color.White;
            this.lbl_Emp_General_Details.Font = new System.Drawing.Font("Bookman Old Style", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_General_Details.ForeColor = System.Drawing.Color.Red;
            this.lbl_Emp_General_Details.Location = new System.Drawing.Point(306, 28);
            this.lbl_Emp_General_Details.Name = "lbl_Emp_General_Details";
            this.lbl_Emp_General_Details.Size = new System.Drawing.Size(515, 44);
            this.lbl_Emp_General_Details.TabIndex = 0;
            this.lbl_Emp_General_Details.Text = "Employee General Details";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Name.Location = new System.Drawing.Point(26, 125);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(179, 24);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Employee Name";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(335, 113);
            this.tb_Name.MaxLength = 50;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(315, 36);
            this.tb_Name.TabIndex = 1;
            // 
            // lbl_Emp_Dept
            // 
            this.lbl_Emp_Dept.AutoSize = true;
            this.lbl_Emp_Dept.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Dept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Emp_Dept.Location = new System.Drawing.Point(26, 208);
            this.lbl_Emp_Dept.Name = "lbl_Emp_Dept";
            this.lbl_Emp_Dept.Size = new System.Drawing.Size(249, 24);
            this.lbl_Emp_Dept.TabIndex = 2;
            this.lbl_Emp_Dept.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Gender.Location = new System.Drawing.Point(26, 319);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(88, 24);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Location = new System.Drawing.Point(344, 292);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(306, 88);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(180, 27);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(97, 25);
            this.rb_Female.TabIndex = 1;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(35, 27);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(73, 25);
            this.rb_Male.TabIndex = 0;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // lbl_Know_Lang
            // 
            this.lbl_Know_Lang.AutoSize = true;
            this.lbl_Know_Lang.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Know_Lang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Know_Lang.Location = new System.Drawing.Point(696, 162);
            this.lbl_Know_Lang.Name = "lbl_Know_Lang";
            this.lbl_Know_Lang.Size = new System.Drawing.Size(177, 21);
            this.lbl_Know_Lang.TabIndex = 4;
            this.lbl_Know_Lang.Text = "Known Lanuages";
            // 
            // gb_Known_Lang
            // 
            this.gb_Known_Lang.Controls.Add(this.cb_French);
            this.gb_Known_Lang.Controls.Add(this.cb_English);
            this.gb_Known_Lang.Controls.Add(this.cb_Hindi);
            this.gb_Known_Lang.Controls.Add(this.cb_Marathi);
            this.gb_Known_Lang.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.gb_Known_Lang.ForeColor = System.Drawing.Color.Orange;
            this.gb_Known_Lang.Location = new System.Drawing.Point(889, 113);
            this.gb_Known_Lang.Name = "gb_Known_Lang";
            this.gb_Known_Lang.Size = new System.Drawing.Size(256, 106);
            this.gb_Known_Lang.TabIndex = 4;
            this.gb_Known_Lang.TabStop = false;
            this.gb_Known_Lang.Text = "Known Languages";
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Location = new System.Drawing.Point(141, 73);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(88, 27);
            this.cb_French.TabIndex = 3;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.ForeColor = System.Drawing.Color.Orange;
            this.cb_English.Location = new System.Drawing.Point(6, 73);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(92, 27);
            this.cb_English.TabIndex = 2;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Location = new System.Drawing.Point(141, 19);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(78, 27);
            this.cb_Hindi.TabIndex = 1;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(6, 19);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(99, 27);
            this.cb_Marathi.TabIndex = 0;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Hobbies.Location = new System.Drawing.Point(696, 302);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(94, 24);
            this.lbl_Hobbies.TabIndex = 5;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.clb_Hobbies.ForeColor = System.Drawing.Color.Orange;
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Plyaing",
            "Swiming",
            "Driving\t",
            "Cycling"});
            this.clb_Hobbies.Location = new System.Drawing.Point(904, 292);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(157, 124);
            this.clb_Hobbies.TabIndex = 5;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_Output.Location = new System.Drawing.Point(26, 511);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(79, 24);
            this.lbl_Output.TabIndex = 7;
            this.lbl_Output.Text = "Output";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_OutPut_Submit);
            this.panel1.Location = new System.Drawing.Point(145, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 34);
            this.panel1.TabIndex = 8;
            // 
            // lbl_OutPut_Submit
            // 
            this.lbl_OutPut_Submit.AutoSize = true;
            this.lbl_OutPut_Submit.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutPut_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_OutPut_Submit.Location = new System.Drawing.Point(4, 10);
            this.lbl_OutPut_Submit.Name = "lbl_OutPut_Submit";
            this.lbl_OutPut_Submit.Size = new System.Drawing.Size(303, 17);
            this.lbl_OutPut_Submit.TabIndex = 0;
            this.lbl_OutPut_Submit.Text = "Output of Submit Button Appears Here";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(355, 442);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(123, 41);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Submit.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(737, 442);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(111, 41);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Name_Error
            // 
            this.lbl_Name_Error.AutoSize = true;
            this.lbl_Name_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name_Error.Location = new System.Drawing.Point(565, 152);
            this.lbl_Name_Error.Name = "lbl_Name_Error";
            this.lbl_Name_Error.Size = new System.Drawing.Size(60, 13);
            this.lbl_Name_Error.TabIndex = 11;
            this.lbl_Name_Error.Text = "Name Error";
            this.lbl_Name_Error.Visible = false;
            // 
            // lbl_Deparatment_Error
            // 
            this.lbl_Deparatment_Error.AutoSize = true;
            this.lbl_Deparatment_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Deparatment_Error.Location = new System.Drawing.Point(565, 236);
            this.lbl_Deparatment_Error.Name = "lbl_Deparatment_Error";
            this.lbl_Deparatment_Error.Size = new System.Drawing.Size(87, 13);
            this.lbl_Deparatment_Error.TabIndex = 12;
            this.lbl_Deparatment_Error.Text = "Department Error";
            this.lbl_Deparatment_Error.Visible = false;
            // 
            // lbl_Gender_Error
            // 
            this.lbl_Gender_Error.AutoSize = true;
            this.lbl_Gender_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Gender_Error.Location = new System.Drawing.Point(565, 383);
            this.lbl_Gender_Error.Name = "lbl_Gender_Error";
            this.lbl_Gender_Error.Size = new System.Drawing.Size(67, 13);
            this.lbl_Gender_Error.TabIndex = 13;
            this.lbl_Gender_Error.Text = "Gender Error";
            this.lbl_Gender_Error.Visible = false;
            // 
            // lbl_Languages_Error
            // 
            this.lbl_Languages_Error.AutoSize = true;
            this.lbl_Languages_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Languages_Error.Location = new System.Drawing.Point(1019, 236);
            this.lbl_Languages_Error.Name = "lbl_Languages_Error";
            this.lbl_Languages_Error.Size = new System.Drawing.Size(85, 13);
            this.lbl_Languages_Error.TabIndex = 14;
            this.lbl_Languages_Error.Text = "Languages Error";
            this.lbl_Languages_Error.Visible = false;
            // 
            // lbl_Hobbies_Error
            // 
            this.lbl_Hobbies_Error.AutoSize = true;
            this.lbl_Hobbies_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hobbies_Error.Location = new System.Drawing.Point(1034, 442);
            this.lbl_Hobbies_Error.Name = "lbl_Hobbies_Error";
            this.lbl_Hobbies_Error.Size = new System.Drawing.Size(74, 13);
            this.lbl_Hobbies_Error.TabIndex = 15;
            this.lbl_Hobbies_Error.Text = "Hobbies_Error";
            this.lbl_Hobbies_Error.Visible = false;
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "HR",
            "Manager\t",
            "Team Leader",
            "Fresher"});
            this.cmb_Department.Location = new System.Drawing.Point(335, 191);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(315, 37);
            this.cmb_Department.TabIndex = 2;
            // 
            // frm_Check_Box_Check_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 572);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.lbl_Hobbies_Error);
            this.Controls.Add(this.lbl_Languages_Error);
            this.Controls.Add(this.lbl_Gender_Error);
            this.Controls.Add(this.lbl_Deparatment_Error);
            this.Controls.Add(this.lbl_Name_Error);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.gb_Known_Lang);
            this.Controls.Add(this.lbl_Know_Lang);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Emp_Dept);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Emp_General_Details);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Check_Box_Check_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Check_Box_Check_List";
            this.Load += new System.EventHandler(this.frm_Check_Box_Check_List_Load);
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Known_Lang.ResumeLayout(false);
            this.gb_Known_Lang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Emp_General_Details;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Emp_Dept;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.Label lbl_Know_Lang;
        private System.Windows.Forms.GroupBox gb_Known_Lang;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_OutPut_Submit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Name_Error;
        private System.Windows.Forms.Label lbl_Deparatment_Error;
        private System.Windows.Forms.Label lbl_Gender_Error;
        private System.Windows.Forms.Label lbl_Languages_Error;
        private System.Windows.Forms.Label lbl_Hobbies_Error;
        private System.Windows.Forms.ComboBox cmb_Department;
    }
}