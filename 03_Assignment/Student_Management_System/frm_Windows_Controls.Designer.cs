
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
            this.lbl_Emp_Dept = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.lbl_Emp_Name = new System.Windows.Forms.Label();
            this.tb_Employee_Name = new System.Windows.Forms.TextBox();
            this.cmb_Emp_Dept = new System.Windows.Forms.ComboBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.gb_Employee_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Shift_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Shift_Morning = new System.Windows.Forms.RadioButton();
            this.rb_Shift_Time_Night = new System.Windows.Forms.RadioButton();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.gb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.gb_Employee_Gender.SuspendLayout();
            this.gb_Shift_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Emp_Dept
            // 
            this.lbl_Emp_Dept.AutoSize = true;
            this.lbl_Emp_Dept.BackColor = System.Drawing.Color.White;
            this.lbl_Emp_Dept.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Dept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Emp_Dept.Location = new System.Drawing.Point(57, 203);
            this.lbl_Emp_Dept.Name = "lbl_Emp_Dept";
            this.lbl_Emp_Dept.Size = new System.Drawing.Size(259, 32);
            this.lbl_Emp_Dept.TabIndex = 0;
            this.lbl_Emp_Dept.Text = "Employee Department";
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.BackColor = System.Drawing.Color.White;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Shift_Time.Location = new System.Drawing.Point(57, 381);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(131, 32);
            this.lbl_Shift_Time.TabIndex = 1;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.White;
            this.lbl_Gender.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Gender.Location = new System.Drawing.Point(57, 287);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(97, 32);
            this.lbl_Gender.TabIndex = 2;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.BackColor = System.Drawing.Color.White;
            this.lbl_Output.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.ForeColor = System.Drawing.Color.Red;
            this.lbl_Output.Location = new System.Drawing.Point(61, 510);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(93, 29);
            this.lbl_Output.TabIndex = 3;
            this.lbl_Output.Text = "Output";
            // 
            // lbl_Emp_Name
            // 
            this.lbl_Emp_Name.AutoSize = true;
            this.lbl_Emp_Name.BackColor = System.Drawing.Color.White;
            this.lbl_Emp_Name.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Emp_Name.Location = new System.Drawing.Point(57, 128);
            this.lbl_Emp_Name.Name = "lbl_Emp_Name";
            this.lbl_Emp_Name.Size = new System.Drawing.Size(193, 32);
            this.lbl_Emp_Name.TabIndex = 4;
            this.lbl_Emp_Name.Text = "Employee Name";
            // 
            // tb_Employee_Name
            // 
            this.tb_Employee_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Name.Location = new System.Drawing.Point(516, 124);
            this.tb_Employee_Name.MaxLength = 50;
            this.tb_Employee_Name.Name = "tb_Employee_Name";
            this.tb_Employee_Name.Size = new System.Drawing.Size(374, 36);
            this.tb_Employee_Name.TabIndex = 1;
            // 
            // cmb_Emp_Dept
            // 
            this.cmb_Emp_Dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Emp_Dept.FormattingEnabled = true;
            this.cmb_Emp_Dept.Items.AddRange(new object[] {
            "Developer",
            "Manager",
            "HR"});
            this.cmb_Emp_Dept.Location = new System.Drawing.Point(516, 198);
            this.cmb_Emp_Dept.Name = "cmb_Emp_Dept";
            this.cmb_Emp_Dept.Size = new System.Drawing.Size(374, 37);
            this.cmb_Emp_Dept.TabIndex = 2;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.BackColor = System.Drawing.Color.White;
            this.rb_Male.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rb_Male.Location = new System.Drawing.Point(25, 26);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(73, 26);
            this.rb_Male.TabIndex = 3;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = false;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.BackColor = System.Drawing.Color.White;
            this.rb_Female.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.ForeColor = System.Drawing.Color.Blue;
            this.rb_Female.Location = new System.Drawing.Point(187, 26);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(96, 26);
            this.rb_Female.TabIndex = 4;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = false;
            // 
            // gb_Employee_Gender
            // 
            this.gb_Employee_Gender.Controls.Add(this.rb_Female);
            this.gb_Employee_Gender.Controls.Add(this.rb_Male);
            this.gb_Employee_Gender.Location = new System.Drawing.Point(516, 267);
            this.gb_Employee_Gender.Name = "gb_Employee_Gender";
            this.gb_Employee_Gender.Size = new System.Drawing.Size(374, 68);
            this.gb_Employee_Gender.TabIndex = 5;
            this.gb_Employee_Gender.TabStop = false;
            this.gb_Employee_Gender.Text = "Gender";
            // 
            // rb_Shift_Evening
            // 
            this.rb_Shift_Evening.AutoSize = true;
            this.rb_Shift_Evening.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Shift_Evening.Location = new System.Drawing.Point(147, 19);
            this.rb_Shift_Evening.Name = "rb_Shift_Evening";
            this.rb_Shift_Evening.Size = new System.Drawing.Size(102, 26);
            this.rb_Shift_Evening.TabIndex = 6;
            this.rb_Shift_Evening.TabStop = true;
            this.rb_Shift_Evening.Text = "Evening";
            this.rb_Shift_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Shift_Morning
            // 
            this.rb_Shift_Morning.AutoSize = true;
            this.rb_Shift_Morning.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Shift_Morning.Location = new System.Drawing.Point(17, 19);
            this.rb_Shift_Morning.Name = "rb_Shift_Morning";
            this.rb_Shift_Morning.Size = new System.Drawing.Size(107, 26);
            this.rb_Shift_Morning.TabIndex = 5;
            this.rb_Shift_Morning.TabStop = true;
            this.rb_Shift_Morning.Text = "Morning";
            this.rb_Shift_Morning.UseVisualStyleBackColor = true;
            // 
            // rb_Shift_Time_Night
            // 
            this.rb_Shift_Time_Night.AutoSize = true;
            this.rb_Shift_Time_Night.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Shift_Time_Night.Location = new System.Drawing.Point(283, 19);
            this.rb_Shift_Time_Night.Name = "rb_Shift_Time_Night";
            this.rb_Shift_Time_Night.Size = new System.Drawing.Size(80, 26);
            this.rb_Shift_Time_Night.TabIndex = 7;
            this.rb_Shift_Time_Night.TabStop = true;
            this.rb_Shift_Time_Night.Text = "Night";
            this.rb_Shift_Time_Night.UseVisualStyleBackColor = true;
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(304, 504);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(628, 38);
            this.tb_Output.TabIndex = 8;
            // 
            // gb_Shift_Time
            // 
            this.gb_Shift_Time.Controls.Add(this.rb_Shift_Morning);
            this.gb_Shift_Time.Controls.Add(this.rb_Shift_Evening);
            this.gb_Shift_Time.Controls.Add(this.rb_Shift_Time_Night);
            this.gb_Shift_Time.Location = new System.Drawing.Point(516, 368);
            this.gb_Shift_Time.Name = "gb_Shift_Time";
            this.gb_Shift_Time.Size = new System.Drawing.Size(374, 69);
            this.gb_Shift_Time.TabIndex = 9;
            this.gb_Shift_Time.TabStop = false;
            this.gb_Shift_Time.Text = "Shift";
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.BackColor = System.Drawing.Color.White;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Employee_Details.Location = new System.Drawing.Point(297, 24);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(336, 42);
            this.lbl_Employee_Details.TabIndex = 10;
            this.lbl_Employee_Details.Text = "Employee_Details";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.White;
            this.btn_Submit.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Submit.Location = new System.Drawing.Point(441, 443);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(128, 39);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // frm_Windows_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(966, 554);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Employee_Details);
            this.Controls.Add(this.gb_Shift_Time);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.gb_Employee_Gender);
            this.Controls.Add(this.cmb_Emp_Dept);
            this.Controls.Add(this.tb_Employee_Name);
            this.Controls.Add(this.lbl_Emp_Name);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Emp_Dept);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Windows_Controls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows_Controls";
            this.Load += new System.EventHandler(this.frm_Windows_Controls_Load);
            this.gb_Employee_Gender.ResumeLayout(false);
            this.gb_Employee_Gender.PerformLayout();
            this.gb_Shift_Time.ResumeLayout(false);
            this.gb_Shift_Time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Emp_Dept;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Label lbl_Emp_Name;
        private System.Windows.Forms.TextBox tb_Employee_Name;
        private System.Windows.Forms.ComboBox cmb_Emp_Dept;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.GroupBox gb_Employee_Gender;
        private System.Windows.Forms.RadioButton rb_Shift_Evening;
        private System.Windows.Forms.RadioButton rb_Shift_Morning;
        private System.Windows.Forms.RadioButton rb_Shift_Time_Night;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.GroupBox gb_Shift_Time;
        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.Button btn_Submit;
    }
}