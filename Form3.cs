using MaterialSkin.Controls;
using Spire.Xls;
using System;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace 生一档傻瓜式生成器
{
    public partial class Form3: MaterialForm
    {
        public Form3()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            // Initialize MaterialSkinManager

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            switch (webBase.renshu)
            {
                case 1:
                    jkm_1.Visible = xck_1.Visible = hs_1.Visible = true;
                    break;
                case 2:
                    jkm_1.Visible = xck_1.Visible = hs_1.Visible =
                    jkm_2.Visible = xck_2.Visible = hs_2.Visible = true;
                    break;
                case 3:
                    jkm_1.Visible = xck_1.Visible = hs_1.Visible =
                    jkm_2.Visible = xck_2.Visible = hs_2.Visible =
                    jkm_3.Visible = xck_3.Visible = hs_3.Visible = true;
                    break;
                case 4:
                    jkm_1.Visible = xck_1.Visible = hs_1.Visible =
                    jkm_2.Visible = xck_2.Visible = hs_2.Visible =
                    jkm_3.Visible = xck_3.Visible = hs_3.Visible =
                    jkm_4.Visible = xck_4.Visible = hs_4.Visible = true;
                    break;
                case 5:
                    jkm_1.Visible = xck_1.Visible = hs_1.Visible =
                    jkm_2.Visible = xck_2.Visible = hs_2.Visible =
                    jkm_3.Visible = xck_3.Visible = hs_3.Visible =
                    jkm_4.Visible = xck_4.Visible = hs_4.Visible = 
                    jkm_5.Visible=xck_5.Visible=hs_5.Visible=true;
                    break;
            }
            switch (webBase.renshu)
            {
                case 4:
                    jkm_5.Text = xck_5.Text = hs_5.Text = @System.Threading.Thread.GetDomain().BaseDirectory +
                        "awa.png";
                    break;
                case 3:
                    jkm_5.Text = xck_5.Text = hs_5.Text =
                    jkm_4.Text = xck_4.Text = hs_4.Text = @System.Threading.Thread.GetDomain().BaseDirectory +
                        "awa.png";
                    break;
                case 2:
                    jkm_5.Text = xck_5.Text = hs_5.Text =
                    jkm_4.Text = xck_4.Text = hs_4.Text =
                    jkm_3.Text = xck_3.Text = hs_3.Text = @System.Threading.Thread.GetDomain().BaseDirectory +
                        "awa.png";
                    break;
                case 1:
                    jkm_5.Text = xck_5.Text = hs_5.Text =
                    jkm_4.Text = xck_4.Text = hs_4.Text =
                    jkm_3.Text = xck_3.Text = hs_3.Text =
                    jkm_2.Text = xck_2.Text = hs_2.Text = @System.Threading.Thread.GetDomain().BaseDirectory +
                        "awa.png";
                    break;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter ="图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jkm_file = openFileDialog.FileName;
                    jkm_1.Text = jkm_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
          
        }

        private void materialDrawer1_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox25_Click(object sender, EventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked == true)
            {
                xck_1.Enabled = false;
                xck_button_1.Visible = false;
            }
            else
            {
                xck_1.Enabled = true;
                xck_button_1.Visible = true;
            }
        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton16_Click(object sender, EventArgs e)
        {
            jindu_text.Text = "正在打开文件选择框...";
            jindu_2.Value += 2;
            Thread save = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                SaveFileDialog saveDataSend = new SaveFileDialog();
                jindu_text.Text = "正在等待用户选择保存位置";
                jindu_2.Value += 8;
                // Environment.SpecialFolder.MyDocuments 表示在我的文档中
                saveDataSend.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);   // 获取文件路径
                saveDataSend.Filter = "*.xlsx|表格文件";   // 设置文件类型为文本文件
                saveDataSend.DefaultExt = ".xlsx";   // 默认文件的拓展名
                saveDataSend.FileName = "一生一档-" + name.Text+".xlsx";   // 文件默认名
                if (saveDataSend.ShowDialog() == DialogResult.OK)   // 显示文件框，并且选择文件
                {
                    string fName = saveDataSend.FileName;   // 获取文件名
                                 // 参数1：写入文件的文件名；参数2：写入文件的内容
                    save_2(fName);
                    
                }
            });
            save.SetApartmentState(ApartmentState.STA);
            save.IsBackground = true;
            save.Start();
        }

        private void materialTextBox214_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jkm_file = openFileDialog.FileName;
                    jkm_2.Text = jkm_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jkm_file = openFileDialog.FileName;
                    jkm_3.Text = jkm_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jkm_file = openFileDialog.FileName;
                    jkm_4.Text = jkm_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jkm_file = openFileDialog.FileName;
                    jkm_5.Text = jkm_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void xck_button_1_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    xck_1.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    xck_2.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    xck_3.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    xck_4.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    xck_5.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }
        private void save_2(string save_weizhi)
        {
            Thread save_jindu = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                while(jindu_2.Value<=99)
                {
                    Thread.Sleep(100);
                    jindu_2.Value++;
                }
            });
            save_jindu.Start();
            Thread save = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {

                //保存文档
                jindu_text.Text = "初始化";
                //创建Workbook实例
                Workbook workbook = new Workbook();

                //加载表格文档
                workbook.LoadFromFile("一生一档-第一部分.xlsx");

                //获取第一个工作表
                Worksheet sheet = workbook.Worksheets["正面"];

                jindu_text.Text = "正在保存健康码-1";
                ExcelPicture picture2 = sheet.Pictures.Add(4, 1, @jkm_1.Text);
                picture2.Width = 150;
                picture2.Height = 220;
                picture2.Left = 870;
                picture2.Top = 500;

                jindu_text.Text = "正在保存健康码-2";
                ExcelPicture picture3 = sheet.Pictures.Add(4, 1, @jkm_2.Text);
                picture3.Width = 150;
                picture3.Height = 220;
                picture3.Left = 1050;
                picture3.Top = 500;

                jindu_text.Text = "正在保存健康码-3";
                ExcelPicture picture4 = sheet.Pictures.Add(4, 1, @jkm_3.Text);
                picture4.Width = 150;
                picture4.Height = 220;
                picture4.Left = 1225;
                picture4.Top = 500;

                jindu_text.Text = "正在保存行程卡-1";
                ExcelPicture picture5 = sheet.Pictures.Add(4, 1, @xck_1.Text);
                picture5.Width = 150;
                picture5.Height = 220;
                picture5.Left = 50;
                picture5.Top = 500;

                jindu_text.Text = "正在保存行程卡-2";
                ExcelPicture picture6 = sheet.Pictures.Add(4, 1, @xck_2.Text);
                picture6.Width = 150;
                picture6.Height = 220;
                picture6.Left = 250;
                picture6.Top = 500;

                jindu_text.Text = "正在保存行程卡-3";
                ExcelPicture picture7 = sheet.Pictures.Add(4, 1, @xck_3.Text);
                picture7.Width = 150;
                picture7.Height = 220;
                picture7.Left = 450;
                picture7.Top = 500;

                jindu_text.Text = "正在保存核酸信息-1";
                ExcelPicture picture8 = sheet.Pictures.Add(4, 1, @hs_1.Text);
                picture8.Width = 150;
                picture8.Height = 220;
                picture8.Left = 50;
                picture8.Top = 730;

                jindu_text.Text = "正在保存核酸信息-2";
                ExcelPicture picture9 = sheet.Pictures.Add(4, 1, @hs_2.Text);
                picture9.Width = 150;
                picture9.Height = 220;
                picture9.Left = 250;
                picture9.Top = 730;

                jindu_text.Text = "正在保存核酸信息-3";
                ExcelPicture picture10 = sheet.Pictures.Add(4, 1, @hs_3.Text);
                picture10.Width = 150;
                picture10.Height = 220;
                picture10.Left = 450;
                picture10.Top = 730;


                jindu_text.Text = "正在保存核酸信息-4";
                ExcelPicture picture11 = sheet.Pictures.Add(4, 1, @hs_4.Text);
                picture11.Width = 150;
                picture11.Height = 220;
                picture11.Left = 650;
                picture11.Top = 730;


                jindu_text.Text = "正在保存核酸信息-5";
                ExcelPicture picture12 = sheet.Pictures.Add(4, 1, @hs_5.Text);
                picture12.Width = 150;
                picture12.Height = 220;
                picture12.Left = 850;
                picture12.Top = 730;

                jindu_text.Text = "正在保存姓名";
                sheet.Range["C3"].Text = name.Text;



                jindu_text.Text = "保存文件";
                jindu_2.Value = 98;
                workbook.SaveToFile(save_weizhi, FileFormat.Version2010);
                jindu_text.Text = "保存成功！";
            });
            save.Start();
        }

        private void jkm_1_Click(object sender, EventArgs e)
        {

        }

        private void jindu_2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton13_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    hs_1.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton14_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    hs_2.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton15_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    hs_3.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    hs_4.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            Thread th = new System.Threading.Thread((System.Threading.ThreadStart)delegate
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
                openFileDialog.Filter = "图像文件(.jpg;.jpg;.jpeg;.gif;.png) |.jpg;.jpeg;.gif; *.png";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xck_file = openFileDialog.FileName;
                    hs_5.Text = xck_file;
                }
            });
            th.SetApartmentState(ApartmentState.STA);
            th.IsBackground = true;
            th.Start();
        }
    }
}
