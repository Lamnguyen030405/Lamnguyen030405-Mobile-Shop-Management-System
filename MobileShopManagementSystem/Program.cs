using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobileShopManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitDatabase();
            Application.Run(new Form1());
        }

        static void InitDatabase()
        {
            string script = System.IO.File.ReadAllText("script.txt");
            using (SqlConnection connection = new SqlConnection(@"Data Source=.;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                connection.Open();
                string[] commands = script.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string commandText in commands)
                {
                    string trimmed = commandText.Trim();
                    if (!string.IsNullOrEmpty(trimmed))
                    {
                        using (SqlCommand command = new SqlCommand(trimmed, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
