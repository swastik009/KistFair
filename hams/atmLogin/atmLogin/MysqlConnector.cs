using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace atmLogin
{
    /// <summary>
    /// Connector class
    /// </summary>
    class MysqlConnector
    {///

        /// <summary>
        /// MySql Connection method
        /// </summary>
        private static string connectionString = "SERVER=localhost;DATABASE=atmsignup;UID=root;";
        public MySqlConnection con;
        public MysqlConnector()
        {

            
           con = new MySqlConnection(connectionString);
            try
            {
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Connection failed");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
