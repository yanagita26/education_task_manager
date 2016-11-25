using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TaskManager.Forms;
using TaskManager.Controllers;

namespace TaskManager
{
    public static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new TaskIchiranForm());
        }
    }
}
