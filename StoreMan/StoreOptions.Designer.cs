
namespace StoreMan
{
    partial class StoreOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreOptions));
            this.optionViewPanel = new System.Windows.Forms.Panel();
            this.deleteStoreBtn = new Guna.UI2.WinForms.Guna2Button();
            this.desLabel = new System.Windows.Forms.Label();
            this.storeMenuBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.batchSaleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.adminOptionsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.salesReportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.inventoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.storeMenuBox.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionViewPanel
            // 
            this.optionViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.optionViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionViewPanel.Location = new System.Drawing.Point(5, 147);
            this.optionViewPanel.Name = "optionViewPanel";
            this.optionViewPanel.Size = new System.Drawing.Size(1074, 479);
            this.optionViewPanel.TabIndex = 9;
            // 
            // deleteStoreBtn
            // 
            this.deleteStoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteStoreBtn.Animated = true;
            this.deleteStoreBtn.CheckedState.Parent = this.deleteStoreBtn;
            this.deleteStoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteStoreBtn.CustomImages.Parent = this.deleteStoreBtn;
            this.deleteStoreBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteStoreBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteStoreBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteStoreBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteStoreBtn.DisabledState.Parent = this.deleteStoreBtn;
            this.deleteStoreBtn.FillColor = System.Drawing.Color.Tomato;
            this.deleteStoreBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteStoreBtn.ForeColor = System.Drawing.Color.White;
            this.deleteStoreBtn.HoverState.Parent = this.deleteStoreBtn;
            this.deleteStoreBtn.Location = new System.Drawing.Point(474, 0);
            this.deleteStoreBtn.Name = "deleteStoreBtn";
            this.deleteStoreBtn.ShadowDecoration.Parent = this.deleteStoreBtn;
            this.deleteStoreBtn.Size = new System.Drawing.Size(117, 32);
            this.deleteStoreBtn.TabIndex = 6;
            this.deleteStoreBtn.Text = "Delete store";
            this.deleteStoreBtn.Click += new System.EventHandler(this.deleteStoreBtn_Click);
            // 
            // desLabel
            // 
            this.desLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desLabel.BackColor = System.Drawing.Color.Transparent;
            this.desLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.desLabel.Location = new System.Drawing.Point(3, 43);
            this.desLabel.Name = "desLabel";
            this.desLabel.Padding = new System.Windows.Forms.Padding(3);
            this.desLabel.Size = new System.Drawing.Size(585, 31);
            this.desLabel.TabIndex = 1;
            this.desLabel.Text = "Store description";
            this.desLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storeMenuBox
            // 
            this.storeMenuBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeMenuBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.storeMenuBox.Controls.Add(this.deleteStoreBtn);
            this.storeMenuBox.Controls.Add(this.desLabel);
            this.storeMenuBox.Controls.Add(this.batchSaleBtn);
            this.storeMenuBox.Controls.Add(this.guna2Separator1);
            this.storeMenuBox.Controls.Add(this.adminOptionsBtn);
            this.storeMenuBox.Controls.Add(this.salesReportBtn);
            this.storeMenuBox.Controls.Add(this.inventoryBtn);
            this.storeMenuBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.storeMenuBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.storeMenuBox.ForeColor = System.Drawing.Color.Black;
            this.storeMenuBox.Location = new System.Drawing.Point(5, 8);
            this.storeMenuBox.Name = "storeMenuBox";
            this.storeMenuBox.ShadowDecoration.Parent = this.storeMenuBox;
            this.storeMenuBox.Size = new System.Drawing.Size(591, 133);
            this.storeMenuBox.TabIndex = 9;
            this.storeMenuBox.Text = "Store title";
            this.storeMenuBox.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // batchSaleBtn
            // 
            this.batchSaleBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.batchSaleBtn.Animated = true;
            this.batchSaleBtn.BackColor = System.Drawing.Color.Transparent;
            this.batchSaleBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.batchSaleBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.batchSaleBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.batchSaleBtn.CheckedState.ForeColor = System.Drawing.Color.Tomato;
            this.batchSaleBtn.CheckedState.Parent = this.batchSaleBtn;
            this.batchSaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batchSaleBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.batchSaleBtn.CustomImages.Parent = this.batchSaleBtn;
            this.batchSaleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.batchSaleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.batchSaleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.batchSaleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.batchSaleBtn.DisabledState.Parent = this.batchSaleBtn;
            this.batchSaleBtn.FillColor = System.Drawing.Color.Transparent;
            this.batchSaleBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.batchSaleBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchSaleBtn.ForeColor = System.Drawing.Color.Gray;
            this.batchSaleBtn.HoverState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.batchSaleBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.batchSaleBtn.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.batchSaleBtn.HoverState.Parent = this.batchSaleBtn;
            this.batchSaleBtn.IndicateFocus = true;
            this.batchSaleBtn.Location = new System.Drawing.Point(158, 88);
            this.batchSaleBtn.Margin = new System.Windows.Forms.Padding(0);
            this.batchSaleBtn.Name = "batchSaleBtn";
            this.batchSaleBtn.PressedColor = System.Drawing.Color.Transparent;
            this.batchSaleBtn.ShadowDecoration.Parent = this.batchSaleBtn;
            this.batchSaleBtn.Size = new System.Drawing.Size(120, 41);
            this.batchSaleBtn.TabIndex = 7;
            this.batchSaleBtn.Text = "Batch sale";
            this.batchSaleBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.batchSaleBtn.Click += new System.EventHandler(this.batchSaleBtn_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Location = new System.Drawing.Point(3, 77);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(585, 11);
            this.guna2Separator1.TabIndex = 5;
            // 
            // adminOptionsBtn
            // 
            this.adminOptionsBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.adminOptionsBtn.Animated = true;
            this.adminOptionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.adminOptionsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.adminOptionsBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.adminOptionsBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.adminOptionsBtn.CheckedState.ForeColor = System.Drawing.Color.Tomato;
            this.adminOptionsBtn.CheckedState.Parent = this.adminOptionsBtn;
            this.adminOptionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminOptionsBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.adminOptionsBtn.CustomImages.Parent = this.adminOptionsBtn;
            this.adminOptionsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminOptionsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminOptionsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminOptionsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminOptionsBtn.DisabledState.Parent = this.adminOptionsBtn;
            this.adminOptionsBtn.FillColor = System.Drawing.Color.Transparent;
            this.adminOptionsBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.adminOptionsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminOptionsBtn.ForeColor = System.Drawing.Color.Gray;
            this.adminOptionsBtn.HoverState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.adminOptionsBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.adminOptionsBtn.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.adminOptionsBtn.HoverState.Parent = this.adminOptionsBtn;
            this.adminOptionsBtn.IndicateFocus = true;
            this.adminOptionsBtn.Location = new System.Drawing.Point(407, 88);
            this.adminOptionsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.adminOptionsBtn.Name = "adminOptionsBtn";
            this.adminOptionsBtn.PressedColor = System.Drawing.Color.Transparent;
            this.adminOptionsBtn.ShadowDecoration.Parent = this.adminOptionsBtn;
            this.adminOptionsBtn.Size = new System.Drawing.Size(149, 41);
            this.adminOptionsBtn.TabIndex = 4;
            this.adminOptionsBtn.Text = "Admin options";
            this.adminOptionsBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.adminOptionsBtn.Click += new System.EventHandler(this.adminOptionsBtn_Click);
            // 
            // salesReportBtn
            // 
            this.salesReportBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.salesReportBtn.Animated = true;
            this.salesReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.salesReportBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.salesReportBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.salesReportBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.salesReportBtn.CheckedState.ForeColor = System.Drawing.Color.Tomato;
            this.salesReportBtn.CheckedState.Parent = this.salesReportBtn;
            this.salesReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesReportBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.salesReportBtn.CustomImages.Parent = this.salesReportBtn;
            this.salesReportBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salesReportBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salesReportBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salesReportBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salesReportBtn.DisabledState.Parent = this.salesReportBtn;
            this.salesReportBtn.FillColor = System.Drawing.Color.Transparent;
            this.salesReportBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.salesReportBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesReportBtn.ForeColor = System.Drawing.Color.Gray;
            this.salesReportBtn.HoverState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.salesReportBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.salesReportBtn.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.salesReportBtn.HoverState.Parent = this.salesReportBtn;
            this.salesReportBtn.IndicateFocus = true;
            this.salesReportBtn.Location = new System.Drawing.Point(278, 88);
            this.salesReportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.salesReportBtn.Name = "salesReportBtn";
            this.salesReportBtn.PressedColor = System.Drawing.Color.Transparent;
            this.salesReportBtn.ShadowDecoration.Parent = this.salesReportBtn;
            this.salesReportBtn.Size = new System.Drawing.Size(129, 41);
            this.salesReportBtn.TabIndex = 3;
            this.salesReportBtn.Text = "Sales Report";
            this.salesReportBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.salesReportBtn.Click += new System.EventHandler(this.salesReportBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.inventoryBtn.Animated = true;
            this.inventoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.inventoryBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.inventoryBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.CheckedState.ForeColor = System.Drawing.Color.Tomato;
            this.inventoryBtn.CheckedState.Parent = this.inventoryBtn;
            this.inventoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventoryBtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.inventoryBtn.CustomImages.Parent = this.inventoryBtn;
            this.inventoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.inventoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.inventoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.inventoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.inventoryBtn.DisabledState.Parent = this.inventoryBtn;
            this.inventoryBtn.FillColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.Gray;
            this.inventoryBtn.HoverState.CustomBorderColor = System.Drawing.Color.Tomato;
            this.inventoryBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.HoverState.ForeColor = System.Drawing.Color.Tomato;
            this.inventoryBtn.HoverState.Parent = this.inventoryBtn;
            this.inventoryBtn.IndicateFocus = true;
            this.inventoryBtn.Location = new System.Drawing.Point(34, 88);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(0);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.PressedColor = System.Drawing.Color.Transparent;
            this.inventoryBtn.ShadowDecoration.Parent = this.inventoryBtn;
            this.inventoryBtn.Size = new System.Drawing.Size(124, 41);
            this.inventoryBtn.TabIndex = 2;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkOrange;
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkOrange;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(602, 8);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Padding = new System.Windows.Forms.Padding(3);
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(477, 133);
            this.guna2GroupBox1.TabIndex = 10;
            this.guna2GroupBox1.Text = "Some tips";
            this.guna2GroupBox1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "* Double click on any column in Sales Report tab to generate and print sale invoi" +
    "ce.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Use Batch Sale tab to sell multiple products and to view cart items.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(465, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Double click on any product column except photo in Inventory to add it in cart." +
    "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Double click on any product photo in Inventory to edit its stock and other data" +
    ".";
            // 
            // StoreOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 631);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.storeMenuBox);
            this.Controls.Add(this.optionViewPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 670);
            this.Name = "StoreOptions";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Options";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StoreOptions_Load);
            this.storeMenuBox.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel optionViewPanel;
        private Guna.UI2.WinForms.Guna2GroupBox storeMenuBox;
        private Guna.UI2.WinForms.Guna2Button deleteStoreBtn;
        private System.Windows.Forms.Label desLabel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button adminOptionsBtn;
        private Guna.UI2.WinForms.Guna2Button salesReportBtn;
        private Guna.UI2.WinForms.Guna2Button inventoryBtn;
        private Guna.UI2.WinForms.Guna2Button batchSaleBtn;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}