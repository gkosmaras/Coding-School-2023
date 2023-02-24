namespace FuelStation.Win
{
    partial class ItemForm
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
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblQnt = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudCode = new System.Windows.Forms.NumericUpDown();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grvItem = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItemType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkEditMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(32, 344);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(39, 15);
            this.lblDetail.TabIndex = 43;
            this.lblDetail.Text = "Name";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(32, 424);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(40, 15);
            this.lblCount.TabIndex = 42;
            this.lblCount.Text = "Count";
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Location = new System.Drawing.Point(32, 399);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(53, 15);
            this.lblQnt.TabIndex = 41;
            this.lblQnt.Text = "Quantity";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(32, 372);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(32, 15);
            this.lblSum.TabIndex = 40;
            this.lblSum.Text = "Total";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(604, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 50);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save New";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudCode
            // 
            this.nudCode.Location = new System.Drawing.Point(660, 171);
            this.nudCode.Name = "nudCode";
            this.nudCode.Size = new System.Drawing.Size(116, 23);
            this.nudCode.TabIndex = 36;
            // 
            // nudCost
            // 
            this.nudCost.Location = new System.Drawing.Point(661, 270);
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(116, 23);
            this.nudCost.TabIndex = 35;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(661, 220);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(116, 23);
            this.nudPrice.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(554, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Item Type:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(661, 73);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(116, 23);
            this.cmbType.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(554, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(554, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(554, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(554, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Code:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(661, 122);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(115, 23);
            this.txtDescription.TabIndex = 27;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(604, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 50);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grvItem
            // 
            this.grvItem.BackgroundColor = System.Drawing.Color.LightYellow;
            this.grvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmCode,
            this.clmDescription,
            this.clmItemType,
            this.clmPrice,
            this.clmCost});
            this.grvItem.GridColor = System.Drawing.Color.Black;
            this.grvItem.Location = new System.Drawing.Point(32, 19);
            this.grvItem.Name = "grvItem";
            this.grvItem.Size = new System.Drawing.Size(499, 312);
            this.grvItem.TabIndex = 24;
            this.grvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvItem_CellClick);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.Width = 5;
            // 
            // clmCode
            // 
            this.clmCode.DataPropertyName = "Code";
            this.clmCode.HeaderText = "Code";
            this.clmCode.Name = "clmCode";
            this.clmCode.Width = 50;
            // 
            // clmDescription
            // 
            this.clmDescription.DataPropertyName = "Description";
            this.clmDescription.HeaderText = "Description";
            this.clmDescription.Name = "clmDescription";
            // 
            // clmItemType
            // 
            this.clmItemType.DataPropertyName = "ItemType";
            this.clmItemType.HeaderText = "Item Type";
            this.clmItemType.Name = "clmItemType";
            // 
            // clmPrice
            // 
            this.clmPrice.DataPropertyName = "Price";
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.Name = "clmPrice";
            // 
            // clmCost
            // 
            this.clmCost.DataPropertyName = "Cost";
            this.clmCost.HeaderText = "Cost";
            this.clmCost.Name = "clmCost";
            // 
            // chkEditMode
            // 
            this.chkEditMode.AutoSize = true;
            this.chkEditMode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEditMode.Location = new System.Drawing.Point(554, 19);
            this.chkEditMode.Name = "chkEditMode";
            this.chkEditMode.Size = new System.Drawing.Size(99, 24);
            this.chkEditMode.TabIndex = 44;
            this.chkEditMode.Text = "Edit Mode";
            this.chkEditMode.UseVisualStyleBackColor = true;
            this.chkEditMode.CheckedChanged += new System.EventHandler(this.chkEditMode_CheckChanged);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkEditMode);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblQnt);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudCode);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grvItem);
            this.Name = "ItemForm";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource bsItem;
        private Label lblDetail;
        private Label lblCount;
        private Label lblQnt;
        private Label lblSum;
        private Button btnSave;
        private NumericUpDown nudCode;
        private NumericUpDown nudCost;
        private NumericUpDown nudPrice;
        private Label label5;
        private ComboBox cmbType;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private Button btnDelete;
        private DataGridView grvItem;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmCode;
        private DataGridViewTextBoxColumn clmDescription;
        private DataGridViewComboBoxColumn clmItemType;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmCost;
        private CheckBox chkEditMode;
    }
}