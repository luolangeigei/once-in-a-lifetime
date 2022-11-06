using System;
using System.Windows.Forms;
using WindowsFormsApp4;

    namespace Load_Edit_And_Save_WPS_Excel
    {
        class Program
        {
        [STAThread]
        static void Main(string[] args)
            {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Form1());
            //创建Workbook实例
            //Workbook workbook = new Workbook();
            //加载WPS表格文档
            //workbook.LoadFromFile("moban.et");
            //workbook.LoadFromFile("学生个人信息登记表.ett");

            //获取第一个工作表
            //Worksheet sheet = workbook.Worksheets[0];

            //向工作表的指定单元格填充数据
            //sheet.Range["C11"].Text = "广东省珠海市XX街道XX号";
            //sheet.Range["C12"].Text = "广东省珠海市XX街道XX号";
            //sheet.Range["C13"].Text = "1598523XXXX";
            //sheet.Range["C14"].Text = "daokeer@ 163.com";

            //保存文档为.et格式
            //workbook.SaveToFile("WPS.et", FileFormat.ET);
            //保存文档为.ett格式
            //wb.SaveToFile("WPS.ett", FileFormat.ETT);
        }
        }
    }
