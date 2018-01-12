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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO hamstable VALUES(6,'Hamlet Maharjan',20,'male')";
            string connectionString = "SERVER=localhost;DATABASE=hamsdatabase;UID=root;PASSWORD=";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void effector(object sender, EventArgs e) {

         
        }

        private void pictureFinger_Click(object sender, EventArgs e)
        {
            Form2 formSign = new Form2();
            formSign.ShowDialog();
        }
    }
}
