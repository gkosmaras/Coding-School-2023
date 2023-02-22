namespace FuelStation.Win
{
    partial class TransactionLineForm
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
            this.bsTransLine = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grvTransLine = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefersh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLine)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(685, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 42);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(236, 375);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(59, 23);
            this.nudQuantity.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product";
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(326, 375);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(154, 23);
            this.cmbItem.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(685, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 42);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grvTransLine
            // 
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
            this.grvTransLine.Location = new System.Drawing.Point(12, 65);
            this.grvTransLine.Name = "grvTransLine";
            this.grvTransLine.RowTemplate.Height = 25;
            this.grvTransLine.Size = new System.Drawing.Size(981, 185);
            this.grvTransLine.TabIndex = 17;
            this.grvTransLine.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            // 
            // clmTransID
            // 
            this.clmTransID.DataPropertyName = "TransactionID";
            this.clmTransID.HeaderText = "TransactionID";
            this.clmTransID.Name = "clmTransID";
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
            // 
            // clmPrice
            // 
            this.clmPrice.DataPropertyName = "ItemPrice";
            this.clmPrice.HeaderText = "Item Price";
            this.clmPrice.Name = "clmPrice";
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
            // 
            // clmDiscount
            // 
            this.clmDiscount.DataPropertyName = "DiscountValue";
            this.clmDiscount.HeaderText = "Discount Value";
            this.clmDiscount.Name = "clmDiscount";
            // 
            // clmTotal
            // 
            this.clmTotal.DataPropertyName = "TotalValue";
            this.clmTotal.HeaderText = "Total Value";
            this.clmTotal.Name = "clmTotal";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(516, 316);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 42);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefersh
            // 
            this.btnRefersh.Location = new System.Drawing.Point(516, 364);
            this.btnRefersh.Name = "btnRefersh";
            this.btnRefersh.Size = new System.Drawing.Size(147, 42);
            this.btnRefersh.TabIndex = 19;
            this.btnRefersh.Text = "Refresh";
            this.btnRefersh.UseVisualStyleBackColor = true;
            this.btnRefersh.Click += new System.EventHandler(this.TransactionLineForm_Load);
            // 
            // TransactionLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.btnRefersh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grvTransLine);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox1);
            this.Name = "TransactionLineForm";
            this.Text = "TransactionLineForm";
            this.Load += new System.EventHandler(this.TransactionLineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource bsTransLine;
        private TextBox textBox1;
        private Button btnSave;
        private Label label1;
        private NumericUpDown nudQuantity;
        private Label label2;
        private ComboBox cmbItem;
        private Button btnDelete;
        private DataGridView grvTransLine;
        private Button btnEdit;
        private Button btnDone;
        private Button btnRefersh;
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