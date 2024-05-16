using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Classes
{
    internal class Security
    {
        public void CheckPassword()
        {
            string password = "";

            do
            {
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
            } while (password != "pa$$w0rd");
        }
    }
}
