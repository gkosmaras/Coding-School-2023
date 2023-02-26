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
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkEditMode = new System.Windows.Forms.CheckBox();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmployeeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmCustomerID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmPaymentMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransaction
            // 
            this.grvTransaction.BackgroundColor = System.Drawing.Color.LightYellow;
            this.grvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmDate,
            this.clmEmployeeID,
            this.clmCustomerID,
            this.clmPaymentMethod,
            this.clmTotalValue});
            this.grvTransaction.GridColor = System.Drawing.Color.Black;
            this.grvTransaction.Location = new System.Drawing.Point(12, 24);
            this.grvTransaction.Name = "grvTransaction";
            this.grvTransaction.RowTemplate.Height = 25;
            this.grvTransaction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grvTransaction.Size = new System.Drawing.Size(543, 414);
            this.grvTransaction.TabIndex = 0;
            this.grvTransaction.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTransaction_CellContentDoubleClick);
            this.grvTransaction.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grvTransaction_DataError);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(576, 124);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(143, 23);
            this.txtCardNumber.TabIndex = 1;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(576, 75);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(143, 23);
            this.cmbEmployee.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(576, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 50);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Create New";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(576, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 50);
            this.button2.TabIndex = 41;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkEditMode
            // 
            this.chkEditMode.AutoSize = true;
            this.chkEditMode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEditMode.Location = new System.Drawing.Point(576, 24);
            this.chkEditMode.Name = "chkEditMode";
            this.chkEditMode.Size = new System.Drawing.Size(99, 24);
            this.chkEditMode.TabIndex = 43;
            this.chkEditMode.Text = "Edit Mode";
            this.chkEditMode.UseVisualStyleBackColor = true;
            this.chkEditMode.CheckedChanged += new System.EventHandler(this.chkEditMode_CheckChanged);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.Visible = false;
            this.clmID.Width = 5;
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
            this.clmEmployeeID.HeaderText = "Employee";
            this.clmEmployeeID.Name = "clmEmployeeID";
            this.clmEmployeeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEmployeeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmCustomerID
            // 
            this.clmCustomerID.DataPropertyName = "CustomerID";
            this.clmCustomerID.HeaderText = "Customer";
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
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.chkEditMode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.grvTransaction);
            this.Name = "TransactionForm";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionForm_load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvTransaction;
        private BindingSource bsTransaction;
        private TextBox txtCardNumber;
        private ComboBox cmbEmployee;
        private Button btnSave;
        private Button button2;
        private CheckBox chkEditMode;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmDate;
        private DataGridViewComboBoxColumn clmEmployeeID;
        private DataGridViewComboBoxColumn clmCustomerID;
        private DataGridViewComboBoxColumn clmPaymentMethod;
        private DataGridViewTextBoxColumn clmTotalValue;
    }
}