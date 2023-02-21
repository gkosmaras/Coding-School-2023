namespace FuelStation.Win
{
    partial class LoginForm
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnMangerLg = new System.Windows.Forms.Button();
            this.btnCashierLg = new System.Windows.Forms.Button();
            this.btnStaffLg = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(88, 169);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(192, 69);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "To Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(286, 169);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(192, 69);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "To Items";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(484, 169);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(192, 69);
            this.btnTransactions.TabIndex = 2;
            this.btnTransactions.Text = "To Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            // 
            // btnMangerLg
            // 
            this.btnMangerLg.Location = new System.Drawing.Point(88, 62);
            this.btnMangerLg.Name = "btnMangerLg";
            this.btnMangerLg.Size = new System.Drawing.Size(192, 69);
            this.btnMangerLg.TabIndex = 3;
            this.btnMangerLg.Text = "Manager";
            this.btnMangerLg.UseVisualStyleBackColor = true;
            this.btnMangerLg.Click += new System.EventHandler(this.btnManagerLg_Click);
            // 
            // btnCashierLg
            // 
            this.btnCashierLg.Location = new System.Drawing.Point(286, 62);
            this.btnCashierLg.Name = "btnCashierLg";
            this.btnCashierLg.Size = new System.Drawing.Size(192, 69);
            this.btnCashierLg.TabIndex = 4;
            this.btnCashierLg.Text = "Cashier";
            this.btnCashierLg.UseVisualStyleBackColor = true;
            this.btnCashierLg.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnStaffLg
            // 
            this.btnStaffLg.Location = new System.Drawing.Point(484, 62);
            this.btnStaffLg.Name = "btnStaffLg";
            this.btnStaffLg.Size = new System.Drawing.Size(192, 69);
            this.btnStaffLg.TabIndex = 5;
            this.btnStaffLg.Text = "Staff";
            this.btnStaffLg.UseVisualStyleBackColor = true;
            this.btnStaffLg.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(663, 388);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Exit";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.LoginFrom_Load);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStaffLg);
            this.Controls.Add(this.btnCashierLg);
            this.Controls.Add(this.btnMangerLg);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnCustomers);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginFrom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCustomers;
        private Button btnItems;
        private Button button3;
        private Button btnMangerLg;
        private Button btnCashierLg;
        private Button btnStaffLg;
        private Button btnLogout;
        private Button btnTransactions;
    }
}