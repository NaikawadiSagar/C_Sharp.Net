
namespace Student_Management_System
{
    partial class frm_Add_Course
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
            this.lbl_Add_Course = new System.Windows.Forms.Label();
            this.lbl_Course_Id = new System.Windows.Forms.Label();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.tb_Course_Id = new System.Windows.Forms.TextBox();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_Course_List = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_Course
            // 
            this.lbl_Add_Course.AutoSize = true;
            this.lbl_Add_Course.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Add_Course.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Course.ForeColor = System.Drawing.Color.Red;
            this.lbl_Add_Course.Location = new System.Drawing.Point(259, 30);
            this.lbl_Add_Course.Name = "lbl_Add_Course";
            this.lbl_Add_Course.Size = new System.Drawing.Size(289, 65);
            this.lbl_Add_Course.TabIndex = 0;
            this.lbl_Add_Course.Text = "Add Course";
            // 
            // lbl_Course_Id
            // 
            this.lbl_Course_Id.AutoSize = true;
            this.lbl_Course_Id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Course_Id.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Id.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_Course_Id.Location = new System.Drawing.Point(149, 184);
            this.lbl_Course_Id.Name = "lbl_Course_Id";
            this.lbl_Course_Id.Size = new System.Drawing.Size(121, 32);
            this.lbl_Course_Id.TabIndex = 1;
            this.lbl_Course_Id.Text = "Course Id";
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_Course_Name.Location = new System.Drawing.Point(149, 274);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(163, 32);
            this.lbl_Course_Name.TabIndex = 2;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // tb_Course_Id
            // 
            this.tb_Course_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Id.Location = new System.Drawing.Point(453, 184);
            this.tb_Course_Id.MaxLength = 15;
            this.tb_Course_Id.Name = "tb_Course_Id";
            this.tb_Course_Id.Size = new System.Drawing.Size(232, 35);
            this.tb_Course_Id.TabIndex = 1;
            this.tb_Course_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(453, 271);
            this.tb_Course_Name.MaxLength = 50;
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(232, 35);
            this.tb_Course_Name.TabIndex = 2;
            this.tb_Course_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Save.Location = new System.Drawing.Point(195, 372);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(117, 43);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_Course_List
            // 
            this.btn_View_Course_List.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btn_View_Course_List.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_View_Course_List.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Course_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_View_Course_List.Location = new System.Drawing.Point(571, 372);
            this.btn_View_Course_List.Name = "btn_View_Course_List";
            this.btn_View_Course_List.Size = new System.Drawing.Size(190, 43);
            this.btn_View_Course_List.TabIndex = 4;
            this.btn_View_Course_List.Text = "Course List";
            this.btn_View_Course_List.UseVisualStyleBackColor = false;
            this.btn_View_Course_List.Click += new System.EventHandler(this.btn_View_Course_List_Click);
            // 
            // frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_View_Course_List);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_Id);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_Id);
            this.Controls.Add(this.lbl_Add_Course);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Course;
        private System.Windows.Forms.Label lbl_Course_Id;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.TextBox tb_Course_Id;
        private System.Windows.Forms.TextBox tb_Course_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_Course_List;
    }
}