using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using 生一档傻瓜式生成器;
using System.Threading;

namespace WindowsFormsApp4
{
    
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {

            InitializeComponent();

            // Initialize MaterialSkinManager
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                       Primary.Blue600,
                       Primary.Blue800,
                       Primary.Blue300,
                       Accent.Red100,
                       TextShade.WHITE);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @System.Threading.Thread.GetDomain().BaseDirectory+"update//AutoUpdater.exe";
            info.Arguments = "";
            info.WindowStyle = ProcessWindowStyle.Minimized;
            Process pro = Process.Start(info);
            Thread.Sleep(1000);
            System.Environment.Exit(0);
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            webBase.web = "https://wj.qq.com/s2/11082036/4c2e/";
            Form6 f = new Form6();
            f.ShowDialog();
        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBase.web = "https://gitee.com/luolan1/once-in-a-lifetime";
            Form6 f = new Form6();
            f.ShowDialog();
        }

     

    

        private void zhuti_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            zhuti h = new zhuti();
            h.ShowDialog();
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            Form4 h = new Form4();
            h.ShowDialog();
        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBase.web = " https://dotnet.microsoft.com/zh-cn";
            Form6 f = new Form6();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBase.web = " https://visualstudio.microsoft.com";
            Form6 f = new Form6();
            f.ShowDialog();
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            huanc f = new huanc();
            f.ShowDialog();
        }
    }
}

