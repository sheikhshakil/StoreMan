
namespace StoreMan
{
    partial class PartProdListRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartProdListRow));
            this.quantityInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.pNameText = new System.Windows.Forms.Label();
            this.serialText = new System.Windows.Forms.Label();
            this.pCodeText = new System.Windows.Forms.Label();
            this.sppuText = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.deleteProdBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // quantityInput
            // 
            this.quantityInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quantityInput.BorderColor = System.Drawing.Color.Silver;
            this.quantityInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityInput.DefaultText = "";
            this.quantityInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityInput.DisabledState.Parent = this.quantityInput;
            this.quantityInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityInput.FocusedState.Parent = this.quantityInput;
            this.quantityInput.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantityInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityInput.HoverState.Parent = this.quantityInput;
            this.quantityInput.Location = new System.Drawing.Point(376, 8);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.PasswordChar = '\0';
            this.quantityInput.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.quantityInput.PlaceholderText = "Quantity";
            this.quantityInput.SelectedText = "";
            this.quantityInput.ShadowDecoration.Parent = this.quantityInput;
            this.quantityInput.Size = new System.Drawing.Size(98, 32);
            this.quantityInput.TabIndex = 0;
            // 
            // pNameText
            // 
            this.pNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pNameText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNameText.Location = new System.Drawing.Point(42, 8);
            this.pNameText.Margin = new System.Windows.Forms.Padding(3);
            this.pNameText.Name = "pNameText";
            this.pNameText.Padding = new System.Windows.Forms.Padding(3);
            this.pNameText.Size = new System.Drawing.Size(328, 32);
            this.pNameText.TabIndex = 1;
            this.pNameText.Text = "Product name";
            this.pNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serialText
            // 
            this.serialText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serialText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.serialText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialText.Location = new System.Drawing.Point(8, 8);
            this.serialText.Margin = new System.Windows.Forms.Padding(3);
            this.serialText.Name = "serialText";
            this.serialText.Padding = new System.Windows.Forms.Padding(3);
            this.serialText.Size = new System.Drawing.Size(28, 68);
            this.serialText.TabIndex = 2;
            this.serialText.Text = "0.";
            this.serialText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pCodeText
            // 
            this.pCodeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pCodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pCodeText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCodeText.Location = new System.Drawing.Point(42, 44);
            this.pCodeText.Margin = new System.Windows.Forms.Padding(3);
            this.pCodeText.Name = "pCodeText";
            this.pCodeText.Padding = new System.Windows.Forms.Padding(3);
            this.pCodeText.Size = new System.Drawing.Size(127, 32);
            this.pCodeText.TabIndex = 3;
            this.pCodeText.Text = "Product code";
            this.pCodeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sppuText
            // 
            this.sppuText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sppuText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sppuText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sppuText.Location = new System.Drawing.Point(173, 44);
            this.sppuText.Margin = new System.Windows.Forms.Padding(3);
            this.sppuText.Name = "sppuText";
            this.sppuText.Padding = new System.Windows.Forms.Padding(3);
            this.sppuText.Size = new System.Drawing.Size(197, 32);
            this.sppuText.TabIndex = 4;
            this.sppuText.Text = "SPPU";
            this.sppuText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(0, 81);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(483, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // deleteProdBtn
            // 
            this.deleteProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteProdBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteProdBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteProdBtn.CheckedState.Parent = this.deleteProdBtn;
            this.deleteProdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProdBtn.HoverState.Image = global::StoreMan.Properties.Resources.delete_hover;
            this.deleteProdBtn.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.deleteProdBtn.HoverState.Parent = this.deleteProdBtn;
            this.deleteProdBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteProdBtn.Image")));
            this.deleteProdBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.deleteProdBtn.ImageRotate = 0F;
            this.deleteProdBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.deleteProdBtn.Location = new System.Drawing.Point(407, 46);
            this.deleteProdBtn.Name = "deleteProdBtn";
            this.deleteProdBtn.PressedState.Image = global::StoreMan.Properties.Resources.delete_hover;
            this.deleteProdBtn.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.deleteProdBtn.PressedState.Parent = this.deleteProdBtn;
            this.deleteProdBtn.ShadowDecoration.Parent = this.deleteProdBtn;
            this.deleteProdBtn.Size = new System.Drawing.Size(36, 34);
            this.deleteProdBtn.TabIndex = 6;
            this.deleteProdBtn.UseTransparentBackground = true;
            this.deleteProdBtn.Click += new System.EventHandler(this.deleteProdBtn_Click);
            // 
            // PartProdListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.deleteProdBtn);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.sppuText);
            this.Controls.Add(this.pCodeText);
            this.Controls.Add(this.serialText);
            this.Controls.Add(this.pNameText);
            this.Controls.Add(this.quantityInput);
            this.Name = "PartProdListRow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(483, 92);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox quantityInput;
        private System.Windows.Forms.Label pNameText;
        private System.Windows.Forms.Label serialText;
        private System.Windows.Forms.Label pCodeText;
        private System.Windows.Forms.Label sppuText;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ImageButton deleteProdBtn;
    }
}
