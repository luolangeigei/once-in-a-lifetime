using MaterialSkin.Controls;
using System;
using System.Threading;
using WindowsFormsApp4;

namespace 生一档傻瓜式生成器
{
    public partial class Form6 : MaterialForm
    {
        public Form6()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           
            this.webView21.Source = new System.Uri(webBase.web);
            web_text.Text = webBase.web;
            Thread thread = new Thread(() =>
            {
                while (web_jindu.Value < 90)
                {
                    if (web_jindu.Value < 40)
                    {
                        Thread.Sleep(100);
                        web_jindu.Value++;
                    }
                    else
                    {
                        Thread.Sleep(1000);
                        web_jindu.Value++;
                    }

                }
            });
            thread.Start();

        }
        private void jindu()
        {
     
        }

        private void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            web_jindu.Value=0;
            this.webView21.Source = new System.Uri(web_text.Text);
            Thread thread = new Thread(() =>
            {
                while (web_jindu.Value <= 90)
                {
                    if (web_jindu.Value <= 40)
                    {
                        Thread.Sleep(100);
                        web_jindu.Value++;
                    }
                    if (web_jindu.Value >= 40 && web_jindu.Value <= 90)
                    {
                        Thread.Sleep(1000);
                        web_jindu.Value++;
                    }

                }
            });
            thread.Start();
        }

        private void webView21_ContentLoading(object sender, Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
        {
        }

        private void webView21_NavigationCompleted_1(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            web_jindu.Value = 99;
        }
    }
}
