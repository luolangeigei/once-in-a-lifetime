namespace 生一档傻瓜式生成器
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.web_text = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.web_jindu = new MaterialSkin.Controls.MaterialProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(2, 117);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1273, 555);
            this.webView21.Source = new System.Uri("https://wj.qq.com/s2/11082036/4c2e/", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView21_NavigationCompleted_1);
            this.webView21.ContentLoading += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>(this.webView21_ContentLoading);
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // web_text
            // 
            this.web_text.AllowPromptAsInput = true;
            this.web_text.AnimateReadOnly = false;
            this.web_text.AsciiOnly = false;
            this.web_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.web_text.BeepOnError = false;
            this.web_text.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.web_text.Depth = 0;
            this.web_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.web_text.HidePromptOnLeave = false;
            this.web_text.HideSelection = true;
            this.web_text.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.web_text.LeadingIcon = null;
            this.web_text.Location = new System.Drawing.Point(5, 64);
            this.web_text.Mask = "";
            this.web_text.MaxLength = 32767;
            this.web_text.MouseState = MaterialSkin.MouseState.OUT;
            this.web_text.Name = "web_text";
            this.web_text.PasswordChar = '\0';
            this.web_text.PrefixSuffixText = null;
            this.web_text.PromptChar = '_';
            this.web_text.ReadOnly = false;
            this.web_text.RejectInputOnFirstFailure = false;
            this.web_text.ResetOnPrompt = true;
            this.web_text.ResetOnSpace = true;
            this.web_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.web_text.SelectedText = "";
            this.web_text.SelectionLength = 0;
            this.web_text.SelectionStart = 0;
            this.web_text.ShortcutsEnabled = true;
            this.web_text.Size = new System.Drawing.Size(1164, 48);
            this.web_text.SkipLiterals = true;
            this.web_text.TabIndex = 1;
            this.web_text.TabStop = false;
            this.web_text.Text = "  ";
            this.web_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.web_text.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.web_text.TrailingIcon = ((System.Drawing.Image)(resources.GetObject("web_text.TrailingIcon")));
            this.web_text.UseSystemPasswordChar = false;
            this.web_text.ValidatingType = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1188, 76);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "访问";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // web_jindu
            // 
            this.web_jindu.Depth = 0;
            this.web_jindu.Location = new System.Drawing.Point(6, 107);
            this.web_jindu.MouseState = MaterialSkin.MouseState.HOVER;
            this.web_jindu.Name = "web_jindu";
            this.web_jindu.Size = new System.Drawing.Size(1163, 5);
            this.web_jindu.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.web_jindu.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1276, 672);
            this.Controls.Add(this.web_jindu);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.web_text);
            this.Controls.Add(this.webView21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.Text = "浏览器";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private MaterialSkin.Controls.MaterialMaskedTextBox web_text;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialProgressBar web_jindu;
        private System.Windows.Forms.Timer timer1;
    }
}