
namespace Employee_Management_Sysytem
{
    partial class frm_View_Employee_List
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
            this.dgv_View_Employee_List = new System.Windows.Forms.DataGridView();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_System_DBDataSet = new Employee_Management_Sysytem.Employee_Management_System_DBDataSet();
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.tbl_Employee_DetailsTableAdapter = new Employee_Management_Sysytem.Employee_Management_System_DBDataSetTableAdapters.tbl_Employee_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View_Employee_List
            // 
            this.dgv_View_Employee_List.AllowUserToDeleteRows = false;
            this.dgv_View_Employee_List.AutoGenerateColumns = false;
            this.dgv_View_Employee_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Employee_List.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_View_Employee_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Employee_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Employee_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Employee_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgv_View_Employee_List.DataSource = this.tblEmployeeDetailsBindingSource;
            this.dgv_View_Employee_List.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_View_Employee_List.Location = new System.Drawing.Point(31, 55);
            this.dgv_View_Employee_List.Name = "dgv_View_Employee_List";
            this.dgv_View_Employee_List.Size = new System.Drawing.Size(829, 451);
            this.dgv_View_Employee_List.TabIndex = 0;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // tblEmployeeDetailsBindingSource
            // 
            this.tblEmployeeDetailsBindingSource.DataMember = "tbl_Employee_Details";
            this.tblEmployeeDetailsBindingSource.DataSource = this.employee_Management_System_DBDataSet;
            // 
            // employee_Management_System_DBDataSet
            // 
            this.employee_Management_System_DBDataSet.DataSetName = "Employee_Management_System_DBDataSet";
            this.employee_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.BackColor = System.Drawing.Color.Cyan;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Sitka Small", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Employee_Details.Location = new System.Drawing.Point(222, -2);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(367, 54);
            this.lbl_Employee_Details.TabIndex = 1;
            this.lbl_Employee_Details.Text = "Employee Details";
            // 
            // tbl_Employee_DetailsTableAdapter
            // 
            this.tbl_Employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(887, 534);
            this.Controls.Add(this.lbl_Employee_Details);
            this.Controls.Add(this.dgv_View_Employee_List);
            this.Name = "frm_View_Employee_List";
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frm_View_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_Employee_List;
        private System.Windows.Forms.Label lbl_Employee_Details;
        private Employee_Management_System_DBDataSet employee_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeDetailsBindingSource;
        private Employee_Management_System_DBDataSetTableAdapters.tbl_Employee_DetailsTableAdapter tbl_Employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
    }
}