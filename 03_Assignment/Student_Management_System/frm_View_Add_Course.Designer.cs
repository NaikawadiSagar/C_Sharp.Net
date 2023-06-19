
namespace Student_Management_System
{
    partial class frm_View_Add_Course
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_View_Add_Course = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAddCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Mangement_System_DBDataSet1 = new Student_Management_System.Student_Mangement_System_DBDataSet1();
            this.tbl_Add_CourseTableAdapter = new Student_Management_System.Student_Mangement_System_DBDataSet1TableAdapters.tbl_Add_CourseTableAdapter();
            this.View_Add_Course = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Add_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Mangement_System_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View_Add_Course
            // 
            this.dgv_View_Add_Course.AutoGenerateColumns = false;
            this.dgv_View_Add_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Add_Course.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Add_Course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Add_Course.ColumnHeadersHeight = 35;
            this.dgv_View_Add_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dgv_View_Add_Course.DataSource = this.tblAddCourseBindingSource;
            this.dgv_View_Add_Course.Location = new System.Drawing.Point(68, 66);
            this.dgv_View_Add_Course.Name = "dgv_View_Add_Course";
            this.dgv_View_Add_Course.Size = new System.Drawing.Size(661, 382);
            this.dgv_View_Add_Course.TabIndex = 0;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            // 
            // tblAddCourseBindingSource
            // 
            this.tblAddCourseBindingSource.DataMember = "tbl_Add_Course";
            this.tblAddCourseBindingSource.DataSource = this.student_Mangement_System_DBDataSet1;
            // 
            // student_Mangement_System_DBDataSet1
            // 
            this.student_Mangement_System_DBDataSet1.DataSetName = "Student_Mangement_System_DBDataSet1";
            this.student_Mangement_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Add_CourseTableAdapter
            // 
            this.tbl_Add_CourseTableAdapter.ClearBeforeFill = true;
            // 
            // View_Add_Course
            // 
            this.View_Add_Course.AutoSize = true;
            this.View_Add_Course.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.View_Add_Course.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Add_Course.ForeColor = System.Drawing.Color.Magenta;
            this.View_Add_Course.Location = new System.Drawing.Point(251, 9);
            this.View_Add_Course.Name = "View_Add_Course";
            this.View_Add_Course.Size = new System.Drawing.Size(285, 50);
            this.View_Add_Course.TabIndex = 1;
            this.View_Add_Course.Text = "View Course";
            // 
            // frm_View_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.View_Add_Course);
            this.Controls.Add(this.dgv_View_Add_Course);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_View_Add_Course";
            this.Load += new System.EventHandler(this.frm_View_Add_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Add_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Mangement_System_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_Add_Course;
        private Student_Mangement_System_DBDataSet1 student_Mangement_System_DBDataSet1;
        private System.Windows.Forms.BindingSource tblAddCourseBindingSource;
        private Student_Mangement_System_DBDataSet1TableAdapters.tbl_Add_CourseTableAdapter tbl_Add_CourseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label View_Add_Course;
    }
}