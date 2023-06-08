
namespace Employee_Management_Sysytem
{
    partial class frm_Add_Employee
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Emploee_Id = new System.Windows.Forms.Label();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.lbl_Employee_Mobile_Number = new System.Windows.Forms.Label();
            this.lbl_Employee_DOB = new System.Windows.Forms.Label();
            this.lbl_Employee_Designation = new System.Windows.Forms.Label();
            this.tb_Employee_Id = new System.Windows.Forms.TextBox();
            this.tb_Employe_Name = new System.Windows.Forms.TextBox();
            this.tb_Employee_Mo_No = new System.Windows.Forms.TextBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.cmb_Employee_Designation = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Employee_List = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Header.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(184, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(523, 54);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Add Employee Information";
            // 
            // lbl_Emploee_Id
            // 
            this.lbl_Emploee_Id.AutoSize = true;
            this.lbl_Emploee_Id.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emploee_Id.ForeColor = System.Drawing.Color.Red;
            this.lbl_Emploee_Id.Location = new System.Drawing.Point(128, 139);
            this.lbl_Emploee_Id.Name = "lbl_Emploee_Id";
            this.lbl_Emploee_Id.Size = new System.Drawing.Size(47, 32);
            this.lbl_Emploee_Id.TabIndex = 1;
            this.lbl_Emploee_Id.Text = "ID";
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee_Name.Location = new System.Drawing.Point(128, 202);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(95, 32);
            this.lbl_Employee_Name.TabIndex = 2;
            this.lbl_Employee_Name.Text = "Name";
            // 
            // lbl_Employee_Mobile_Number
            // 
            this.lbl_Employee_Mobile_Number.AutoSize = true;
            this.lbl_Employee_Mobile_Number.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Mobile_Number.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee_Mobile_Number.Location = new System.Drawing.Point(128, 269);
            this.lbl_Employee_Mobile_Number.Name = "lbl_Employee_Mobile_Number";
            this.lbl_Employee_Mobile_Number.Size = new System.Drawing.Size(160, 32);
            this.lbl_Employee_Mobile_Number.TabIndex = 3;
            this.lbl_Employee_Mobile_Number.Text = "Mobile No";
            // 
            // lbl_Employee_DOB
            // 
            this.lbl_Employee_DOB.AutoSize = true;
            this.lbl_Employee_DOB.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_DOB.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee_DOB.Location = new System.Drawing.Point(128, 338);
            this.lbl_Employee_DOB.Name = "lbl_Employee_DOB";
            this.lbl_Employee_DOB.Size = new System.Drawing.Size(95, 32);
            this.lbl_Employee_DOB.TabIndex = 4;
            this.lbl_Employee_DOB.Text = "D.O.B";
            // 
            // lbl_Employee_Designation
            // 
            this.lbl_Employee_Designation.AutoSize = true;
            this.lbl_Employee_Designation.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Designation.ForeColor = System.Drawing.Color.Red;
            this.lbl_Employee_Designation.Location = new System.Drawing.Point(128, 408);
            this.lbl_Employee_Designation.Name = "lbl_Employee_Designation";
            this.lbl_Employee_Designation.Size = new System.Drawing.Size(189, 32);
            this.lbl_Employee_Designation.TabIndex = 5;
            this.lbl_Employee_Designation.Text = "Designation";
            // 
            // tb_Employee_Id
            // 
            this.tb_Employee_Id.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Id.Location = new System.Drawing.Point(514, 137);
            this.tb_Employee_Id.Name = "tb_Employee_Id";
            this.tb_Employee_Id.Size = new System.Drawing.Size(218, 34);
            this.tb_Employee_Id.TabIndex = 1;
            this.tb_Employee_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Employe_Name
            // 
            this.tb_Employe_Name.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employe_Name.Location = new System.Drawing.Point(514, 201);
            this.tb_Employe_Name.MaxLength = 80;
            this.tb_Employe_Name.Name = "tb_Employe_Name";
            this.tb_Employe_Name.Size = new System.Drawing.Size(218, 34);
            this.tb_Employe_Name.TabIndex = 2;
            this.tb_Employe_Name.TextChanged += new System.EventHandler(this.tb_Employe_Name_TextChanged);
            this.tb_Employe_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Employee_Mo_No
            // 
            this.tb_Employee_Mo_No.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_Mo_No.Location = new System.Drawing.Point(514, 269);
            this.tb_Employee_Mo_No.Name = "tb_Employee_Mo_No";
            this.tb_Employee_Mo_No.Size = new System.Drawing.Size(218, 34);
            this.tb_Employee_Mo_No.TabIndex = 3;
            this.tb_Employee_Mo_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(514, 326);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(218, 34);
            this.dtp_Date_Of_Birth.TabIndex = 4;
            // 
            // cmb_Employee_Designation
            // 
            this.cmb_Employee_Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee_Designation.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Designation.FormattingEnabled = true;
            this.cmb_Employee_Designation.Items.AddRange(new object[] {
            "Manager",
            "Developer",
            "Designer",
            "Tester",
            "Cashier",
            "Staff"});
            this.cmb_Employee_Designation.Location = new System.Drawing.Point(514, 402);
            this.cmb_Employee_Designation.MaxLength = 40;
            this.cmb_Employee_Designation.Name = "cmb_Employee_Designation";
            this.cmb_Employee_Designation.Size = new System.Drawing.Size(218, 36);
            this.cmb_Employee_Designation.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Aqua;
            this.btn_Save.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(350, 486);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(126, 39);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Aqua;
            this.btn_Refresh.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Red;
            this.btn_Refresh.Location = new System.Drawing.Point(134, 486);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(134, 36);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Employee_List
            // 
            this.btn_Employee_List.BackColor = System.Drawing.Color.Aqua;
            this.btn_Employee_List.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_List.ForeColor = System.Drawing.Color.Red;
            this.btn_Employee_List.Location = new System.Drawing.Point(580, 483);
            this.btn_Employee_List.Name = "btn_Employee_List";
            this.btn_Employee_List.Size = new System.Drawing.Size(219, 39);
            this.btn_Employee_List.TabIndex = 8;
            this.btn_Employee_List.Text = "Employee List";
            this.btn_Employee_List.UseVisualStyleBackColor = false;
            this.btn_Employee_List.Click += new System.EventHandler(this.btn_Employee_List_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Red;
            this.btn_Log_Out.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Lime;
            this.btn_Log_Out.Location = new System.Drawing.Point(775, 12);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(107, 41);
            this.btn_Log_Out.TabIndex = 9;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // frm_Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Employee_List);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Employee_Designation);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.tb_Employee_Mo_No);
            this.Controls.Add(this.tb_Employe_Name);
            this.Controls.Add(this.tb_Employee_Id);
            this.Controls.Add(this.lbl_Employee_Designation);
            this.Controls.Add(this.lbl_Employee_DOB);
            this.Controls.Add(this.lbl_Employee_Mobile_Number);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.lbl_Emploee_Id);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Add_Employee";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Emploee_Id;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.Label lbl_Employee_Mobile_Number;
        private System.Windows.Forms.Label lbl_Employee_DOB;
        private System.Windows.Forms.Label lbl_Employee_Designation;
        private System.Windows.Forms.TextBox tb_Employee_Id;
        private System.Windows.Forms.TextBox tb_Employe_Name;
        private System.Windows.Forms.TextBox tb_Employee_Mo_No;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.ComboBox cmb_Employee_Designation;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Employee_List;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}