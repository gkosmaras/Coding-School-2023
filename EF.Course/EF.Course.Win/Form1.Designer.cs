namespace EF.Course.Win
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
            this.button_AddTodo = new System.Windows.Forms.Button();
            this.textbox_todoTitle = new System.Windows.Forms.TextBox();
            this.TodoGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TodoGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddTodo
            // 
            this.button_AddTodo.Location = new System.Drawing.Point(154, 43);
            this.button_AddTodo.Name = "button_AddTodo";
            this.button_AddTodo.Size = new System.Drawing.Size(75, 23);
            this.button_AddTodo.TabIndex = 0;
            this.button_AddTodo.Text = "Add Todo";
            this.button_AddTodo.UseVisualStyleBackColor = true;
            this.button_AddTodo.Click += new System.EventHandler(this.button_AddTodo_Click);
            // 
            // textbox_todoTitle
            // 
            this.textbox_todoTitle.Location = new System.Drawing.Point(12, 43);
            this.textbox_todoTitle.Name = "textbox_todoTitle";
            this.textbox_todoTitle.Size = new System.Drawing.Size(136, 23);
            this.textbox_todoTitle.TabIndex = 1;
            // 
            // TodoGV
            // 
            this.TodoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodoGV.Location = new System.Drawing.Point(12, 82);
            this.TodoGV.Name = "TodoGV";
            this.TodoGV.RowTemplate.Height = 25;
            this.TodoGV.Size = new System.Drawing.Size(240, 150);
            this.TodoGV.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 544);
            this.Controls.Add(this.TodoGV);
            this.Controls.Add(this.textbox_todoTitle);
            this.Controls.Add(this.button_AddTodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TodoGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_AddTodo;
        private TextBox textbox_todoTitle;
        private DataGridView TodoGV;
    }
}