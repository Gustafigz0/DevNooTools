using System;
using System.Windows.Forms;
using DevNooTools.Data;
using DevNooTools.Forms;

namespace DevNooTools
{
    internal static class Program
    {
        public static UserRepository UserRepository { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialize user repository
            UserRepository = new UserRepository();

            // Show login form
            using (var loginForm = new LoginForm(UserRepository))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // User logged in successfully, show main form
                    Application.Run(new Form1());
                }
            }
        }
    }
}
