namespace FuelStation.Win
{
    partial class TransactionForm
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
            this.grvTransaction = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmPaymentMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransaction
            // 
            this.grvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmDate,
            this.clmEmployeeID,
            this.clmCustomerID,
            this.clmPaymentMethod,
            this.clmTotalValue});
            this.grvTransaction.Location = new System.Drawing.Point(32, 50);
            this.grvTransaction.Name = "grvTransaction";
            this.grvTransaction.RowTemplate.Height = 25;
            this.grvTransaction.Size = new System.Drawing.Size(691, 111);
            this.grvTransaction.TabIndex = 0;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            // 
            // clmDate
            // 
            this.clmDate.DataPropertyName = "Date";
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            // 
            // clmEmployeeID
            // 
            this.clmEmployeeID.DataPropertyName = "EmployeeID";
            this.clmEmployeeID.HeaderText = "Employee ID";
            this.clmEmployeeID.Name = "clmEmployeeID";
            this.clmEmployeeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clmCustomerID
            // 
            this.clmCustomerID.DataPropertyName = "CustomerID";
            this.clmCustomerID.HeaderText = "Customer ID";
            this.clmCustomerID.Name = "clmCustomerID";
            this.clmCustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmPaymentMethod
            // 
            this.clmPaymentMethod.DataPropertyName = "PaymentMethod";
            this.clmPaymentMethod.HeaderText = "Payment Method";
            this.clmPaymentMethod.Name = "clmPaymentMethod";
            this.clmPaymentMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmPaymentMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmTotalValue
            // 
            this.clmTotalValue.DataPropertyName = "TotalValue";
            this.clmTotalValue.HeaderText = "Total Value";
            this.clmTotalValue.Name = "clmTotalValue";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(482, 256);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(211, 23);
            this.txtCardNumber.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(534, 298);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(167, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.grvTransaction);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvTransaction;
        private BindingSource bsTransaction;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmDate;
        private DataGridViewTextBoxColumn clmEmployeeID;
        private DataGridViewComboBoxColumn clmCustomerID;
        private DataGridViewComboBoxColumn clmPaymentMethod;
        private DataGridViewTextBoxColumn clmTotalValue;
        private TextBox txtCardNumber;
        private Button btnNew;
    }
}