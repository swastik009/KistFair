using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atmLogin
{
    public partial class Login : Form
    {
        //List<string> list = new List<string>[2];
        //list[0] = new List<string>();

        string em, pass;
        
        public Login()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            //Button loginButton = (Button)sender;
            string connectionString = "SERVER=localhost;DATABASE=atm;UID=root;PASSWORD=";
            string email,pwd;
            email = emailBox.Text.ToString();
            pwd = pwdBox.Text.ToString();
            string query = "SELECT email, pwd FROM datas where email='" + email + "' AND pwd='" + pwd + "';";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                em = dataReader["email"].ToString();
                pass = dataReader["pwd"].ToString();

            }

            //MessageBox.Show(em + " \n" + pass);

            
            if ((String.Compare(email, em) == 0) && String.Compare(pwd, pass) == 0)
            {
                MessageBox.Show("Loggin Successful");
            }
            else
            {
                MessageBox.Show("you screwed up");
            }
             
            





            /*
            if (email == "hams" && pwd == "hamspwd")
            {
                MessageBox.Show("you're logged in");
            } */
        }
    }
}
