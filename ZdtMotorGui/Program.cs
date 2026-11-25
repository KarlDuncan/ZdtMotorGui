using System;
using System.Windows.Forms;

namespace ZdtMotorGui
{
    /// <summary>
    /// 程序入口：启动 WinForms 消息循环，显示 MainForm 窗口。
    /// 双击 exe 或 VS 里按 F5 都会走到这里。
    /// </summary>
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            // 启用 Windows 视觉样式，并让控件按 GDI+ 兼容模式绘制
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
