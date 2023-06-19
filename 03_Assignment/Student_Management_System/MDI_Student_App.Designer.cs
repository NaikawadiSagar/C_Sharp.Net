
namespace Student_Management_System
{
    partial class MDI_Student_App
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.addStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(854, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentDetailsToolStripMenuItem,
            this.viewStudentDetailsToolStripMenuItem,
            this.searchStudentDetailsToolStripMenuItem,
            this.updateStudentDetailsToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 639);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(854, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // addStudentDetailsToolStripMenuItem
            // 
            this.addStudentDetailsToolStripMenuItem.Name = "addStudentDetailsToolStripMenuItem";
            this.addStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.addStudentDetailsToolStripMenuItem.Text = "Add_Student_Details";
            this.addStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.addStudentDetailsToolStripMenuItem_Click);
            // 
            // viewStudentDetailsToolStripMenuItem
            // 
            this.viewStudentDetailsToolStripMenuItem.Name = "viewStudentDetailsToolStripMenuItem";
            this.viewStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.viewStudentDetailsToolStripMenuItem.Text = "View_Student_Details";
            this.viewStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentDetailsToolStripMenuItem_Click);
            // 
            // searchStudentDetailsToolStripMenuItem
            // 
            this.searchStudentDetailsToolStripMenuItem.Name = "searchStudentDetailsToolStripMenuItem";
            this.searchStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.searchStudentDetailsToolStripMenuItem.Text = "Search_Student_Details";
            this.searchStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchStudentDetailsToolStripMenuItem_Click);
            // 
            // updateStudentDetailsToolStripMenuItem
            // 
            this.updateStudentDetailsToolStripMenuItem.Name = "updateStudentDetailsToolStripMenuItem";
            this.updateStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.updateStudentDetailsToolStripMenuItem.Text = "Update_Student_Details";
            this.updateStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateStudentDetailsToolStripMenuItem_Click);
            // 
            // MDI_Student_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 661);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDI_Student_App";
            this.Text = "MDI_Student_App";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentDetailsToolStripMenuItem;
    }
}



