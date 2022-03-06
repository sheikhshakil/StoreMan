
namespace StoreMan
{
    partial class TabInventory
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch
            {
                return;
            }
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.sppuInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.clearFieldsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveProductBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.photoInput = new System.Windows.Forms.PictureBox();
            this.choosePhotoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bppuInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantityInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.pNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.pCodeInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.searchByQtyInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.inventoryView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.notiBar = new System.Windows.Forms.Label();
            this.pId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.pCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bppu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sppu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoInput)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.NavajoWhite;
            this.guna2GroupBox1.Controls.Add(this.sppuInput);
            this.guna2GroupBox1.Controls.Add(this.clearFieldsBtn);
            this.guna2GroupBox1.Controls.Add(this.saveProductBtn);
            this.guna2GroupBox1.Controls.Add(this.guna2GroupBox2);
            this.guna2GroupBox1.Controls.Add(this.bppuInput);
            this.guna2GroupBox1.Controls.Add(this.quantityInput);
            this.guna2GroupBox1.Controls.Add(this.pNameInput);
            this.guna2GroupBox1.Controls.Add(this.pCodeInput);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.NavajoWhite;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.guna2GroupBox1.Location = new System.Drawing.Point(8, 8);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(321, 464);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "ADD PRODUCTS";
            // 
            // sppuInput
            // 
            this.sppuInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sppuInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sppuInput.DefaultText = "";
            this.sppuInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sppuInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sppuInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sppuInput.DisabledState.Parent = this.sppuInput;
            this.sppuInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sppuInput.FocusedState.BorderColor = System.Drawing.Color.Orange;
            this.sppuInput.FocusedState.Parent = this.sppuInput;
            this.sppuInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sppuInput.ForeColor = System.Drawing.Color.Black;
            this.sppuInput.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.sppuInput.HoverState.Parent = this.sppuInput;
            this.sppuInput.Location = new System.Drawing.Point(13, 205);
            this.sppuInput.Name = "sppuInput";
            this.sppuInput.PasswordChar = '\0';
            this.sppuInput.PlaceholderText = "Sale price per unit";
            this.sppuInput.SelectedText = "";
            this.sppuInput.ShadowDecoration.Parent = this.sppuInput;
            this.sppuInput.Size = new System.Drawing.Size(295, 34);
            this.sppuInput.TabIndex = 4;
            // 
            // clearFieldsBtn
            // 
            this.clearFieldsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearFieldsBtn.Animated = true;
            this.clearFieldsBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearFieldsBtn.CheckedState.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFieldsBtn.CustomImages.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearFieldsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearFieldsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearFieldsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearFieldsBtn.DisabledState.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.FillColor = System.Drawing.Color.SandyBrown;
            this.clearFieldsBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.clearFieldsBtn.ForeColor = System.Drawing.Color.White;
            this.clearFieldsBtn.HoverState.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.Location = new System.Drawing.Point(208, 0);
            this.clearFieldsBtn.Name = "clearFieldsBtn";
            this.clearFieldsBtn.ShadowDecoration.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.Size = new System.Drawing.Size(113, 32);
            this.clearFieldsBtn.TabIndex = 6;
            this.clearFieldsBtn.Text = "Clear fields";
            this.clearFieldsBtn.Click += new System.EventHandler(this.clearFieldsBtn_Click);
            // 
            // saveProductBtn
            // 
            this.saveProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveProductBtn.Animated = true;
            this.saveProductBtn.AutoRoundedCorners = true;
            this.saveProductBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveProductBtn.BorderRadius = 17;
            this.saveProductBtn.CheckedState.Parent = this.saveProductBtn;
            this.saveProductBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveProductBtn.CustomImages.Parent = this.saveProductBtn;
            this.saveProductBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveProductBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveProductBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveProductBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveProductBtn.DisabledState.Parent = this.saveProductBtn;
            this.saveProductBtn.FillColor = System.Drawing.Color.LimeGreen;
            this.saveProductBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.saveProductBtn.ForeColor = System.Drawing.Color.White;
            this.saveProductBtn.HoverState.Parent = this.saveProductBtn;
            this.saveProductBtn.Location = new System.Drawing.Point(90, 414);
            this.saveProductBtn.Name = "saveProductBtn";
            this.saveProductBtn.ShadowDecoration.Parent = this.saveProductBtn;
            this.saveProductBtn.Size = new System.Drawing.Size(141, 37);
            this.saveProductBtn.TabIndex = 6;
            this.saveProductBtn.Text = "Save product";
            this.saveProductBtn.Click += new System.EventHandler(this.saveProductBtn_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox2.Controls.Add(this.photoInput);
            this.guna2GroupBox2.Controls.Add(this.choosePhotoBtn);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.AntiqueWhite;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(13, 245);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(295, 153);
            this.guna2GroupBox2.TabIndex = 4;
            // 
            // photoInput
            // 
            this.photoInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.photoInput.BackColor = System.Drawing.Color.FloralWhite;
            this.photoInput.Image = global::StoreMan.Properties.Resources.sampleProduct;
            this.photoInput.Location = new System.Drawing.Point(8, 21);
            this.photoInput.Name = "photoInput";
            this.photoInput.Size = new System.Drawing.Size(145, 124);
            this.photoInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoInput.TabIndex = 2;
            this.photoInput.TabStop = false;
            // 
            // choosePhotoBtn
            // 
            this.choosePhotoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choosePhotoBtn.Animated = true;
            this.choosePhotoBtn.AutoRoundedCorners = true;
            this.choosePhotoBtn.BackColor = System.Drawing.Color.Transparent;
            this.choosePhotoBtn.BorderRadius = 18;
            this.choosePhotoBtn.CheckedState.Parent = this.choosePhotoBtn;
            this.choosePhotoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.choosePhotoBtn.CustomImages.Parent = this.choosePhotoBtn;
            this.choosePhotoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.choosePhotoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.choosePhotoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.choosePhotoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.choosePhotoBtn.DisabledState.Parent = this.choosePhotoBtn;
            this.choosePhotoBtn.FillColor = System.Drawing.Color.NavajoWhite;
            this.choosePhotoBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.choosePhotoBtn.ForeColor = System.Drawing.Color.Black;
            this.choosePhotoBtn.HoverState.Parent = this.choosePhotoBtn;
            this.choosePhotoBtn.Location = new System.Drawing.Point(166, 64);
            this.choosePhotoBtn.Name = "choosePhotoBtn";
            this.choosePhotoBtn.ShadowDecoration.Parent = this.choosePhotoBtn;
            this.choosePhotoBtn.Size = new System.Drawing.Size(114, 39);
            this.choosePhotoBtn.TabIndex = 5;
            this.choosePhotoBtn.Text = "Choose photo";
            this.choosePhotoBtn.Click += new System.EventHandler(this.choosePhotoBtn_Click);
            // 
            // bppuInput
            // 
            this.bppuInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bppuInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bppuInput.DefaultText = "";
            this.bppuInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bppuInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bppuInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bppuInput.DisabledState.Parent = this.bppuInput;
            this.bppuInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bppuInput.FocusedState.BorderColor = System.Drawing.Color.Orange;
            this.bppuInput.FocusedState.Parent = this.bppuInput;
            this.bppuInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bppuInput.ForeColor = System.Drawing.Color.Black;
            this.bppuInput.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.bppuInput.HoverState.Parent = this.bppuInput;
            this.bppuInput.Location = new System.Drawing.Point(13, 165);
            this.bppuInput.Name = "bppuInput";
            this.bppuInput.PasswordChar = '\0';
            this.bppuInput.PlaceholderText = "Buy price per unit";
            this.bppuInput.SelectedText = "";
            this.bppuInput.ShadowDecoration.Parent = this.bppuInput;
            this.bppuInput.Size = new System.Drawing.Size(295, 34);
            this.bppuInput.TabIndex = 3;
            // 
            // quantityInput
            // 
            this.quantityInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityInput.DefaultText = "";
            this.quantityInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityInput.DisabledState.Parent = this.quantityInput;
            this.quantityInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityInput.FocusedState.BorderColor = System.Drawing.Color.Orange;
            this.quantityInput.FocusedState.Parent = this.quantityInput;
            this.quantityInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantityInput.ForeColor = System.Drawing.Color.Black;
            this.quantityInput.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.quantityInput.HoverState.Parent = this.quantityInput;
            this.quantityInput.Location = new System.Drawing.Point(13, 126);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.PasswordChar = '\0';
            this.quantityInput.PlaceholderText = "Product quantity";
            this.quantityInput.SelectedText = "";
            this.quantityInput.ShadowDecoration.Parent = this.quantityInput;
            this.quantityInput.Size = new System.Drawing.Size(295, 34);
            this.quantityInput.TabIndex = 2;
            // 
            // pNameInput
            // 
            this.pNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pNameInput.DefaultText = "";
            this.pNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pNameInput.DisabledState.Parent = this.pNameInput;
            this.pNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pNameInput.FocusedState.BorderColor = System.Drawing.Color.Orange;
            this.pNameInput.FocusedState.Parent = this.pNameInput;
            this.pNameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pNameInput.ForeColor = System.Drawing.Color.Black;
            this.pNameInput.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.pNameInput.HoverState.Parent = this.pNameInput;
            this.pNameInput.Location = new System.Drawing.Point(13, 87);
            this.pNameInput.Name = "pNameInput";
            this.pNameInput.PasswordChar = '\0';
            this.pNameInput.PlaceholderText = "Product name";
            this.pNameInput.SelectedText = "";
            this.pNameInput.ShadowDecoration.Parent = this.pNameInput;
            this.pNameInput.Size = new System.Drawing.Size(295, 34);
            this.pNameInput.TabIndex = 1;
            // 
            // pCodeInput
            // 
            this.pCodeInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pCodeInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pCodeInput.DefaultText = "";
            this.pCodeInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pCodeInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pCodeInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pCodeInput.DisabledState.Parent = this.pCodeInput;
            this.pCodeInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pCodeInput.FocusedState.BorderColor = System.Drawing.Color.Orange;
            this.pCodeInput.FocusedState.Parent = this.pCodeInput;
            this.pCodeInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pCodeInput.ForeColor = System.Drawing.Color.Black;
            this.pCodeInput.HoverState.BorderColor = System.Drawing.Color.Orange;
            this.pCodeInput.HoverState.Parent = this.pCodeInput;
            this.pCodeInput.Location = new System.Drawing.Point(13, 48);
            this.pCodeInput.Name = "pCodeInput";
            this.pCodeInput.PasswordChar = '\0';
            this.pCodeInput.PlaceholderText = "Product code";
            this.pCodeInput.SelectedText = "";
            this.pCodeInput.ShadowDecoration.Parent = this.pCodeInput;
            this.pCodeInput.Size = new System.Drawing.Size(295, 34);
            this.pCodeInput.TabIndex = 0;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.PaleGreen;
            this.guna2GroupBox3.Controls.Add(this.searchByQtyInput);
            this.guna2GroupBox3.Controls.Add(this.searchInput);
            this.guna2GroupBox3.Controls.Add(this.inventoryView);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.PaleGreen;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Green;
            this.guna2GroupBox3.Location = new System.Drawing.Point(335, 8);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Padding = new System.Windows.Forms.Padding(3);
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(652, 426);
            this.guna2GroupBox3.TabIndex = 3;
            this.guna2GroupBox3.Text = "INVENTORY DATA";
            // 
            // searchByQtyInput
            // 
            this.searchByQtyInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByQtyInput.BackColor = System.Drawing.Color.Transparent;
            this.searchByQtyInput.BorderColor = System.Drawing.Color.DarkGray;
            this.searchByQtyInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchByQtyInput.DefaultText = "";
            this.searchByQtyInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchByQtyInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchByQtyInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchByQtyInput.DisabledState.Parent = this.searchByQtyInput;
            this.searchByQtyInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchByQtyInput.FillColor = System.Drawing.Color.LavenderBlush;
            this.searchByQtyInput.FocusedState.BorderColor = System.Drawing.Color.DeepPink;
            this.searchByQtyInput.FocusedState.Parent = this.searchByQtyInput;
            this.searchByQtyInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchByQtyInput.ForeColor = System.Drawing.Color.Black;
            this.searchByQtyInput.HoverState.BorderColor = System.Drawing.Color.DeepPink;
            this.searchByQtyInput.HoverState.Parent = this.searchByQtyInput;
            this.searchByQtyInput.Location = new System.Drawing.Point(309, 384);
            this.searchByQtyInput.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.searchByQtyInput.Name = "searchByQtyInput";
            this.searchByQtyInput.PasswordChar = '\0';
            this.searchByQtyInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.searchByQtyInput.PlaceholderText = "Enter a quantity to search products of that quantity or less";
            this.searchByQtyInput.SelectedText = "";
            this.searchByQtyInput.ShadowDecoration.Parent = this.searchByQtyInput;
            this.searchByQtyInput.Size = new System.Drawing.Size(337, 36);
            this.searchByQtyInput.TabIndex = 2;
            this.searchByQtyInput.TextChanged += new System.EventHandler(this.searchByQtyInput_TextChanged);
            // 
            // searchInput
            // 
            this.searchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchInput.BackColor = System.Drawing.Color.Transparent;
            this.searchInput.BorderColor = System.Drawing.Color.DarkGray;
            this.searchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInput.DefaultText = "";
            this.searchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchInput.DisabledState.Parent = this.searchInput;
            this.searchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchInput.FillColor = System.Drawing.Color.Honeydew;
            this.searchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.searchInput.FocusedState.Parent = this.searchInput;
            this.searchInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchInput.ForeColor = System.Drawing.Color.Black;
            this.searchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.searchInput.HoverState.Parent = this.searchInput;
            this.searchInput.Location = new System.Drawing.Point(6, 384);
            this.searchInput.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.searchInput.PlaceholderText = "Search products using product code or name";
            this.searchInput.SelectedText = "";
            this.searchInput.ShadowDecoration.Parent = this.searchInput;
            this.searchInput.Size = new System.Drawing.Size(297, 36);
            this.searchInput.TabIndex = 1;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // inventoryView
            // 
            this.inventoryView.AllowUserToAddRows = false;
            this.inventoryView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.inventoryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inventoryView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryView.BackgroundColor = System.Drawing.Color.White;
            this.inventoryView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventoryView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inventoryView.ColumnHeadersHeight = 54;
            this.inventoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pId,
            this.photo,
            this.pCode,
            this.pName,
            this.quantity,
            this.bppu,
            this.sppu,
            this.dateAdded});
            this.inventoryView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryView.DefaultCellStyle = dataGridViewCellStyle3;
            this.inventoryView.EnableHeadersVisualStyles = false;
            this.inventoryView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.inventoryView.Location = new System.Drawing.Point(6, 45);
            this.inventoryView.Margin = new System.Windows.Forms.Padding(0);
            this.inventoryView.Name = "inventoryView";
            this.inventoryView.ReadOnly = true;
            this.inventoryView.RowHeadersVisible = false;
            this.inventoryView.RowTemplate.Height = 70;
            this.inventoryView.RowTemplate.ReadOnly = true;
            this.inventoryView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.inventoryView.ShowCellErrors = false;
            this.inventoryView.ShowCellToolTips = false;
            this.inventoryView.ShowEditingIcon = false;
            this.inventoryView.Size = new System.Drawing.Size(640, 331);
            this.inventoryView.TabIndex = 0;
            this.inventoryView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.inventoryView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.inventoryView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.inventoryView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.inventoryView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.inventoryView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.inventoryView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.inventoryView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.inventoryView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.inventoryView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.inventoryView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inventoryView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.inventoryView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.inventoryView.ThemeStyle.HeaderStyle.Height = 54;
            this.inventoryView.ThemeStyle.ReadOnly = true;
            this.inventoryView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.inventoryView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.inventoryView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inventoryView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.inventoryView.ThemeStyle.RowsStyle.Height = 70;
            this.inventoryView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.inventoryView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.inventoryView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryView_CellDoubleClick);
            // 
            // notiBar
            // 
            this.notiBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notiBar.BackColor = System.Drawing.Color.NavajoWhite;
            this.notiBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notiBar.Location = new System.Drawing.Point(335, 437);
            this.notiBar.Name = "notiBar";
            this.notiBar.Size = new System.Drawing.Size(652, 35);
            this.notiBar.TabIndex = 4;
            this.notiBar.Text = "No new notifications!";
            this.notiBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pId
            // 
            this.pId.DataPropertyName = "pId";
            this.pId.HeaderText = "Product ID";
            this.pId.Name = "pId";
            this.pId.ReadOnly = true;
            this.pId.Visible = false;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "photo";
            this.photo.HeaderText = "Photo";
            this.photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            // 
            // pCode
            // 
            this.pCode.DataPropertyName = "pCode";
            this.pCode.HeaderText = "Product code";
            this.pCode.Name = "pCode";
            this.pCode.ReadOnly = true;
            // 
            // pName
            // 
            this.pName.DataPropertyName = "pName";
            this.pName.HeaderText = "Product name";
            this.pName.Name = "pName";
            this.pName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Available quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // bppu
            // 
            this.bppu.DataPropertyName = "bppu";
            this.bppu.HeaderText = "Buy price/unit";
            this.bppu.Name = "bppu";
            this.bppu.ReadOnly = true;
            // 
            // sppu
            // 
            this.sppu.DataPropertyName = "sppu";
            this.sppu.HeaderText = "Sale price/unit";
            this.sppu.Name = "sppu";
            this.sppu.ReadOnly = true;
            // 
            // dateAdded
            // 
            this.dateAdded.DataPropertyName = "dateAdded";
            this.dateAdded.HeaderText = "Date added";
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.ReadOnly = true;
            // 
            // TabInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.notiBar);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "TabInventory";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(995, 480);
            this.Load += new System.EventHandler(this.InventoryTab_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoInput)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button saveProductBtn;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.PictureBox photoInput;
        private Guna.UI2.WinForms.Guna2Button choosePhotoBtn;
        private Guna.UI2.WinForms.Guna2TextBox bppuInput;
        private Guna.UI2.WinForms.Guna2TextBox quantityInput;
        private Guna.UI2.WinForms.Guna2TextBox pNameInput;
        private Guna.UI2.WinForms.Guna2TextBox pCodeInput;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2DataGridView inventoryView;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI2.WinForms.Guna2Button clearFieldsBtn;
        private System.Windows.Forms.Label notiBar;
        private Guna.UI2.WinForms.Guna2TextBox sppuInput;
        private Guna.UI2.WinForms.Guna2TextBox searchByQtyInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn pId;
        private System.Windows.Forms.DataGridViewImageColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn bppu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sppu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
    }
}
