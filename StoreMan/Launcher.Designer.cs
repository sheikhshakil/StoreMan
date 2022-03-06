
namespace StoreMan
{
    partial class Launcher
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.getStartedBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.clearFieldsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.storeAddrInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.storeDesInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.storeNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.createStoreBtn = new Guna.UI2.WinForms.Guna2Button();
            this.storesListBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.storesLayout = new System.Windows.Forms.Panel();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.descLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.activationInfoPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.activateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.activationInfo = new System.Windows.Forms.Label();
            this.activationIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.getStartedBox.SuspendLayout();
            this.storesListBox.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.activationInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activationIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // getStartedBox
            // 
            this.getStartedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.getStartedBox.BorderColor = System.Drawing.Color.NavajoWhite;
            this.getStartedBox.Controls.Add(this.clearFieldsBtn);
            this.getStartedBox.Controls.Add(this.storeAddrInput);
            this.getStartedBox.Controls.Add(this.storeDesInput);
            this.getStartedBox.Controls.Add(this.storeNameInput);
            this.getStartedBox.Controls.Add(this.createStoreBtn);
            this.getStartedBox.CustomBorderColor = System.Drawing.Color.NavajoWhite;
            this.getStartedBox.FillColor = System.Drawing.Color.OldLace;
            this.getStartedBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStartedBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.getStartedBox.Location = new System.Drawing.Point(12, 145);
            this.getStartedBox.Name = "getStartedBox";
            this.getStartedBox.Padding = new System.Windows.Forms.Padding(10);
            this.getStartedBox.ShadowDecoration.Parent = this.getStartedBox;
            this.getStartedBox.Size = new System.Drawing.Size(497, 257);
            this.getStartedBox.TabIndex = 6;
            this.getStartedBox.Text = "Get Started here";
            this.getStartedBox.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // clearFieldsBtn
            // 
            this.clearFieldsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearFieldsBtn.CheckedState.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFieldsBtn.CustomImages.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearFieldsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearFieldsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearFieldsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearFieldsBtn.DisabledState.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.FillColor = System.Drawing.Color.SandyBrown;
            this.clearFieldsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearFieldsBtn.ForeColor = System.Drawing.Color.White;
            this.clearFieldsBtn.HoverState.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.Location = new System.Drawing.Point(372, 0);
            this.clearFieldsBtn.Name = "clearFieldsBtn";
            this.clearFieldsBtn.ShadowDecoration.Parent = this.clearFieldsBtn;
            this.clearFieldsBtn.Size = new System.Drawing.Size(125, 32);
            this.clearFieldsBtn.TabIndex = 4;
            this.clearFieldsBtn.Text = "Clear fields";
            this.clearFieldsBtn.Click += new System.EventHandler(this.clearFieldsBtn_Click);
            // 
            // storeAddrInput
            // 
            this.storeAddrInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeAddrInput.Animated = true;
            this.storeAddrInput.BorderColor = System.Drawing.Color.Silver;
            this.storeAddrInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.storeAddrInput.DefaultText = "";
            this.storeAddrInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.storeAddrInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.storeAddrInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.storeAddrInput.DisabledState.Parent = this.storeAddrInput;
            this.storeAddrInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.storeAddrInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.storeAddrInput.FocusedState.Parent = this.storeAddrInput;
            this.storeAddrInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.storeAddrInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.storeAddrInput.HoverState.Parent = this.storeAddrInput;
            this.storeAddrInput.Location = new System.Drawing.Point(13, 144);
            this.storeAddrInput.Name = "storeAddrInput";
            this.storeAddrInput.PasswordChar = '\0';
            this.storeAddrInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.storeAddrInput.PlaceholderText = "Enter store address or contact number";
            this.storeAddrInput.SelectedText = "";
            this.storeAddrInput.ShadowDecoration.Parent = this.storeAddrInput;
            this.storeAddrInput.Size = new System.Drawing.Size(471, 40);
            this.storeAddrInput.TabIndex = 3;
            // 
            // storeDesInput
            // 
            this.storeDesInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeDesInput.Animated = true;
            this.storeDesInput.BorderColor = System.Drawing.Color.Silver;
            this.storeDesInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.storeDesInput.DefaultText = "";
            this.storeDesInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.storeDesInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.storeDesInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.storeDesInput.DisabledState.Parent = this.storeDesInput;
            this.storeDesInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.storeDesInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.storeDesInput.FocusedState.Parent = this.storeDesInput;
            this.storeDesInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.storeDesInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.storeDesInput.HoverState.Parent = this.storeDesInput;
            this.storeDesInput.Location = new System.Drawing.Point(13, 98);
            this.storeDesInput.Name = "storeDesInput";
            this.storeDesInput.PasswordChar = '\0';
            this.storeDesInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.storeDesInput.PlaceholderText = "Enter store description | e.g. Pharmacy, Departmental store etc.";
            this.storeDesInput.SelectedText = "";
            this.storeDesInput.ShadowDecoration.Parent = this.storeDesInput;
            this.storeDesInput.Size = new System.Drawing.Size(471, 40);
            this.storeDesInput.TabIndex = 2;
            // 
            // storeNameInput
            // 
            this.storeNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeNameInput.Animated = true;
            this.storeNameInput.BorderColor = System.Drawing.Color.Silver;
            this.storeNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.storeNameInput.DefaultText = "";
            this.storeNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.storeNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.storeNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.storeNameInput.DisabledState.Parent = this.storeNameInput;
            this.storeNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.storeNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.storeNameInput.FocusedState.Parent = this.storeNameInput;
            this.storeNameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.storeNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.storeNameInput.HoverState.Parent = this.storeNameInput;
            this.storeNameInput.Location = new System.Drawing.Point(13, 52);
            this.storeNameInput.Name = "storeNameInput";
            this.storeNameInput.PasswordChar = '\0';
            this.storeNameInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.storeNameInput.PlaceholderText = "Enter store name";
            this.storeNameInput.SelectedText = "";
            this.storeNameInput.ShadowDecoration.Parent = this.storeNameInput;
            this.storeNameInput.Size = new System.Drawing.Size(471, 40);
            this.storeNameInput.TabIndex = 1;
            // 
            // createStoreBtn
            // 
            this.createStoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createStoreBtn.Animated = true;
            this.createStoreBtn.AutoRoundedCorners = true;
            this.createStoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.createStoreBtn.BorderRadius = 20;
            this.createStoreBtn.CheckedState.Parent = this.createStoreBtn;
            this.createStoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createStoreBtn.CustomImages.Parent = this.createStoreBtn;
            this.createStoreBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createStoreBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createStoreBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createStoreBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createStoreBtn.DisabledState.Parent = this.createStoreBtn;
            this.createStoreBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.createStoreBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.createStoreBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.createStoreBtn.HoverState.Parent = this.createStoreBtn;
            this.createStoreBtn.Location = new System.Drawing.Point(146, 201);
            this.createStoreBtn.Name = "createStoreBtn";
            this.createStoreBtn.ShadowDecoration.Parent = this.createStoreBtn;
            this.createStoreBtn.Size = new System.Drawing.Size(205, 43);
            this.createStoreBtn.TabIndex = 0;
            this.createStoreBtn.Text = "Create Store";
            this.createStoreBtn.Click += new System.EventHandler(this.createStoreBtn_Click);
            // 
            // storesListBox
            // 
            this.storesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storesListBox.BorderColor = System.Drawing.Color.LightGreen;
            this.storesListBox.Controls.Add(this.storesLayout);
            this.storesListBox.CustomBorderColor = System.Drawing.Color.LightGreen;
            this.storesListBox.FillColor = System.Drawing.Color.Honeydew;
            this.storesListBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.storesListBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.storesListBox.Location = new System.Drawing.Point(515, 145);
            this.storesListBox.Name = "storesListBox";
            this.storesListBox.Padding = new System.Windows.Forms.Padding(10);
            this.storesListBox.ShadowDecoration.Parent = this.storesListBox;
            this.storesListBox.Size = new System.Drawing.Size(482, 416);
            this.storesListBox.TabIndex = 7;
            this.storesListBox.Text = "Store List";
            this.storesListBox.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // storesLayout
            // 
            this.storesLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storesLayout.AutoScroll = true;
            this.storesLayout.BackColor = System.Drawing.Color.Transparent;
            this.storesLayout.Location = new System.Drawing.Point(13, 52);
            this.storesLayout.Name = "storesLayout";
            this.storesLayout.Size = new System.Drawing.Size(456, 351);
            this.storesLayout.TabIndex = 1;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Controls.Add(this.label1);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.FillColor = System.Drawing.Color.GhostWhite;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(12, 408);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Padding = new System.Windows.Forms.Padding(10);
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(497, 153);
            this.guna2GroupBox3.TabIndex = 8;
            this.guna2GroupBox3.Text = "About this app";
            this.guna2GroupBox3.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(471, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "StoreMan is a Store Management Application developed by TerminalCat.\r\n\r\nVersion :" +
    " 2.1.0.1\r\nDeveloper contact : sheikhshakil.service@gmail.com";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.descLabel);
            this.guna2GradientPanel1.Controls.Add(this.titleLabel);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Fuchsia;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1009, 139);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // descLabel
            // 
            this.descLabel.BackColor = System.Drawing.Color.Transparent;
            this.descLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.White;
            this.descLabel.Location = new System.Drawing.Point(0, 80);
            this.descLabel.Name = "descLabel";
            this.descLabel.Padding = new System.Windows.Forms.Padding(25, 5, 5, 5);
            this.descLabel.Size = new System.Drawing.Size(1009, 38);
            this.descLabel.TabIndex = 6;
            this.descLabel.Text = "Your One Stop Store Manager";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Leelawadee UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Aqua;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(1009, 80);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "StoreMan";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activationInfoPanel
            // 
            this.activationInfoPanel.Controls.Add(this.activateBtn);
            this.activationInfoPanel.Controls.Add(this.activationInfo);
            this.activationInfoPanel.Controls.Add(this.activationIcon);
            this.activationInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activationInfoPanel.FillColor = System.Drawing.Color.DodgerBlue;
            this.activationInfoPanel.FillColor2 = System.Drawing.Color.Fuchsia;
            this.activationInfoPanel.Location = new System.Drawing.Point(0, 567);
            this.activationInfoPanel.Name = "activationInfoPanel";
            this.activationInfoPanel.ShadowDecoration.Parent = this.activationInfoPanel;
            this.activationInfoPanel.Size = new System.Drawing.Size(1009, 84);
            this.activationInfoPanel.TabIndex = 10;
            // 
            // activateBtn
            // 
            this.activateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activateBtn.Animated = true;
            this.activateBtn.AutoRoundedCorners = true;
            this.activateBtn.BackColor = System.Drawing.Color.Transparent;
            this.activateBtn.BorderRadius = 21;
            this.activateBtn.CheckedState.Parent = this.activateBtn;
            this.activateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateBtn.CustomImages.Parent = this.activateBtn;
            this.activateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.activateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.activateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.activateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.activateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.activateBtn.DisabledState.Parent = this.activateBtn;
            this.activateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.activateBtn.FillColor2 = System.Drawing.Color.Gold;
            this.activateBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.activateBtn.ForeColor = System.Drawing.Color.Black;
            this.activateBtn.HoverState.Parent = this.activateBtn;
            this.activateBtn.Location = new System.Drawing.Point(782, 20);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.ShadowDecoration.Parent = this.activateBtn;
            this.activateBtn.Size = new System.Drawing.Size(215, 45);
            this.activateBtn.TabIndex = 2;
            this.activateBtn.Text = "Activate";
            this.activateBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // activationInfo
            // 
            this.activationInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.activationInfo.BackColor = System.Drawing.Color.Transparent;
            this.activationInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationInfo.ForeColor = System.Drawing.Color.White;
            this.activationInfo.Location = new System.Drawing.Point(78, 12);
            this.activationInfo.Name = "activationInfo";
            this.activationInfo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.activationInfo.Size = new System.Drawing.Size(521, 60);
            this.activationInfo.TabIndex = 1;
            this.activationInfo.Text = "StoreMan is not activated";
            this.activationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // activationIcon
            // 
            this.activationIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.activationIcon.BackColor = System.Drawing.Color.Transparent;
            this.activationIcon.FillColor = System.Drawing.Color.Transparent;
            this.activationIcon.Image = global::StoreMan.Properties.Resources._lock;
            this.activationIcon.ImageRotate = 0F;
            this.activationIcon.Location = new System.Drawing.Point(12, 12);
            this.activationIcon.Name = "activationIcon";
            this.activationIcon.ShadowDecoration.Parent = this.activationIcon;
            this.activationIcon.Size = new System.Drawing.Size(60, 60);
            this.activationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.activationIcon.TabIndex = 0;
            this.activationIcon.TabStop = false;
            this.activationIcon.UseTransparentBackground = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 651);
            this.Controls.Add(this.activationInfoPanel);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.storesListBox);
            this.Controls.Add(this.getStartedBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1025, 690);
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreMan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.getStartedBox.ResumeLayout(false);
            this.storesListBox.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.activationInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activationIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox getStartedBox;
        private Guna.UI2.WinForms.Guna2GroupBox storesListBox;
        private System.Windows.Forms.Panel storesLayout;
        private Guna.UI2.WinForms.Guna2Button createStoreBtn;
        private Guna.UI2.WinForms.Guna2TextBox storeNameInput;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox storeAddrInput;
        private Guna.UI2.WinForms.Guna2TextBox storeDesInput;
        private Guna.UI2.WinForms.Guna2Button clearFieldsBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel activationInfoPanel;
        private Guna.UI2.WinForms.Guna2PictureBox activationIcon;
        private System.Windows.Forms.Label activationInfo;
        private Guna.UI2.WinForms.Guna2GradientButton activateBtn;
    }
}

