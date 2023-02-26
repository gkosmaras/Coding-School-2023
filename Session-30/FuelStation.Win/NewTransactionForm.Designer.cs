namespace FuelStation.Win
{
    partial class NewTransactionForm
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
            this.grvTransLine = new System.Windows.Forms.DataGridView();
            this.bsNewTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCard = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkEditMode = new System.Windows.Forms.CheckBox();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNewTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransLine
            // 
            this.grvTransLine.BackgroundColor = System.Drawing.Color.LightYellow;
            this.grvTransLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmTransID,
            this.clmItemID,
            this.clmQuantity,
            this.clmPrice,
            this.clmValue,
            this.clmPercent,
            this.clmDiscount,
            this.clmTotal});
            this.grvTransLine.GridColor = System.Drawing.Color.Black;
            this.grvTransLine.Location = new System.Drawing.Point(26, 26);
            this.grvTransLine.Name = "grvTransLine";
            this.grvTransLine.RowTemplate.Height = 25;
            this.grvTransLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grvTransLine.Size = new System.Drawing.Size(582, 331);
            this.grvTransLine.TabIndex = 18;
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(719, 61);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(126, 23);
            this.cmbItem.TabIndex = 22;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(719, 110);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(126, 23);
            this.nudQuantity.TabIndex = 20;
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Checked = true;
            this.radCash.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radCash.Location = new System.Drawing.Point(629, 160);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(60, 24);
            this.radCash.TabIndex = 25;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCard
            // 
            this.radCard.AutoSize = true;
            this.radCard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radCard.Location = new System.Drawing.Point(629, 203);
            this.radCard.Name = "radCard";
            this.radCard.Size = new System.Drawing.Size(105, 24);
            this.radCard.TabIndex = 26;
            this.radCard.Text = "Credit Card";
            this.radCard.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(628, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(628, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Quantity:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(26, 373);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 50);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDone.Location = new System.Drawing.Point(435, 373);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(173, 50);
            this.btnDone.TabIndex = 43;
            this.btnDone.Text = "Finish";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(227, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 50);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkEditMode
            // 
            this.chkEditMode.AutoSize = true;
            this.chkEditMode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEditMode.Location = new System.Drawing.Point(629, 25);
            this.chkEditMode.Name = "chkEditMode";
            this.chkEditMode.Size = new System.Drawing.Size(99, 24);
            this.chkEditMode.TabIndex = 45;
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
            // clmTransID
            // 
            this.clmTransID.DataPropertyName = "TransactionID";
            this.clmTransID.HeaderText = "TransactionID";
            this.clmTransID.Name = "clmTransID";
            this.clmTransID.Visible = false;
            this.clmTransID.Width = 5;
            // 
            // clmItemID
            // 
            this.clmItemID.DataPropertyName = "ItemID";
            this.clmItemID.HeaderText = "Item";
            this.clmItemID.Name = "clmItemID";
            this.clmItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmQuantity
            // 
            this.clmQuantity.DataPropertyName = "Quantity";
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Width = 60;
            // 
            // clmPrice
            // 
            this.clmPrice.DataPropertyName = "ItemPrice";
            this.clmPrice.HeaderText = "Item Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Width = 70;
            // 
            // clmValue
            // 
            this.clmValue.DataPropertyName = "NetValue";
            this.clmValue.HeaderText = "Net Value";
            this.clmValue.Name = "clmValue";
            // 
            // clmPercent
            // 
            this.clmPercent.DataPropertyName = "DiscountPercent";
            this.clmPercent.HeaderText = "Discount %";
            this.clmPercent.Name = "clmPercent";
            this.clmPercent.Width = 65;
            // 
            // clmDiscount
            // 
            this.clmDiscount.DataPropertyName = "DiscountValue";
            this.clmDiscount.HeaderText = "Discount Value";
            this.clmDiscount.Name = "clmDiscount";
            this.clmDiscount.Width = 65;
            // 
            // clmTotal
            // 
            this.clmTotal.DataPropertyName = "TotalValue";
            this.clmTotal.HeaderText = "Total Value";
            this.clmTotal.Name = "clmTotal";
            // 
            // NewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.chkEditMode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radCard);
            this.Controls.Add(this.radCash);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.grvTransLine);
            this.Name = "NewTransactionForm";
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.NewTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNewTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvTransLine;
        private BindingSource bsNewTransaction;
        private ComboBox cmbItem;
        private NumericUpDown nudQuantity;
        private RadioButton radCash;
        private RadioButton radCard;
        private Label label5;
        private Label label3;
        private Button btnAdd;
        private Button btnDone;
        private Button btnDelete;
        private CheckBox chkEditMode;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmTransID;
        private DataGridViewComboBoxColumn clmItemID;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmValue;
        private DataGridViewTextBoxColumn clmPercent;
        private DataGridViewTextBoxColumn clmDiscount;
        private DataGridViewTextBoxColumn clmTotal;
    }
}