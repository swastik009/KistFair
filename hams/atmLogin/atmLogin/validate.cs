using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace atmLogin
{
    /// <summary>
    /// Class validation
    /// </summary>
    class Validate
    {
        public long UserNum = 0;


        /// <summary>
        /// pincode generation
        /// </summary>
        /// <returns></returns>
        public int PinCodeGen()
        {

            Random random = new Random();
            return random.Next(1000, 9999);
        }



        /// <summary>
        /// ERandom number generation
        /// </summary>
        /// <returns></returns>
        public long Rand()
        {
            Random random = new Random();
            UserNum = ((long)random.Next(100000000, 999999999));
            return UserNum;
        }


        /// <summary>
        /// Password check
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool PasswordValid(string password)
        {
            try
            {
                Regex regex = new Regex(@"^([a-zA-Z0-9@*#]{8,15})$");
                Match match = regex.Match(password);
                return true;
            }
            catch (Exception e)
            {

                return false;
            }


        }
        /// <summary>
        /// Email validation
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool EmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception e)
            {

                return false;

            }
        }
    }
}
