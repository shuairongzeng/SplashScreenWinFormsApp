
namespace SplashScreenWinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SplashScreen.Splasher.Show(typeof(FrmSplashScreen));

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.Run(new Form1());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            //LogHelper.Error(ex.Exception);

            string message = string.Format("{0}\r\n����������������Ҫ�˳�ϵͳô��", e.Exception.Message);
            if (DialogResult.Yes == MessageBox.Show(message, "ϵͳ����", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }
    }
}