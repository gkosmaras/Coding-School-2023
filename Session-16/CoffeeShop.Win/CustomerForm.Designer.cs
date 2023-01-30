namespace Session_11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.addToCart = new System.Windows.Forms.Button();
            this.gridSales = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.gridTransaction = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.radCoffee = new System.Windows.Forms.RadioButton();
            this.radBeverages = new System.Windows.Forms.RadioButton();
            this.radFood = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(315, 131);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(72, 23);
            this.cmbMenu.TabIndex = 34;
            this.cmbMenu.SelectedValueChanged += new System.EventHandler(this.Menu_TextChanged);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(315, 160);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(72, 23);
            this.numQuantity.TabIndex = 35;
            this.numQuantity.ValueChanged += new System.EventHandler(this.Menu_TextChanged);
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(277, 194);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(110, 32);
            this.addToCart.TabIndex = 36;
            this.addToCart.Text = "Add";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // gridSales
            // 
            this.gridSales.Location = new System.Drawing.Point(60, 262);
            this.gridSales.MainView = this.gridView1;
            this.gridSales.Name = "gridSales";
            this.gridSales.Size = new System.Drawing.Size(622, 113);
            this.gridSales.TabIndex = 37;
            this.gridSales.UseEmbeddedNavigator = true;
            this.gridSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmDescription,
            this.clmQuantity,
            this.clmPrice,
            this.clmTotal});
            this.gridView1.GridControl = this.gridSales;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // clmDescription
            // 
            this.clmDescription.Caption = "Description";
            this.clmDescription.FieldName = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.OptionsColumn.ReadOnly = true;
            this.clmDescription.Visible = true;
            this.clmDescription.VisibleIndex = 0;
            // 
            // clmQuantity
            // 
            this.clmQuantity.Caption = "Quantity";
            this.clmQuantity.FieldName = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Visible = true;
            this.clmQuantity.VisibleIndex = 2;
            // 
            // clmPrice
            // 
            this.clmPrice.Caption = "Price";
            this.clmPrice.FieldName = "Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.OptionsColumn.ReadOnly = true;
            this.clmPrice.Visible = true;
            this.clmPrice.VisibleIndex = 1;
            // 
            // clmTotal
            // 
            this.clmTotal.Caption = "Total Price";
            this.clmTotal.FieldName = "TotalPrice";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.OptionsColumn.ReadOnly = true;
            this.clmTotal.Visible = true;
            this.clmTotal.VisibleIndex = 3;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(559, 194);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(122, 32);
            this.btnCheckout.TabIndex = 38;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // gridTransaction
            // 
            this.gridTransaction.Location = new System.Drawing.Point(60, 392);
            this.gridTransaction.MainView = this.gridView2;
            this.gridTransaction.Name = "gridTransaction";
            this.gridTransaction.Size = new System.Drawing.Size(630, 105);
            this.gridTransaction.TabIndex = 39;
            this.gridTransaction.UseEmbeddedNavigator = true;
            this.gridTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmDate,
            this.clmCustomerID,
            this.clmEmployeeID,
            this.clmPayment,
            this.clmTotalPrice});
            this.gridView2.GridControl = this.gridTransaction;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // clmDate
            // 
            this.clmDate.Caption = "Date";
            this.clmDate.FieldName = "Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.OptionsColumn.ReadOnly = true;
            this.clmDate.Visible = true;
            this.clmDate.VisibleIndex = 0;
            // 
            // clmCustomerID
            // 
            this.clmCustomerID.Caption = "CustomerID";
            this.clmCustomerID.FieldName = "CustomerID";
            this.clmCustomerID.Name = "clmCustomerID";
            this.clmCustomerID.OptionsColumn.ReadOnly = true;
            this.clmCustomerID.Visible = true;
            this.clmCustomerID.VisibleIndex = 1;
            // 
            // clmEmployeeID
            // 
            this.clmEmployeeID.Caption = "EmployeeID";
            this.clmEmployeeID.FieldName = "EmployeeID";
            this.clmEmployeeID.Name = "clmEmployeeID";
            this.clmEmployeeID.OptionsColumn.ReadOnly = true;
            this.clmEmployeeID.Visible = true;
            this.clmEmployeeID.VisibleIndex = 2;
            // 
            // clmPayment
            // 
            this.clmPayment.Caption = "Payment Method";
            this.clmPayment.FieldName = "TypeOfPayment";
            this.clmPayment.Name = "clmPayment";
            this.clmPayment.OptionsColumn.ReadOnly = true;
            this.clmPayment.Visible = true;
            this.clmPayment.VisibleIndex = 3;
            // 
            // clmTotalPrice
            // 
            this.clmTotalPrice.Caption = "Total Price";
            this.clmTotalPrice.FieldName = "TotalPrice";
            this.clmTotalPrice.Name = "clmTotalPrice";
            this.clmTotalPrice.OptionsColumn.ReadOnly = true;
            this.clmTotalPrice.Visible = true;
            this.clmTotalPrice.VisibleIndex = 4;
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Credit_Card"});
            this.cmbPayment.Location = new System.Drawing.Point(561, 165);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(121, 23);
            this.cmbPayment.TabIndex = 40;
            this.cmbPayment.SelectedIndexChanged += new System.EventHandler(this.Payment_TextChanged);
            this.cmbPayment.SelectedValueChanged += new System.EventHandler(this.Payment_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 511);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 45);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(524, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 24);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(495, 44);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "Product Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(220, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 46;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(430, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Payment Method";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(607, 502);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 22);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // radCoffee
            // 
            this.radCoffee.AutoSize = true;
            this.radCoffee.Location = new System.Drawing.Point(77, 134);
            this.radCoffee.Name = "radCoffee";
            this.radCoffee.Size = new System.Drawing.Size(60, 19);
            this.radCoffee.TabIndex = 1;
            this.radCoffee.TabStop = true;
            this.radCoffee.Text = "Coffee";
            this.radCoffee.UseVisualStyleBackColor = true;
            this.radCoffee.CheckedChanged += new System.EventHandler(this.radCoffee_CheckedChanged);
            // 
            // radBeverages
            // 
            this.radBeverages.AutoSize = true;
            this.radBeverages.Location = new System.Drawing.Point(77, 159);
            this.radBeverages.Name = "radBeverages";
            this.radBeverages.Size = new System.Drawing.Size(78, 19);
            this.radBeverages.TabIndex = 2;
            this.radBeverages.TabStop = true;
            this.radBeverages.Text = "Beverages";
            this.radBeverages.UseVisualStyleBackColor = true;
            this.radBeverages.CheckedChanged += new System.EventHandler(this.radBeverages_CheckedChanged);
            // 
            // radFood
            // 
            this.radFood.AutoSize = true;
            this.radFood.Location = new System.Drawing.Point(77, 184);
            this.radFood.Name = "radFood";
            this.radFood.Size = new System.Drawing.Size(52, 19);
            this.radFood.TabIndex = 3;
            this.radFood.TabStop = true;
            this.radFood.Text = "Food";
            this.radFood.UseVisualStyleBackColor = true;
            this.radFood.CheckedChanged += new System.EventHandler(this.radFood_CheckedChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(724, 554);
            this.Controls.Add(this.radFood);
            this.Controls.Add(this.radBeverages);
            this.Controls.Add(this.radCoffee);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.gridTransaction);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.gridSales);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.cmbMenu);
            this.Name = "CustomerForm";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbMenu;
        private NumericUpDown numQuantity;
        private Button addToCart;
        private DevExpress.XtraGrid.GridControl gridSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clmQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn clmDescription;
        private DevExpress.XtraGrid.Columns.GridColumn clmPrice;
        private DevExpress.XtraGrid.Columns.GridColumn clmTotal;
        private Button btnCheckout;
        private DevExpress.XtraGrid.GridControl gridTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn clmDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn clmEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn clmPayment;
        private DevExpress.XtraGrid.Columns.GridColumn clmTotalPrice;
        private ComboBox cmbPayment;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnBack;
        private RadioButton radCoffee;
        private RadioButton radBeverages;
        private RadioButton radFood;
        //private Button btnAddCart;
    }
}