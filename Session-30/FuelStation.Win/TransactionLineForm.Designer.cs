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
            this.grvTransLine = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDisPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDisValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransLine = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransLine
            // 
            this.grvTransLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmTransID,
            this.clmItemId,
            this.clmQuantity,
            this.clmItemPrice,
            this.clmNetValue,
            this.clmDisPercent,
            this.clmDisValue,
            this.clmTotalValue});
            this.grvTransLine.Location = new System.Drawing.Point(3, 48);
            this.grvTransLine.Name = "grvTransLine";
            this.grvTransLine.RowTemplate.Height = 25;
            this.grvTransLine.Size = new System.Drawing.Size(945, 179);
            this.grvTransLine.TabIndex = 0;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "ID";
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            // 
            // clmTransID
            // 
            this.clmTransID.DataPropertyName = "TransactionID";
            this.clmTransID.HeaderText = "Transaction ID";
            this.clmTransID.Name = "clmTransID";
            // 
            // clmItemId
            // 
            this.clmItemId.DataPropertyName = "ItemID";
            this.clmItemId.HeaderText = "Item ID";
            this.clmItemId.Name = "clmItemId";
            // 
            // clmQuantity
            // 
            this.clmQuantity.DataPropertyName = "Quantity";
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmItemPrice
            // 
            this.clmItemPrice.DataPropertyName = "ItemPrice";
            this.clmItemPrice.HeaderText = "Item Price";
            this.clmItemPrice.Name = "clmItemPrice";
            // 
            // clmNetValue
            // 
            this.clmNetValue.DataPropertyName = "NetValue";
            this.clmNetValue.HeaderText = "Net Value";
            this.clmNetValue.Name = "clmNetValue";
            // 
            // clmDisPercent
            // 
            this.clmDisPercent.DataPropertyName = "DiscountPercent";
            this.clmDisPercent.HeaderText = "Discount %";
            this.clmDisPercent.Name = "clmDisPercent";
            // 
            // clmDisValue
            // 
            this.clmDisValue.DataPropertyName = "DiscountValue";
            this.clmDisValue.HeaderText = "Discount Value";
            this.clmDisValue.Name = "clmDisValue";
            // 
            // clmTotalValue
            // 
            this.clmTotalValue.DataPropertyName = "TotalValue";
            this.clmTotalValue.HeaderText = "Total Value";
            this.clmTotalValue.Name = "clmTotalValue";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 285);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 23);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(52, 314);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 23);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(52, 343);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(58, 23);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(127, 343);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(58, 23);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(127, 314);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(58, 23);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(127, 285);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(58, 23);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(127, 256);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(58, 23);
            this.textBox8.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(232, 50);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TransactionLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grvTransLine);
            this.Name = "TransactionLineForm";
            this.Text = "TransactionLineForm";
            this.Load += new System.EventHandler(this.TransactionLineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvTransLine;
        private BindingSource bsTransLine;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmTransID;
        private DataGridViewTextBoxColumn clmItemId;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmItemPrice;
        private DataGridViewTextBoxColumn clmNetValue;
        private DataGridViewTextBoxColumn clmDisPercent;
        private DataGridViewTextBoxColumn clmDisValue;
        private DataGridViewTextBoxColumn clmTotalValue;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button btnSave;
    }
}