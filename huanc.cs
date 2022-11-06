using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace 生一档傻瓜式生成器
{
    public partial class huanc : MaterialForm
    {
        public huanc()
        {
            InitializeComponent();
        }
        int web_size;
        int web_size_mb;
        int doc_size;

        private void huanc_Load(object sender, EventArgs e)
        {
            //调用filesize计算浏览器缓存大小（字节）
            web_size = int.Parse(Convert.ToString(FileSize(AppDomain.CurrentDomain.BaseDirectory + "一生一档傻瓜式生成器.exe.WebView2\\")));
            //将字节转换为MB
            web_size_mb = web_size / 1048576;
            //打印大小
            websize_text.Text = Convert.ToString(web_size_mb)+"MB";
            //如果有文档文件才扫描
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "一生一档-第一部分.xlsx") == true)
            {
                //调用filesize计算文档大小
                doc_size = int.Parse(Convert.ToString(FileSize(AppDomain.CurrentDomain.BaseDirectory + "一生一档-第一部分.xlsx")));
                //打印大小
                doc_size_text.Text = Convert.ToString(doc_size) + "字节";
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            //调用delete删除文件夹
            Directory.Delete(Convert.ToString((AppDomain.CurrentDomain.BaseDirectory + "一生一档傻瓜式生成器.exe.WebView2\\")),true);
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "一生一档傻瓜式生成器.exe.WebView2\\");
            MessageBox.Show("删除成功！", "完成", MessageBoxButtons.OK);
        }
        public static long FileSize(string filePath)
        {
            long temp = 0;

            //判断当前路径所指向的是否为文件
            if (File.Exists(filePath) == false)
            {
                string[] str1 = Directory.GetFileSystemEntries(filePath);
                foreach (string s1 in str1)
                {
                    temp += FileSize(s1);
                }
            }
            else
            {

                //定义一个FileInfo对象,使之与filePath所指向的文件向关联,

                //以获取其大小
                FileInfo fileInfo = new FileInfo(filePath);
                return fileInfo.Length;
            }
            return temp;
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            //调用delete删除文档
            File.Delete(Convert.ToString((AppDomain.CurrentDomain.BaseDirectory + "一生一档-第一部分.xlsx")));
        }
    }
}
