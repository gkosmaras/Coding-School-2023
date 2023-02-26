namespace FuelStation.Win
{
    partial class DetailsForm
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
            this.bsTransLine = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).BeginInit();
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
            this.grvTransLine.Location = new System.Drawing.Point(12, 12);
            this.grvTransLine.Name = "grvTransLine";
            this.grvTransLine.RowTemplate.Height = 25;
            this.grvTransLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grvTransLine.Size = new System.Drawing.Size(582, 331);
            this.grvTransLine.TabIndex = 19;
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
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(609, 352);
            this.Controls.Add(this.grvTransLine);
            this.Name = "DetailsForm";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grvTransLine;
        private BindingSource bsTransLine;
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