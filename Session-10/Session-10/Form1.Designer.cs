namespace Session_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.grvCourses = new System.Windows.Forms.DataGridView();
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.grvSchedules = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStudents
            // 
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Location = new System.Drawing.Point(12, 22);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.Size = new System.Drawing.Size(496, 163);
            this.grvStudents.TabIndex = 0;
            // 
            // grvCourses
            // 
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourses.Location = new System.Drawing.Point(558, 22);
            this.grvCourses.Name = "grvCourses";
            this.grvCourses.RowTemplate.Height = 25;
            this.grvCourses.Size = new System.Drawing.Size(517, 163);
            this.grvCourses.TabIndex = 1;
            // 
            // grvGrades
            // 
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Location = new System.Drawing.Point(12, 224);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.Size = new System.Drawing.Size(496, 163);
            this.grvGrades.TabIndex = 2;
            // 
            // grvSchedules
            // 
            this.grvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSchedules.Location = new System.Drawing.Point(558, 224);
            this.grvSchedules.Name = "grvSchedules";
            this.grvSchedules.Size = new System.Drawing.Size(517, 163);
            this.grvSchedules.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 504);
            this.Controls.Add(this.grvSchedules);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.grvCourses);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView grvStudents;
        private DataGridView grvCourses;
        private DataGridView grvGrades;
        private DataGridView grvSchedules;
    }
}