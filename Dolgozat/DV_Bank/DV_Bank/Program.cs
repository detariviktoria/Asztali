using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_Bank
{
    internal class Program
    {
        static Random R = new Random();
        static void Main(string[] args)
        {
            BankAccount sz1 = new BankAccount("Kis Pista","112233445566", 123.478);
            BankAccount sz2 = new BankAccount("Nagy Rozália");

            Console.WriteLine(sz1.ToString());
            Console.WriteLine(sz2.ToString());


            /*double a = R.Next(10, 1000);
            double b = R.Next(10, 1000);*/

            Befizetes(sz1);
            Befizetes(sz2);

            Levonas(sz1);
            Levonas( sz2);

            /*sz1.Deposit(a);
            sz2.Deposit(b);*/
            Console.ReadLine();
        }

        static void Befizetes(BankAccount sz)
        {
            double a = R.Next(10, 1000);
            sz.Deposit(a);
            Console.WriteLine(sz.ToString());
        }

        static void Levonas(BankAccount sz)
        {
            sz.Withdraw(500);
            Console.WriteLine(sz.ToString());
        }


    }
}
