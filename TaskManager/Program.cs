using System;
using System.Windows.Forms;
using TaskManager.Controllers;
using TaskManager.Forms;

namespace TaskManager
{
    /// <summary>
    /// タスクマネージャー
    /// </summary>
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


            try
            {
                DatabaseIf.Instance.Connect();
                Application.Run(new TaskIchiranForm());
            }
            finally
            {
                DatabaseIf.Instance.Disconnect();
            }
        }
    }
}
