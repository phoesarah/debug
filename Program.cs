using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000;
            int Transaction = 0;

                while (Transaction <6 )
            {
            Console.WriteLine("Please say A for Add or S for subtract");
            string s = Console.ReadLine().ToUpper();

            if (s == "S")
            {
                Console.WriteLine("How much would you like to subtract?");
                int i = Convert.ToInt32(Console.ReadLine());
                int newbalance = balance - i;
                Console.WriteLine(Convert.ToString(newbalance));
            }
            else if (s == "A")
            {
                Console.WriteLine("How much would you like to Add?");
                int i = Convert.ToInt32(Console.ReadLine());
                int newbalance = balance + i;
                Console.WriteLine(Convert.ToString(newbalance));
                
            }
            else
            {
                Console.WriteLine("Please only write capital A or S");
            }
            Transaction += 1;
        }
                Console.ReadLine();
        }
    }
}
