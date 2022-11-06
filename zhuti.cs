using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
namespace 生一档傻瓜式生成器
{
    public partial class zhuti :MaterialForm
    {
       
        public zhuti()
        {
            InitializeComponent();
        }

        private void zhuti_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey700,
                        Primary.BlueGrey900,
                        Primary.BlueGrey400,
                        Accent.LightBlue200,
                        TextShade.WHITE);
            materialButton2.UseAccentColor = false;
            materialButton1.UseAccentColor = true;
            materialButton3.UseAccentColor = false;
            this.Refresh();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                       Primary.Blue600,
                       Primary.Blue800,
                       Primary.Blue300,
                       Accent.Red100,
                       TextShade.WHITE);
            materialButton2.UseAccentColor = true;
            materialButton1.UseAccentColor = false;
            materialButton3.UseAccentColor = false;
            this.Refresh();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
           ColorTranslator.FromHtml("#f09819"),
           ColorTranslator.FromHtml("#c07819"),
           ColorTranslator.FromHtml("#f09819"),
           ColorTranslator.FromHtml("#ff5858"),
           TextShade.WHITE);
            materialButton2.UseAccentColor = false;
            materialButton1.UseAccentColor = false;
            materialButton3.UseAccentColor = true;
            this.Refresh();

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
            this.Refresh();
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
