/* ===================================
 * 项目名称：二维码生成解析工具
 * 功能描述：Program  
 * 创 建 者：hackgsl
 * 创建日期：2020-04-15 21:47:25
 * CLR Ver ：4.0.30319.42000
 * =================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 二维码生成解析工具
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
