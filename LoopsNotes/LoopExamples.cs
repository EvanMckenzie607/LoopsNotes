using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsNotes
{
    internal class LoopExamples
    {
        public static double Deposit(double balance)
        {
            bool conditional;
            do
            {
                Console.WriteLine("How much would you like to deposit?");
                string number = Console.ReadLine();
                double attemptedAnswer;
                if (double.TryParse(number, out attemptedAnswer))
                {
                    balance += attemptedAnswer;
                }

                Console.WriteLine("Would you like to make another deposit? \n" +
                    "Yes or No");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    conditional = true;
                }
                else
                {
                    conditional = false;
                }



            } while (conditional);

            return balance;

        }
    }
}
