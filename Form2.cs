using MaterialSkin.Controls;
using Spire.Xls;
using System;
using System.Windows.Forms;
using 生一档傻瓜式生成器;

namespace WindowsFormsApp4
{
    public partial class Form2 : MaterialForm
    {

        short family_number;
        string sguanxi_1;
        string sguanxi_2;
        string sguanxi_3;
        string sguanxi_4;
        string sguanxi_5;


        public Form2()
        {
            
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
     
        }

        private void y_name_text_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            //根据人数让组件可见
            family_number = Convert.ToInt16(family_number_text.Text);
            webBase.renshu = family_number;
            switch (family_number)
            {
                case 1:
                    _tishi_2.Visible=guanxi_1.Visible=true;
                    break;
                case 2:
                    _tishi_2.Visible=guanxi_2.Visible=true;
                    guanxi_1.Visible= true;
                    break;
                case 3:
                    _tishi_2.Visible=guanxi_1.Visible = true;
                    guanxi_2.Visible= true;
                    guanxi_3.Visible = true;
                    break;
                case 4:
                    _tishi_2.Visible=guanxi_1.Visible = true;
                    guanxi_2.Visible = true;
                    guanxi_3.Visible=true;
                    guanxi_4.Visible=true;
                    break;
                case 5:
                    _tishi_2.Visible=guanxi_1.Visible = true;
                    guanxi_2.Visible = true;
                    guanxi_3.Visible = true;
                    guanxi_4.Visible = true;
                    guanxi_5.Visible=true;
                    break;
                default:
                    MessageBox.Show("人数太多辣！不能超过5人哦", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    break;
            }
        }

        private void materialTextBox22_Click(object sender, EventArgs e)
        {

        }

        private void save_2_Click(object sender, EventArgs e)
        {
           //---------------------------------------------


            _tishi_2.Visible = true;
            //根据人数让组件可见
            family_number = Convert.ToInt16(family_number_text.Text);
            switch (family_number)
            {
                case 1:
                    lia_1.Visible = shouji_1.Visible = dizhi_1.Visible = xingbie_1.Visible = mingzu_1.Visible = shequ_1.Visible = jiedao_1.Visible = huji_1.Visible = sfz_1.Visible = guanxi_1.Visible = sfz_name_1.Visible = true;
                    break;
                case 2:
                    lia_1.Visible = shouji_1.Visible = dizhi_1.Visible =
                    lia_2.Visible = shouji_2.Visible = dizhi_2.Visible =
                    xingbie_1.Visible = mingzu_1.Visible = shequ_1.Visible = jiedao_1.Visible = huji_1.Visible =
                    xingbie_2.Visible = mingzu_2.Visible = shequ_2.Visible = jiedao_2.Visible = huji_2.Visible =
                    guanxi_1.Visible =
                    guanxi_2.Visible =
                    sfz_1.Visible =
                    sfz_2.Visible =
                    sfz_name_1.Visible =
                    sfz_name_2.Visible = true;
                    break;
                case 3:
                    lia_1.Visible = shouji_1.Visible = dizhi_1.Visible =
                    lia_2.Visible = shouji_2.Visible = dizhi_2.Visible =
                    lia_3.Visible = shouji_3.Visible = dizhi_3.Visible =
                    xingbie_1.Visible = mingzu_1.Visible = shequ_1.Visible = jiedao_1.Visible = huji_1.Visible =
                    xingbie_2.Visible = mingzu_2.Visible = shequ_2.Visible = jiedao_2.Visible = huji_2.Visible =
                     xingbie_3.Visible = mingzu_3.Visible = shequ_3.Visible = jiedao_3.Visible = huji_3.Visible =
                    guanxi_1.Visible =
                    guanxi_2.Visible =
                    guanxi_3.Visible =
                    sfz_1.Visible =
                    sfz_2.Visible =
                    sfz_3.Visible =
                    sfz_name_1.Visible =
                    sfz_name_2.Visible =
                    sfz_name_3.Visible = true;
                    break;
                case 4:
                    lia_1.Visible = shouji_1.Visible = dizhi_1.Visible =
                   lia_2.Visible = shouji_2.Visible = dizhi_2.Visible =
                   lia_3.Visible = shouji_3.Visible = dizhi_3.Visible =
                    lia_4.Visible = shouji_4.Visible = dizhi_4.Visible =
                   xingbie_1.Visible = mingzu_1.Visible = shequ_1.Visible = jiedao_1.Visible = huji_1.Visible =
                     xingbie_2.Visible = mingzu_2.Visible = shequ_2.Visible = jiedao_2.Visible = huji_2.Visible =
                     xingbie_3.Visible = mingzu_3.Visible = shequ_3.Visible = jiedao_3.Visible = huji_3.Visible =
                      xingbie_4.Visible = mingzu_4.Visible = shequ_4.Visible = jiedao_4.Visible = huji_4.Visible =
                   guanxi_1.Visible =
                    guanxi_2.Visible =
                    guanxi_3.Visible =
                    guanxi_4.Visible =
                    sfz_1.Visible =
                    sfz_2.Visible =
                    sfz_3.Visible =
                    sfz_4.Visible =
                    sfz_name_1.Visible =
                    sfz_name_2.Visible =
                    sfz_name_4.Visible =
                    sfz_name_3.Visible = true;
                    break;
                case 5:
                    lia_1.Visible = shouji_1.Visible = dizhi_1.Visible =
                  lia_2.Visible = shouji_2.Visible = dizhi_2.Visible =
                  lia_3.Visible = shouji_3.Visible = dizhi_3.Visible =
                   lia_4.Visible = shouji_4.Visible = dizhi_4.Visible =
                    lia_5.Visible = shouji_5.Visible = dizhi_5.Visible =
                   xingbie_1.Visible = mingzu_1.Visible = shequ_1.Visible = jiedao_1.Visible = huji_1.Visible =
                     xingbie_2.Visible = mingzu_2.Visible = shequ_2.Visible = jiedao_2.Visible = huji_2.Visible =
                     xingbie_3.Visible = mingzu_3.Visible = shequ_3.Visible = jiedao_3.Visible = huji_3.Visible =
                      xingbie_4.Visible = mingzu_4.Visible = shequ_4.Visible = jiedao_4.Visible = huji_4.Visible =
                      xingbie_5.Visible = mingzu_5.Visible = shequ_5.Visible = jiedao_5.Visible = huji_5.Visible =
                    guanxi_5.Visible =
                    guanxi_1.Visible =
                    guanxi_2.Visible =
                    guanxi_4.Visible =
                    guanxi_3.Visible =
                    sfz_5.Visible =
                    sfz_1.Visible =
                    sfz_2.Visible =
                    sfz_4.Visible =
                    sfz_3.Visible =
                    sfz_name_1.Visible =
                    sfz_name_2.Visible =
                    sfz_name_4.Visible =
                    sfz_name_3.Visible =
                    sfz_name_5.Visible = true;
                    break;
                default:
                    MessageBox.Show("人数不能超过5人", "错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    break;

            }


            //--------------------------------
            _tishi_11.Visible=_tishi_10.Visible=_tishi_9.Visible=_tishi_8.Visible=_tishi_7.Visible=_tishi_6.Visible=_tishi_5.Visible=_tishi_4.Visible=_tishi_3.Visible=true;
            //将“关系”展现到各个地方！
            sguanxi_1 = guanxi_1.Text;
            sguanxi_2 = guanxi_2.Text;
            sguanxi_3 = guanxi_3.Text;
            sguanxi_4 = guanxi_4.Text;
            sguanxi_5 = guanxi_5.Text;
            save_text_1.Text = "确定成功！";
            dizhi_name_1.Text=shequ_name_1.Text=jiedao_name_1.Text=lia_1.Text=shouji_name_1.Text=huji_name_1.Text=mingzu_name_1.Text = xingbie_name_1.Text = sfz_name_1.Text = sguanxi_1;
            dizhi_name_2.Text = shequ_name_2.Text = jiedao_name_2.Text = lia_2.Text = shouji_name_2.Text = huji_name_2.Text = mingzu_name_2.Text = xingbie_name_2.Text = sfz_name_2.Text = sguanxi_2;
            dizhi_name_3.Text = shequ_name_3.Text = jiedao_name_3.Text = lia_3.Text = shouji_name_3.Text = huji_name_3.Text = mingzu_name_3.Text = xingbie_name_3.Text = sfz_name_3.Text = sguanxi_3;
            dizhi_name_4.Text = shequ_name_4.Text = jiedao_name_4.Text = lia_4.Text = shouji_name_4.Text = huji_name_4.Text = mingzu_name_4.Text = xingbie_name_4.Text = sfz_name_4.Text = sguanxi_4;
            dizhi_name_5.Text = shequ_name_5.Text = jiedao_name_5.Text = lia_5.Text = shouji_name_5.Text = huji_name_5.Text = mingzu_name_5.Text = xingbie_name_5.Text = sfz_name_5.Text = sguanxi_5;
   
        }



        private void save_3_Click(object sender, EventArgs e)
        {
          
        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox22_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e) //点击下一步
        {
            //保存文档
            tishi_1.Text = "初始化";
            jindu_1.Value += 10;
            //创建Workbook实例
            Workbook workbook = new Workbook();

            //加载表格文档
            workbook.LoadFromFile("一生一档.xlsx");

            //获取第一个工作表
            Worksheet sheet = workbook.Worksheets["正面"];
            //写入关系
            tishi_1.Text = "写入关系";
            jindu_1.Value += 8;
            sheet.Range["D3"].Text = sguanxi_1;
            sheet.Range["D4"].Text = sguanxi_2;
            sheet.Range["D5"].Text = sguanxi_3;
            sheet.Range["D6"].Text = sguanxi_4;
            sheet.Range["D7"].Text = sguanxi_5;
            //写入身份证号
            tishi_1.Text = "写入身份证号";
            jindu_1.Value += 8;
            sheet.Range["G3"].Text = sfz_1.Text;
            sheet.Range["G4"].Text = sfz_2.Text;
            sheet.Range["G5"].Text = sfz_3.Text;
            sheet.Range["G6"].Text = sfz_4.Text;
            sheet.Range["G7"].Text = sfz_5.Text;
            //写入性别
            tishi_1.Text = "写入性别";
            jindu_1.Value += 8;
            sheet.Range["E3"].Text = xingbie_1.Text;
            sheet.Range["E4"].Text = xingbie_2.Text;
            sheet.Range["E5"].Text = xingbie_3.Text;
            sheet.Range["E6"].Text = xingbie_4.Text;
            sheet.Range["E7"].Text = xingbie_5.Text;
            //写入民族
            tishi_1.Text = "写入民族";
            jindu_1.Value += 8;
            sheet.Range["F3"].Text = mingzu_1.Text;
            sheet.Range["F4"].Text = mingzu_2.Text;
            sheet.Range["F5"].Text = mingzu_3.Text;
            sheet.Range["F6"].Text = mingzu_4.Text;
            sheet.Range["F7"].Text = mingzu_5.Text;
            //写入手机号
            tishi_1.Text = "写入手机号";
            jindu_1.Value += 8;
            sheet.Range["M3"].Text = shouji_1.Text;
            sheet.Range["M4"].Text = shouji_2.Text;
            sheet.Range["M5"].Text = shouji_3.Text;
            sheet.Range["M6"].Text = shouji_4.Text;
            sheet.Range["M7"].Text = shouji_5.Text;
            //写入户籍所在地
            tishi_1.Text = "写入户籍所在地";
            jindu_1.Value += 8;
            sheet.Range["H3"].Text = huji_1.Text;
            sheet.Range["H4"].Text = huji_2.Text;
            sheet.Range["H5"].Text = huji_3.Text;
            sheet.Range["H6"].Text = huji_4.Text;
            sheet.Range["H7"].Text = huji_5.Text;
            //写入街道
            tishi_1.Text = "写入街道";
            jindu_1.Value += 8;
            sheet.Range["I3"].Text = jiedao_1.Text;
            sheet.Range["I4"].Text = jiedao_2.Text;
            sheet.Range["I5"].Text = jiedao_3.Text;
            sheet.Range["I6"].Text = jiedao_4.Text;
            sheet.Range["I7"].Text = jiedao_5.Text;
            //写入社区
            tishi_1.Text = "写入社区";
            jindu_1.Value += 8;
            sheet.Range["J3"].Text = mingzu_1.Text;
            sheet.Range["J4"].Text = mingzu_2.Text;
            sheet.Range["J5"].Text = mingzu_3.Text;
            sheet.Range["J6"].Text = mingzu_4.Text;
            sheet.Range["J7"].Text = mingzu_5.Text;
            //写入现居住地
            tishi_1.Text = "写入现居住地";
            jindu_1.Value += 8;
            sheet.Range["K3"].Text = dizhi_1.Text;
            sheet.Range["K4"].Text = dizhi_2.Text;
            sheet.Range["K5"].Text = dizhi_3.Text;
            sheet.Range["K6"].Text = dizhi_4.Text;
            sheet.Range["K7"].Text = dizhi_5.Text;
            //写入是否离阿
            tishi_1.Text = "写入离阿";
            jindu_1.Value += 8;
            if (lia_1.Checked == true)
                sheet.Range["L3"].Text = "是";
            else
                sheet.Range["L3"].Text = "否";
            if (lia_2.Checked == true)
                sheet.Range["L4"].Text = "是";
            else
                sheet.Range["L4"].Text = "否";
            if (lia_3.Checked == true)
                sheet.Range["L5"].Text = "是";
            else
                sheet.Range["L5"].Text = "否";
            if (lia_4.Checked == true)
                sheet.Range["L6"].Text = "是";
            else
                sheet.Range["L6"].Text = "否";
            if (lia_5.Checked == true)
                sheet.Range["L7"].Text = "是";
            else
                sheet.Range["L7"].Text = "否";

            //保存文件
            tishi_1.Text = "保存文件";
            jindu_1.Value += 9;
            workbook.SaveToFile("一生一档-第一部分.xlsx", FileFormat.Version2010);
            tishi_1.Text = "保存成功！";
            jindu_1.Value += 1;
            Form3 q = new Form3();
            q.ShowDialog();


        }

        private void xingbie_3_Click(object sender, EventArgs e)
        {

        }

        private void xingbie_4_Click(object sender, EventArgs e)
        {

        }

        private void guanxi_5_Click(object sender, EventArgs e)
        {

        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lia_3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void save_4_Click(object sender, EventArgs e)
        {

        }

        private void jindu_1_Click(object sender, EventArgs e)
        {

        }

        private void materialExpansionPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialExpansionPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
