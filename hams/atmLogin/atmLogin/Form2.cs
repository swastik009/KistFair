﻿using System;
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
    public partial class Form2 : Form
    {
        protected string Query;
        protected int PinCode = 0;
        protected long UserNumCheck = 0;
        
        public Form2()
        {
            InitializeComponent();
           


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MysqlConnector Mysql = new MysqlConnector();
            Validate valid = new Validate();
            //long id = cmd.LastInsertedId;

            PinCode = valid.PinCodeGen();
            UserNumCheck = 9999;
            bool _validEmail = valid.EmailValid(Email.Text);
            bool _validPassword = valid.PasswordValid(Password.Text);


            if (FirstName.Text != " " && LastName.Text != " " && _validEmail == true && _validPassword == true)
            {
                try
                {
                    Query = "INSERT INTO clientdetails(first_name,second_name,last_name,email,password,pin_code,account_number) VALUES ('" + FirstName.Text + "','" + MiddleName.Text + "','" + LastName.Text + "','" + Email.Text + "','" + Password.Text + "','" + PinCode + "','" + UserNumCheck + "')";
                    Mysql.con.Open();
                    MySqlCommand cmd = new MySqlCommand(Query, Mysql.con);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Success");
                    MessageBox.Show("Your Pin : " + PinCode + " Your UID : " + UserNumCheck );
                    Form1 formBegin = new Form1();
                    this.Hide();
                    formBegin.ShowDialog();
                 
                }
                
                catch (Exception)
                {

                    MessageBox.Show("Unable Store Data");
                }
                finally
                {
                    Mysql.con.Close();
                }
                

            }

            else
            {
                if (FirstName.Text == "")
                {
                    MessageBox.Show("Empty First Name");
                    FirstName.Focus();
                }
                else if (LastName.Text == "")
                {
                    MessageBox.Show(" Empty Last Name");
                    LastName.Focus();
                }

                else if (_validEmail == false)
                {
                    MessageBox.Show("Invalid Email");
                    Email.Focus();
                }
                else if (_validPassword == false)
                {
                    MessageBox.Show("Invalid Password");
                    Password.Focus();
                }

                }
           
        }
        private void valCheck(object sender, EventArgs e)
        {
            if (CheckValid.Checked == true)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }


    }
}