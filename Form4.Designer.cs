namespace 生一档傻瓜式生成器
{
    partial class Form4
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
            MaterialSkin.MaterialListBoxItem materialListBoxItem1 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem2 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem3 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem4 = new MaterialSkin.MaterialListBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pay_list = new MaterialSkin.Controls.MaterialListBox();
            this.moreng_1 = new MaterialSkin.Controls.MaterialCard();
            this.moreng_3 = new MaterialSkin.Controls.MaterialLabel();
            this.moreng_2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.moreng_1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pay_list
            // 
            this.pay_list.BackColor = System.Drawing.Color.White;
            this.pay_list.BorderColor = System.Drawing.Color.LightGray;
            this.pay_list.Depth = 0;
            this.pay_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialListBoxItem1.SecondaryText = "";
            materialListBoxItem1.Tag = null;
            materialListBoxItem1.Text = "支付宝";
            materialListBoxItem2.SecondaryText = "";
            materialListBoxItem2.Tag = null;
            materialListBoxItem2.Text = "微信";
            materialListBoxItem3.SecondaryText = "";
            materialListBoxItem3.Tag = null;
            materialListBoxItem3.Text = "QQ";
            materialListBoxItem4.SecondaryText = "";
            materialListBoxItem4.Tag = null;
            materialListBoxItem4.Text = "paypal";
            this.pay_list.Items.Add(materialListBoxItem1);
            this.pay_list.Items.Add(materialListBoxItem2);
            this.pay_list.Items.Add(materialListBoxItem3);
            this.pay_list.Items.Add(materialListBoxItem4);
            this.pay_list.Location = new System.Drawing.Point(14, 80);
            this.pay_list.MouseState = MaterialSkin.MouseState.HOVER;
            this.pay_list.MultiSelect = true;
            this.pay_list.Name = "pay_list";
            this.pay_list.SelectedIndex = -1;
            this.pay_list.SelectedItem = null;
            this.pay_list.ShowBorder = false;
            this.pay_list.Size = new System.Drawing.Size(206, 355);
            this.pay_list.Style = MaterialSkin.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            this.pay_list.TabIndex = 0;
            this.pay_list.UseAccentColor = true;
            this.pay_list.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBox1_SelectedIndexChanged);
            this.pay_list.MouseUp += new System.Windows.Forms.MouseEventHandler(this.materialListBox1_MouseUp);
            // 
            // moreng_1
            // 
            this.moreng_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.moreng_1.Controls.Add(this.moreng_3);
            this.moreng_1.Controls.Add(this.moreng_2);
            this.moreng_1.Depth = 0;
            this.moreng_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.moreng_1.Location = new System.Drawing.Point(237, 78);
            this.moreng_1.Margin = new System.Windows.Forms.Padding(14);
            this.moreng_1.MouseState = MaterialSkin.MouseState.HOVER;
            this.moreng_1.Name = "moreng_1";
            this.moreng_1.Padding = new System.Windows.Forms.Padding(14);
            this.moreng_1.Size = new System.Drawing.Size(554, 351);
            this.moreng_1.TabIndex = 1;
            // 
            // moreng_3
            // 
            this.moreng_3.AutoSize = true;
            this.moreng_3.Depth = 0;
            this.moreng_3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.moreng_3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.moreng_3.Location = new System.Drawing.Point(188, 200);
            this.moreng_3.MouseState = MaterialSkin.MouseState.HOVER;
            this.moreng_3.Name = "moreng_3";
            this.moreng_3.Size = new System.Drawing.Size(201, 24);
            this.moreng_3.TabIndex = 0;
            this.moreng_3.Text = "请在左侧选择支付方式";
            this.moreng_3.Click += new System.EventHandler(this.ww_Click);
            // 
            // moreng_2
            // 
            this.moreng_2.AutoSize = true;
            this.moreng_2.Depth = 0;
            this.moreng_2.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.moreng_2.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.moreng_2.Location = new System.Drawing.Point(128, 142);
            this.moreng_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.moreng_2.Name = "moreng_2";
            this.moreng_2.Size = new System.Drawing.Size(337, 58);
            this.moreng_2.TabIndex = 1;
            this.moreng_2.Text = "感谢你的捐赠！";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.pictureBox1);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(237, 78);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(554, 351);
            this.materialCard2.TabIndex = 2;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(23, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 259);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(13, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(149, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "QQ支付：";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moreng_1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.pay_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "捐赠";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.moreng_1.ResumeLayout(false);
            this.moreng_1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialCard moreng_1;
        private MaterialSkin.Controls.MaterialLabel moreng_3;
        private MaterialSkin.Controls.MaterialLabel moreng_2;
        private MaterialSkin.Controls.MaterialListBox pay_list;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}