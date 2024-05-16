using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Classes
{
    internal class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public void GetInputs()
        {
            Console.WriteLine("Type 1st number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation(+,-,*,/,%): ");
            Operation = Console.ReadLine();
            Console.WriteLine("Type 2nd number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }

        public bool IsFirstNumberPositive()
        {
            return FirstNumber >= 0;
        }

        public void CompareInputs()
        {
            if(FirstNumber > SecondNumber)
            {
                Console.WriteLine("1st number is greater than 2nd number!");
            }
            else if(FirstNumber == SecondNumber)
            {
                Console.WriteLine("1st number is equal to 2nd number!");
            }
            else
            {
                Console.WriteLine("1st number is less than 2nd number!");
            }
        }
    }
}
