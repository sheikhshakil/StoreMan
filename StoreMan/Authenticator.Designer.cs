
namespace StoreMan
{
    partial class Authenticator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authenticator));
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.confirmBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.passwordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.infoText = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.confirmBtn);
            this.guna2GroupBox1.Controls.Add(this.passwordInput);
            this.guna2GroupBox1.Controls.Add(this.infoText);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Tomato;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(519, 286);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Admin consent";
            this.guna2GroupBox1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmBtn.Animated = true;
            this.confirmBtn.AutoRoundedCorners = true;
            this.confirmBtn.BackColor = System.Drawing.Color.Transparent;
            this.confirmBtn.BorderRadius = 21;
            this.confirmBtn.CheckedState.Parent = this.confirmBtn;
            this.confirmBtn.CustomImages.Parent = this.confirmBtn;
            this.confirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmBtn.DisabledState.Parent = this.confirmBtn;
            this.confirmBtn.FillColor = System.Drawing.Color.Tomato;
            this.confirmBtn.FillColor2 = System.Drawing.Color.Coral;
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.HoverState.Parent = this.confirmBtn;
            this.confirmBtn.Location = new System.Drawing.Point(169, 228);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.ShadowDecoration.Parent = this.confirmBtn;
            this.confirmBtn.Size = new System.Drawing.Size(181, 45);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordInput.Animated = true;
            this.passwordInput.BorderColor = System.Drawing.Color.Silver;
            this.passwordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordInput.DefaultText = "";
            this.passwordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.DisabledState.Parent = this.passwordInput;
            this.passwordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordInput.FocusedState.BorderColor = System.Drawing.Color.Tomato;
            this.passwordInput.FocusedState.Parent = this.passwordInput;
            this.passwordInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordInput.ForeColor = System.Drawing.Color.Black;
            this.passwordInput.HoverState.BorderColor = System.Drawing.Color.Tomato;
            this.passwordInput.HoverState.Parent = this.passwordInput;
            this.passwordInput.Location = new System.Drawing.Point(12, 157);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.passwordInput.PlaceholderText = "Admin password";
            this.passwordInput.SelectedText = "";
            this.passwordInput.ShadowDecoration.Parent = this.passwordInput;
            this.passwordInput.Size = new System.Drawing.Size(494, 44);
            this.passwordInput.TabIndex = 1;
            // 
            // infoText
            // 
            this.infoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoText.BackColor = System.Drawing.Color.Tomato;
            this.infoText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(13, 53);
            this.infoText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.infoText.Name = "infoText";
            this.infoText.Padding = new System.Windows.Forms.Padding(10);
            this.infoText.Size = new System.Drawing.Size(494, 91);
            this.infoText.TabIndex = 0;
            this.infoText.Text = "You are about to perform a risky task authorized to admin only.\r\nPlease enter adm" +
    "in password to ";
            this.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Authenticator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 286);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authenticator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authenticator";
            this.TopMost = true;
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GradientButton confirmBtn;
        private Guna.UI2.WinForms.Guna2TextBox passwordInput;
        private System.Windows.Forms.Label infoText;
    }
}