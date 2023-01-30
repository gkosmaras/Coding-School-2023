namespace Session_11 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSaveEmployees = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gridEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridclmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridclmSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridclmEmployeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridclmSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProducts = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridProClmCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProClmCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnSaveProducts = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.cmbProType = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gridLedger = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmIncome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLedger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(276, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 23);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.Employee_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(394, 60);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(112, 23);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.TextChanged += new System.EventHandler(this.Employee_TextChanged);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(630, 60);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(112, 23);
            this.txtSalary.TabIndex = 5;
            this.txtSalary.TextChanged += new System.EventHandler(this.Employee_TextChanged);
            // 
            // btnSaveEmployees
            // 
            this.btnSaveEmployees.Location = new System.Drawing.Point(402, 88);
            this.btnSaveEmployees.Name = "btnSaveEmployees";
            this.btnSaveEmployees.Size = new System.Drawing.Size(163, 35);
            this.btnSaveEmployees.TabIndex = 7;
            this.btnSaveEmployees.Text = "Add";
            this.btnSaveEmployees.UseVisualStyleBackColor = true;
            this.btnSaveEmployees.Click += new System.EventHandler(this.btnSaveEmployeesClick);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Barista",
            "Waiter"});
            this.cmbType.Location = new System.Drawing.Point(511, 60);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(114, 23);
            this.cmbType.TabIndex = 8;
            this.cmbType.SelectedValueChanged += new System.EventHandler(this.Employee_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(818, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSaveJson);
            // 
            // gridEmployee
            // 
            this.gridEmployee.Location = new System.Drawing.Point(33, 149);
            this.gridEmployee.MainView = this.gridView1;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.Size = new System.Drawing.Size(758, 131);
            this.gridEmployee.TabIndex = 17;
            this.gridEmployee.UseEmbeddedNavigator = true;
            this.gridEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridclmName,
            this.gridclmSurname,
            this.gridclmEmployeeType,
            this.gridclmSalary});
            this.gridView1.GridControl = this.gridEmployee;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridclmName
            // 
            this.gridclmName.Caption = "Name";
            this.gridclmName.FieldName = "Name";
            this.gridclmName.Name = "gridclmName";
            this.gridclmName.Visible = true;
            this.gridclmName.VisibleIndex = 0;
            // 
            // gridclmSurname
            // 
            this.gridclmSurname.Caption = "Surname";
            this.gridclmSurname.FieldName = "Surname";
            this.gridclmSurname.Name = "gridclmSurname";
            this.gridclmSurname.Visible = true;
            this.gridclmSurname.VisibleIndex = 1;
            // 
            // gridclmEmployeeType
            // 
            this.gridclmEmployeeType.Caption = "EmployeeType";
            this.gridclmEmployeeType.FieldName = "TypeOfEmployee";
            this.gridclmEmployeeType.Name = "gridclmEmployeeType";
            this.gridclmEmployeeType.Visible = true;
            this.gridclmEmployeeType.VisibleIndex = 2;
            // 
            // gridclmSalary
            // 
            this.gridclmSalary.Caption = "Salary";
            this.gridclmSalary.FieldName = "SalaryPerMonth";
            this.gridclmSalary.Name = "gridclmSalary";
            this.gridclmSalary.Visible = true;
            this.gridclmSalary.VisibleIndex = 3;
            // 
            // gridProducts
            // 
            this.gridProducts.Location = new System.Drawing.Point(33, 423);
            this.gridProducts.MainView = this.gridView2;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(750, 129);
            this.gridProducts.TabIndex = 18;
            this.gridProducts.UseEmbeddedNavigator = true;
            this.gridProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridProClmCode,
            this.gridProClmDesc,
            this.gridProClmType,
            this.gridProClmPrice,
            this.gridProClmCost});
            this.gridView2.GridControl = this.gridProducts;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridProClmCode
            // 
            this.gridProClmCode.Caption = "Code";
            this.gridProClmCode.FieldName = "Code";
            this.gridProClmCode.Name = "gridProClmCode";
            this.gridProClmCode.Visible = true;
            this.gridProClmCode.VisibleIndex = 0;
            // 
            // gridProClmDesc
            // 
            this.gridProClmDesc.Caption = "Description";
            this.gridProClmDesc.FieldName = "Description";
            this.gridProClmDesc.Name = "gridProClmDesc";
            this.gridProClmDesc.Visible = true;
            this.gridProClmDesc.VisibleIndex = 1;
            // 
            // gridProClmType
            // 
            this.gridProClmType.Caption = "Type";
            this.gridProClmType.FieldName = "TypeOfProduct";
            this.gridProClmType.Name = "gridProClmType";
            this.gridProClmType.Visible = true;
            this.gridProClmType.VisibleIndex = 2;
            // 
            // gridProClmPrice
            // 
            this.gridProClmPrice.Caption = "Price";
            this.gridProClmPrice.FieldName = "Price";
            this.gridProClmPrice.Name = "gridProClmPrice";
            this.gridProClmPrice.Visible = true;
            this.gridProClmPrice.VisibleIndex = 3;
            // 
            // gridProClmCost
            // 
            this.gridProClmCost.Caption = "Cost";
            this.gridProClmCost.FieldName = "Cost";
            this.gridProClmCost.Name = "gridProClmCost";
            this.gridProClmCost.Visible = true;
            this.gridProClmCost.VisibleIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(290, 322);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(112, 23);
            this.txtDesc.TabIndex = 19;
            this.txtDesc.TextChanged += new System.EventHandler(this.Products_TextChanged);
            // 
            // btnSaveProducts
            // 
            this.btnSaveProducts.Location = new System.Drawing.Point(403, 358);
            this.btnSaveProducts.Name = "btnSaveProducts";
            this.btnSaveProducts.Size = new System.Drawing.Size(163, 35);
            this.btnSaveProducts.TabIndex = 20;
            this.btnSaveProducts.Text = "Add";
            this.btnSaveProducts.UseVisualStyleBackColor = true;
            this.btnSaveProducts.Click += new System.EventHandler(this.btnSaveProductsClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(544, 322);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(112, 23);
            this.txtPrice.TabIndex = 22;
            this.txtPrice.TextChanged += new System.EventHandler(this.Products_TextChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(676, 322);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(112, 23);
            this.txtCost.TabIndex = 24;
            this.txtCost.TextChanged += new System.EventHandler(this.Products_TextChanged);
            // 
            // cmbProType
            // 
            this.cmbProType.FormattingEnabled = true;
            this.cmbProType.Items.AddRange(new object[] {
            "Coffee",
            "Beverages",
            "Food"});
            this.cmbProType.Location = new System.Drawing.Point(424, 322);
            this.cmbProType.Name = "cmbProType";
            this.cmbProType.Size = new System.Drawing.Size(114, 23);
            this.cmbProType.TabIndex = 25;
            this.cmbProType.SelectedValueChanged += new System.EventHandler(this.Products_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 610);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(416, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Surname";
            this.label2.TextChanged += new System.EventHandler(this.Employee_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(305, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name";
            this.label3.TextChanged += new System.EventHandler(this.Employee_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(514, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Employee Type";
            this.label4.TextChanged += new System.EventHandler(this.Employee_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(661, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Salary";
            this.label5.TextChanged += new System.EventHandler(this.Employee_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(575, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(700, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(300, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(430, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "Product Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 314);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // gridLedger
            // 
            this.gridLedger.Location = new System.Drawing.Point(890, 149);
            this.gridLedger.MainView = this.gridView3;
            this.gridLedger.Name = "gridLedger";
            this.gridLedger.Size = new System.Drawing.Size(627, 123);
            this.gridLedger.TabIndex = 37;
            this.gridLedger.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmYear,
            this.clmMonth,
            this.clmIncome,
            this.clmExpenses,
            this.clmTotal});
            this.gridView3.GridControl = this.gridLedger;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // clmYear
            // 
            this.clmYear.Caption = "Year";
            this.clmYear.FieldName = "Year";
            this.clmYear.Name = "clmYear";
            this.clmYear.OptionsColumn.ReadOnly = true;
            this.clmYear.Visible = true;
            this.clmYear.VisibleIndex = 0;
            // 
            // clmMonth
            // 
            this.clmMonth.Caption = "Month";
            this.clmMonth.FieldName = "Month";
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.OptionsColumn.ReadOnly = true;
            this.clmMonth.Visible = true;
            this.clmMonth.VisibleIndex = 1;
            // 
            // clmIncome
            // 
            this.clmIncome.Caption = "Income";
            this.clmIncome.FieldName = "Income";
            this.clmIncome.Name = "clmIncome";
            this.clmIncome.OptionsColumn.ReadOnly = true;
            this.clmIncome.Visible = true;
            this.clmIncome.VisibleIndex = 2;
            // 
            // clmExpenses
            // 
            this.clmExpenses.Caption = "Expenses";
            this.clmExpenses.FieldName = "Expenses";
            this.clmExpenses.Name = "clmExpenses";
            this.clmExpenses.OptionsColumn.ReadOnly = true;
            this.clmExpenses.Visible = true;
            this.clmExpenses.VisibleIndex = 3;
            // 
            // clmTotal
            // 
            this.clmTotal.Caption = "Total";
            this.clmTotal.FieldName = "Total";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.OptionsColumn.ReadOnly = true;
            this.clmTotal.Visible = true;
            this.clmTotal.VisibleIndex = 4;
            // 
            // btnLedger
            // 
            this.btnLedger.Location = new System.Drawing.Point(1327, 284);
            this.btnLedger.Name = "btnLedger";
            this.btnLedger.Size = new System.Drawing.Size(158, 41);
            this.btnLedger.TabIndex = 38;
            this.btnLedger.Text = "Show Ledger";
            this.btnLedger.UseVisualStyleBackColor = true;
            this.btnLedger.Click += new System.EventHandler(this.btnLedger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Employees";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(110, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Products";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1549, 679);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLedger);
            this.Controls.Add(this.gridLedger);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbProType);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSaveProducts);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnSaveEmployees);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtSalary;
        private Button btnSaveEmployees;
        private ComboBox cmbType;
        private Button btnShowEmployees;
        private DevExpress.XtraGrid.GridControl gridEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridclmName;
        private DevExpress.XtraGrid.Columns.GridColumn gridclmSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridclmEmployeeType;
        private DevExpress.XtraGrid.Columns.GridColumn gridclmSalary;
        private DevExpress.XtraGrid.GridControl gridProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private TextBox txtDesc;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmDesc;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmType;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridProClmCost;
        private Button btnSaveProducts;
        private Button btnLoadProducts;
        private TextBox txtPrice;
        private TextBox txtCost;
        private ComboBox cmbProType;
        private Button button2;
        private Button btnSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DevExpress.XtraGrid.GridControl gridLedger;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn clmYear;
        private DevExpress.XtraGrid.Columns.GridColumn clmMonth;
        private DevExpress.XtraGrid.Columns.GridColumn clmIncome;
        private DevExpress.XtraGrid.Columns.GridColumn clmExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn clmTotal;
        private Button btnLedger;
        private Label label1;
        private Label label10;
    }
}