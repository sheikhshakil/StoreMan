
namespace StoreMan
{
    partial class TabSalesReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.filterOptionsBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateInput = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.showAllDataBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reportView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.saleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.totalSaleLabel = new System.Windows.Forms.Label();
            this.totalInvestBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.totalInvestLabel = new System.Windows.Forms.Label();
            this.totalProfitBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.totalProfitLabel = new System.Windows.Forms.Label();
            this.totalVatBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.totalVatLabel = new System.Windows.Forms.Label();
            this.totalDuesBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.totalDueLabel = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).BeginInit();
            this.totalSalesBox.SuspendLayout();
            this.totalInvestBox.SuspendLayout();
            this.totalProfitBox.SuspendLayout();
            this.totalVatBox.SuspendLayout();
            this.totalDuesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GroupBox1.Controls.Add(this.filterOptionsBox);
            this.guna2GroupBox1.Controls.Add(this.dateInput);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(8, 8);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(420, 90);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Filter by date";
            this.guna2GroupBox1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // filterOptionsBox
            // 
            this.filterOptionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterOptionsBox.BackColor = System.Drawing.Color.Transparent;
            this.filterOptionsBox.BorderColor = System.Drawing.Color.Silver;
            this.filterOptionsBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterOptionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterOptionsBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.filterOptionsBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.filterOptionsBox.FocusedState.Parent = this.filterOptionsBox;
            this.filterOptionsBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterOptionsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterOptionsBox.HoverState.Parent = this.filterOptionsBox;
            this.filterOptionsBox.ItemHeight = 30;
            this.filterOptionsBox.Items.AddRange(new object[] {
            "This date only",
            "This month",
            "This year"});
            this.filterOptionsBox.ItemsAppearance.Parent = this.filterOptionsBox;
            this.filterOptionsBox.Location = new System.Drawing.Point(244, 46);
            this.filterOptionsBox.Name = "filterOptionsBox";
            this.filterOptionsBox.ShadowDecoration.Parent = this.filterOptionsBox;
            this.filterOptionsBox.Size = new System.Drawing.Size(168, 36);
            this.filterOptionsBox.TabIndex = 1;
            this.filterOptionsBox.SelectedIndexChanged += new System.EventHandler(this.filterOptionsBox_SelectedIndexChanged);
            // 
            // dateInput
            // 
            this.dateInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateInput.CheckedState.Parent = this.dateInput;
            this.dateInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateInput.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateInput.HoverState.Parent = this.dateInput;
            this.dateInput.Location = new System.Drawing.Point(8, 46);
            this.dateInput.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateInput.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateInput.Name = "dateInput";
            this.dateInput.ShadowDecoration.Parent = this.dateInput;
            this.dateInput.Size = new System.Drawing.Size(230, 36);
            this.dateInput.TabIndex = 0;
            this.dateInput.Value = new System.DateTime(2021, 10, 1, 0, 0, 0, 0);
            this.dateInput.ValueChanged += new System.EventHandler(this.dateInput_ValueChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Controls.Add(this.searchInput);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(434, 8);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(328, 90);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Filter by data";
            this.guna2GroupBox2.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // searchInput
            // 
            this.searchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchInput.BorderColor = System.Drawing.Color.Silver;
            this.searchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInput.DefaultText = "";
            this.searchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchInput.DisabledState.Parent = this.searchInput;
            this.searchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchInput.FocusedState.Parent = this.searchInput;
            this.searchInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchInput.ForeColor = System.Drawing.Color.DimGray;
            this.searchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.searchInput.HoverState.Parent = this.searchInput;
            this.searchInput.Location = new System.Drawing.Point(8, 46);
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchInput.PlaceholderText = "Use Sale ID or Customer phone/name";
            this.searchInput.SelectedText = "";
            this.searchInput.ShadowDecoration.Parent = this.searchInput;
            this.searchInput.Size = new System.Drawing.Size(312, 36);
            this.searchInput.TabIndex = 0;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GroupBox3.Controls.Add(this.showAllDataBtn);
            this.guna2GroupBox3.Controls.Add(this.reportView);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(8, 104);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Padding = new System.Windows.Forms.Padding(3);
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(754, 381);
            this.guna2GroupBox3.TabIndex = 2;
            this.guna2GroupBox3.Text = "Sales report";
            this.guna2GroupBox3.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // showAllDataBtn
            // 
            this.showAllDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllDataBtn.Animated = true;
            this.showAllDataBtn.CheckedState.Parent = this.showAllDataBtn;
            this.showAllDataBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllDataBtn.CustomImages.Parent = this.showAllDataBtn;
            this.showAllDataBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAllDataBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAllDataBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAllDataBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAllDataBtn.DisabledState.Parent = this.showAllDataBtn;
            this.showAllDataBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.showAllDataBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.showAllDataBtn.ForeColor = System.Drawing.Color.White;
            this.showAllDataBtn.HoverState.Parent = this.showAllDataBtn;
            this.showAllDataBtn.Location = new System.Drawing.Point(610, -2);
            this.showAllDataBtn.Name = "showAllDataBtn";
            this.showAllDataBtn.ShadowDecoration.Parent = this.showAllDataBtn;
            this.showAllDataBtn.Size = new System.Drawing.Size(146, 32);
            this.showAllDataBtn.TabIndex = 1;
            this.showAllDataBtn.Text = "Show all data";
            this.showAllDataBtn.Click += new System.EventHandler(this.showAllDataBtn_Click);
            // 
            // reportView
            // 
            this.reportView.AllowUserToAddRows = false;
            this.reportView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.reportView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.reportView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reportView.BackgroundColor = System.Drawing.Color.White;
            this.reportView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.reportView.ColumnHeadersHeight = 44;
            this.reportView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleId,
            this.dateSold,
            this.productsData,
            this.typesCount,
            this.buyPriceTotal,
            this.subTotal,
            this.discount,
            this.vat,
            this.netTotal,
            this.due,
            this.custName,
            this.custPhone,
            this.custAddr});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportView.DefaultCellStyle = dataGridViewCellStyle12;
            this.reportView.EnableHeadersVisualStyles = false;
            this.reportView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.reportView.Location = new System.Drawing.Point(6, 45);
            this.reportView.Name = "reportView";
            this.reportView.ReadOnly = true;
            this.reportView.RowHeadersVisible = false;
            this.reportView.RowTemplate.ReadOnly = true;
            this.reportView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.reportView.Size = new System.Drawing.Size(742, 330);
            this.reportView.TabIndex = 0;
            this.reportView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.reportView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.reportView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.reportView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.reportView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.reportView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.reportView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.reportView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.reportView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.reportView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.reportView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.reportView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.reportView.ThemeStyle.HeaderStyle.Height = 44;
            this.reportView.ThemeStyle.ReadOnly = true;
            this.reportView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.reportView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.reportView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportView.ThemeStyle.RowsStyle.Height = 22;
            this.reportView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.reportView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.reportView.DataSourceChanged += new System.EventHandler(this.reportView_DataSourceChanged);
            this.reportView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportView_CellDoubleClick);
            // 
            // saleId
            // 
            this.saleId.DataPropertyName = "saleId";
            this.saleId.HeaderText = "Sale ID";
            this.saleId.Name = "saleId";
            this.saleId.ReadOnly = true;
            // 
            // dateSold
            // 
            this.dateSold.DataPropertyName = "dateSold";
            this.dateSold.HeaderText = "Date sold";
            this.dateSold.Name = "dateSold";
            this.dateSold.ReadOnly = true;
            // 
            // productsData
            // 
            this.productsData.DataPropertyName = "productsData";
            this.productsData.HeaderText = "Products data";
            this.productsData.Name = "productsData";
            this.productsData.ReadOnly = true;
            this.productsData.Visible = false;
            // 
            // typesCount
            // 
            this.typesCount.DataPropertyName = "typesCount";
            this.typesCount.HeaderText = "Products count";
            this.typesCount.Name = "typesCount";
            this.typesCount.ReadOnly = true;
            // 
            // buyPriceTotal
            // 
            this.buyPriceTotal.DataPropertyName = "buyPriceTotal";
            this.buyPriceTotal.HeaderText = "Buy price total";
            this.buyPriceTotal.Name = "buyPriceTotal";
            this.buyPriceTotal.ReadOnly = true;
            this.buyPriceTotal.Visible = false;
            // 
            // subTotal
            // 
            this.subTotal.DataPropertyName = "subTotal";
            this.subTotal.HeaderText = "Sub total";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "Total discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // vat
            // 
            this.vat.DataPropertyName = "vat";
            this.vat.HeaderText = "VAT";
            this.vat.Name = "vat";
            this.vat.ReadOnly = true;
            // 
            // netTotal
            // 
            this.netTotal.DataPropertyName = "netTotal";
            this.netTotal.HeaderText = "Net total";
            this.netTotal.Name = "netTotal";
            this.netTotal.ReadOnly = true;
            // 
            // due
            // 
            this.due.DataPropertyName = "due";
            this.due.HeaderText = "Due";
            this.due.Name = "due";
            this.due.ReadOnly = true;
            // 
            // custName
            // 
            this.custName.DataPropertyName = "custName";
            this.custName.HeaderText = "Cust. name";
            this.custName.Name = "custName";
            this.custName.ReadOnly = true;
            // 
            // custPhone
            // 
            this.custPhone.DataPropertyName = "custPhone";
            this.custPhone.HeaderText = "Cust. phone";
            this.custPhone.Name = "custPhone";
            this.custPhone.ReadOnly = true;
            // 
            // custAddr
            // 
            this.custAddr.DataPropertyName = "custAddr";
            this.custAddr.HeaderText = "Cust. address";
            this.custAddr.Name = "custAddr";
            this.custAddr.ReadOnly = true;
            this.custAddr.Visible = false;
            // 
            // totalSalesBox
            // 
            this.totalSalesBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalSalesBox.BorderColor = System.Drawing.Color.DarkOrchid;
            this.totalSalesBox.Controls.Add(this.totalSaleLabel);
            this.totalSalesBox.CustomBorderColor = System.Drawing.Color.DarkOrchid;
            this.totalSalesBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalSalesBox.ForeColor = System.Drawing.Color.White;
            this.totalSalesBox.Location = new System.Drawing.Point(768, 104);
            this.totalSalesBox.Name = "totalSalesBox";
            this.totalSalesBox.Padding = new System.Windows.Forms.Padding(5);
            this.totalSalesBox.ShadowDecoration.Parent = this.totalSalesBox;
            this.totalSalesBox.Size = new System.Drawing.Size(219, 92);
            this.totalSalesBox.TabIndex = 3;
            this.totalSalesBox.Text = "Total sales";
            this.totalSalesBox.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.totalSalesBox.MouseEnter += new System.EventHandler(this.totalSalesBox_MouseEnter);
            // 
            // totalSaleLabel
            // 
            this.totalSaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSaleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSaleLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.totalSaleLabel.Location = new System.Drawing.Point(8, 47);
            this.totalSaleLabel.Name = "totalSaleLabel";
            this.totalSaleLabel.Size = new System.Drawing.Size(203, 37);
            this.totalSaleLabel.TabIndex = 0;
            this.totalSaleLabel.Text = "0";
            this.totalSaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalInvestBox
            // 
            this.totalInvestBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalInvestBox.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.totalInvestBox.Controls.Add(this.totalInvestLabel);
            this.totalInvestBox.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.totalInvestBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalInvestBox.ForeColor = System.Drawing.Color.Black;
            this.totalInvestBox.Location = new System.Drawing.Point(768, 8);
            this.totalInvestBox.Name = "totalInvestBox";
            this.totalInvestBox.Padding = new System.Windows.Forms.Padding(5);
            this.totalInvestBox.ShadowDecoration.Parent = this.totalInvestBox;
            this.totalInvestBox.Size = new System.Drawing.Size(219, 90);
            this.totalInvestBox.TabIndex = 4;
            this.totalInvestBox.Text = "Total investment";
            this.totalInvestBox.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.totalInvestBox.MouseEnter += new System.EventHandler(this.totalInvestBox_MouseEnter);
            // 
            // totalInvestLabel
            // 
            this.totalInvestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalInvestLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInvestLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.totalInvestLabel.Location = new System.Drawing.Point(8, 47);
            this.totalInvestLabel.Name = "totalInvestLabel";
            this.totalInvestLabel.Size = new System.Drawing.Size(203, 35);
            this.totalInvestLabel.TabIndex = 0;
            this.totalInvestLabel.Text = "0";
            this.totalInvestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalProfitBox
            // 
            this.totalProfitBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalProfitBox.BorderColor = System.Drawing.Color.YellowGreen;
            this.totalProfitBox.Controls.Add(this.totalProfitLabel);
            this.totalProfitBox.CustomBorderColor = System.Drawing.Color.YellowGreen;
            this.totalProfitBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalProfitBox.ForeColor = System.Drawing.Color.Black;
            this.totalProfitBox.Location = new System.Drawing.Point(768, 299);
            this.totalProfitBox.Name = "totalProfitBox";
            this.totalProfitBox.Padding = new System.Windows.Forms.Padding(5);
            this.totalProfitBox.ShadowDecoration.Parent = this.totalProfitBox;
            this.totalProfitBox.Size = new System.Drawing.Size(219, 91);
            this.totalProfitBox.TabIndex = 5;
            this.totalProfitBox.Text = "Total profit";
            this.totalProfitBox.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.totalProfitBox.MouseEnter += new System.EventHandler(this.totalProfitBox_MouseEnter);
            // 
            // totalProfitLabel
            // 
            this.totalProfitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalProfitLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProfitLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.totalProfitLabel.Location = new System.Drawing.Point(8, 47);
            this.totalProfitLabel.Name = "totalProfitLabel";
            this.totalProfitLabel.Size = new System.Drawing.Size(203, 36);
            this.totalProfitLabel.TabIndex = 0;
            this.totalProfitLabel.Text = "0";
            this.totalProfitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalVatBox
            // 
            this.totalVatBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalVatBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.totalVatBox.Controls.Add(this.totalVatLabel);
            this.totalVatBox.CustomBorderColor = System.Drawing.Color.OrangeRed;
            this.totalVatBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalVatBox.ForeColor = System.Drawing.Color.White;
            this.totalVatBox.Location = new System.Drawing.Point(768, 396);
            this.totalVatBox.Name = "totalVatBox";
            this.totalVatBox.Padding = new System.Windows.Forms.Padding(5);
            this.totalVatBox.ShadowDecoration.Parent = this.totalVatBox;
            this.totalVatBox.Size = new System.Drawing.Size(219, 89);
            this.totalVatBox.TabIndex = 5;
            this.totalVatBox.Text = "Total payable vat";
            this.totalVatBox.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.totalVatBox.MouseEnter += new System.EventHandler(this.totalVatBox_MouseEnter);
            // 
            // totalVatLabel
            // 
            this.totalVatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalVatLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVatLabel.ForeColor = System.Drawing.Color.Red;
            this.totalVatLabel.Location = new System.Drawing.Point(8, 43);
            this.totalVatLabel.Name = "totalVatLabel";
            this.totalVatLabel.Size = new System.Drawing.Size(203, 41);
            this.totalVatLabel.TabIndex = 0;
            this.totalVatLabel.Text = "0";
            this.totalVatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDuesBox
            // 
            this.totalDuesBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalDuesBox.BorderColor = System.Drawing.Color.OrangeRed;
            this.totalDuesBox.Controls.Add(this.totalDueLabel);
            this.totalDuesBox.CustomBorderColor = System.Drawing.Color.OrangeRed;
            this.totalDuesBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalDuesBox.ForeColor = System.Drawing.Color.White;
            this.totalDuesBox.Location = new System.Drawing.Point(768, 202);
            this.totalDuesBox.Name = "totalDuesBox";
            this.totalDuesBox.Padding = new System.Windows.Forms.Padding(5);
            this.totalDuesBox.ShadowDecoration.Parent = this.totalDuesBox;
            this.totalDuesBox.Size = new System.Drawing.Size(219, 91);
            this.totalDuesBox.TabIndex = 5;
            this.totalDuesBox.Text = "Total dues";
            this.totalDuesBox.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.totalDuesBox.MouseEnter += new System.EventHandler(this.totalDuesBox_MouseEnter);
            // 
            // totalDueLabel
            // 
            this.totalDueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDueLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDueLabel.ForeColor = System.Drawing.Color.Red;
            this.totalDueLabel.Location = new System.Drawing.Point(8, 46);
            this.totalDueLabel.Name = "totalDueLabel";
            this.totalDueLabel.Size = new System.Drawing.Size(203, 37);
            this.totalDueLabel.TabIndex = 0;
            this.totalDueLabel.Text = "0";
            this.totalDueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.totalDuesBox);
            this.Controls.Add(this.totalVatBox);
            this.Controls.Add(this.totalProfitBox);
            this.Controls.Add(this.totalSalesBox);
            this.Controls.Add(this.totalInvestBox);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "TabSalesReport";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(995, 493);
            this.Load += new System.EventHandler(this.TabSalesReport_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).EndInit();
            this.totalSalesBox.ResumeLayout(false);
            this.totalInvestBox.ResumeLayout(false);
            this.totalProfitBox.ResumeLayout(false);
            this.totalVatBox.ResumeLayout(false);
            this.totalDuesBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox filterOptionsBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateInput;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox totalSalesBox;
        private System.Windows.Forms.Label totalSaleLabel;
        private Guna.UI2.WinForms.Guna2Button showAllDataBtn;
        private Guna.UI2.WinForms.Guna2DataGridView reportView;
        private Guna.UI2.WinForms.Guna2GroupBox totalInvestBox;
        private System.Windows.Forms.Label totalInvestLabel;
        private Guna.UI2.WinForms.Guna2GroupBox totalProfitBox;
        private System.Windows.Forms.Label totalProfitLabel;
        private Guna.UI2.WinForms.Guna2GroupBox totalVatBox;
        private Guna.UI2.WinForms.Guna2GroupBox totalDuesBox;
        private System.Windows.Forms.Label totalDueLabel;
        private System.Windows.Forms.Label totalVatLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn typesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPriceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn netTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn due;
        private System.Windows.Forms.DataGridViewTextBoxColumn custName;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddr;
    }
}
