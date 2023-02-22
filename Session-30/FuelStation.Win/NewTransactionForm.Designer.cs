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
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsNewTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCard = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNewTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
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
            this.grvTransLine.Location = new System.Drawing.Point(26, 26);
            this.grvTransLine.Name = "grvTransLine";
            this.grvTransLine.RowTemplate.Height = 25;
            this.grvTransLine.Size = new System.Drawing.Size(688, 185);
            this.grvTransLine.TabIndex = 18;
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
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(172, 340);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(154, 23);
            this.cmbItem.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(82, 340);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(59, 23);
            this.nudQuantity.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantity";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(469, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 34);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(469, 297);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(181, 34);
            this.btnDone.TabIndex = 24;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Checked = true;
            this.radCash.Location = new System.Drawing.Point(304, 252);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(51, 19);
            this.radCash.TabIndex = 25;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCard
            // 
            this.radCard.AutoSize = true;
            this.radCard.Location = new System.Drawing.Point(304, 277);
            this.radCard.Name = "radCard";
            this.radCard.Size = new System.Drawing.Size(85, 19);
            this.radCard.TabIndex = 26;
            this.radCard.Text = "Credit Card";
            this.radCard.UseVisualStyleBackColor = true;
            // 
            // NewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radCard);
            this.Controls.Add(this.radCash);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvTransLine);
            this.Name = "NewTransactionForm";
            this.Text = "NewTransaction";
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
        private Label label2;
        private NumericUpDown nudQuantity;
        private Label label1;
        private Button btnSave;
        private Button btnDone;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmTransID;
        private DataGridViewComboBoxColumn clmItemID;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmValue;
        private DataGridViewTextBoxColumn clmPercent;
        private DataGridViewTextBoxColumn clmDiscount;
        private DataGridViewTextBoxColumn clmTotal;
        private RadioButton radCash;
        private RadioButton radCard;
    }
}