namespace FuelStation.Win
{
    partial class CustomerForm
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
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.grvCustomer = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // grvCustomer
            // 
            this.grvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmID,
            this.clmSurname,
            this.clmCardNumber});
            this.grvCustomer.Location = new System.Drawing.Point(22, 12);
            this.grvCustomer.Name = "grvCustomer";
            this.grvCustomer.RowTemplate.Height = 25;
            this.grvCustomer.Size = new System.Drawing.Size(483, 180);
            this.grvCustomer.TabIndex = 0;
            this.grvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCustomer_CellClick);
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            // 
            // clmSurname
            // 
            this.clmSurname.DataPropertyName = "Surname";
            this.clmSurname.HeaderText = "Surname";
            this.clmSurname.Name = "clmSurname";
            // 
            // clmCardNumber
            // 
            this.clmCardNumber.DataPropertyName = "CardNumber";
            this.clmCardNumber.HeaderText = "Card Number";
            this.clmCardNumber.Name = "clmCardNumber";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(528, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 45);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(528, 74);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 45);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(528, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 45);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(36, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 31);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 45);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Create New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(199, 230);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 15);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(199, 204);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(199, 254);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grvCustomer);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvCustomer;
        private BindingSource bsCustomer;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmSurname;
        private DataGridViewTextBoxColumn clmCardNumber;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnRefresh;
        private Button btnBack;
        private Button btnAdd;
        private Label lblTotal;
        private Label lblName;
        private Label lblDate;
    }
}