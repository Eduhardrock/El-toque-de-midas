namespace El_Toque_de_Midas
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
            
            Login main = new Login();
            main.FormClosed += MainForm_Closed;
            main.Show();
            Application.Run();
        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0) {
                Application.ExitThread();
            } else {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}