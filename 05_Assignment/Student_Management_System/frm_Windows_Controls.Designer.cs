
namespace Student_Management_System
{
    partial class frm_Windows_Controls
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Dept = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.tb_Emp_Name = new System.Windows.Forms.TextBox();
            this.cmb_Emp_Dept = new System.Windows.Forms.ComboBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Gender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.White;
            this.lbl_Name.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Name.Location = new System.Drawing.Point(35, 127);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(226, 32);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Employee Name";
            // 
            // lbl_Dept
            // 
            this.lbl_Dept.AutoSize = true;
            this.lbl_Dept.BackColor = System.Drawing.Color.White;
            this.lbl_Dept.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Dept.Location = new System.Drawing.Point(35, 223);
            this.lbl_Dept.Name = "lbl_Dept";
            this.lbl_Dept.Size = new System.Drawing.Size(310, 32);
            this.lbl_Dept.TabIndex = 1;
            this.lbl_Dept.Text = "Employee Department";
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.BackColor = System.Drawing.Color.White;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Shift_Time.Location = new System.Drawing.Point(35, 432);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(154, 32);
            this.lbl_Shift_Time.TabIndex = 2;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.BackColor = System.Drawing.Color.White;
            this.lbl_Output.Font = new System.Drawing.Font("Lucida Bright", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Output.Location = new System.Drawing.Point(12, 564);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(116, 34);
            this.lbl_Output.TabIndex = 3;
            this.lbl_Output.Text = "Output";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.White;
            this.lbl_Gender.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Gender.Location = new System.Drawing.Point(35, 323);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(111, 32);
            this.lbl_Gender.TabIndex = 4;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.BackColor = System.Drawing.Color.White;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee_Details.Location = new System.Drawing.Point(255, 21);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(461, 62);
            this.lbl_Employee_Details.TabIndex = 5;
            this.lbl_Employee_Details.Text = "Employee Details";
            // 
            // tb_Emp_Name
            // 
            this.tb_Emp_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Name.Location = new System.Drawing.Point(469, 127);
            this.tb_Emp_Name.MaxLength = 50;
            this.tb_Emp_Name.Name = "tb_Emp_Name";
            this.tb_Emp_Name.Size = new System.Drawing.Size(316, 36);
            this.tb_Emp_Name.TabIndex = 1;
            this.tb_Emp_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // cmb_Emp_Dept
            // 
            this.cmb_Emp_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Emp_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Emp_Dept.FormattingEnabled = true;
            this.cmb_Emp_Dept.Items.AddRange(new object[] {
            "Team Leader",
            "Mangaer",
            "HR"});
            this.cmb_Emp_Dept.Location = new System.Drawing.Point(469, 218);
            this.cmb_Emp_Dept.Name = "cmb_Emp_Dept";
            this.cmb_Emp_Dept.Size = new System.Drawing.Size(316, 37);
            this.cmb_Emp_Dept.TabIndex = 2;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rb_Male.Location = new System.Drawing.Point(20, 33);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(77, 28);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.BackColor = System.Drawing.Color.Azure;
            this.rb_Female.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rb_Female.Location = new System.Drawing.Point(162, 33);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(103, 28);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = false;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Morning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rb_Morning.Location = new System.Drawing.Point(9, 19);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(113, 27);
            this.rb_Morning.TabIndex = 7;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Night.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rb_Night.Location = new System.Drawing.Point(109, 78);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(84, 27);
            this.rb_Night.TabIndex = 9;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Evening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rb_Evening.Location = new System.Drawing.Point(191, 19);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(119, 27);
            this.rb_Evening.TabIndex = 8;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evevning";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(150, 565);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(923, 36);
            this.tb_Output.TabIndex = 10;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Location = new System.Drawing.Point(478, 288);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(275, 87);
            this.gb_Gender.TabIndex = 3;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Morning);
            this.groupBox1.Controls.Add(this.rb_Night);
            this.groupBox1.Controls.Add(this.rb_Evening);
            this.groupBox1.Location = new System.Drawing.Point(469, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.White;
            this.btn_Submit.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Red;
            this.btn_Submit.Location = new System.Drawing.Point(878, 475);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(144, 43);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Refresh.Location = new System.Drawing.Point(871, 85);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(151, 35);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Windows_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1085, 612);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.cmb_Emp_Dept);
            this.Controls.Add(this.tb_Emp_Name);
            this.Controls.Add(this.lbl_Employee_Details);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Dept);
            this.Controls.Add(this.lbl_Name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Windows_Controls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Controls";
            this.Load += new System.EventHandler(this.frm_Windows_Controls_Load);
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Dept;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.TextBox tb_Emp_Name;
        private System.Windows.Forms.ComboBox cmb_Emp_Dept;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Refresh;
    }
}