using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEx1Invoices
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choice = true;

            while (choice)
            {
                decimal[] invoices = new decimal[5];
                decimal total = 0;

                Console.Write("Enter the total of invoice 1: ");
                invoices[0] = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the total of invoice 2: ");
                invoices[1] = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the total of invoice 3: ");
                invoices[2] = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the total of invoice 4: ");
                invoices[3] = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the total of invoice 5: ");
                invoices[4] = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("using a for loop...");
                Console.WriteLine();

                for (int i=0; i<invoices.Length; i++)
                {
                    total += invoices[i];
                    Console.WriteLine(invoices[i].ToString("c"));
                }

                Console.WriteLine("Total: " + total.ToString("c"));

                Console.WriteLine();
                Console.WriteLine("using a fooreach loop...");
                Console.WriteLine();
                total = 0;

                //foreach
                foreach(decimal inv in invoices)
                {
                    total += inv;
                    Console.WriteLine(inv.ToString("c"));
                }

                Console.WriteLine($"Total: {total.ToString("c")}");
                Console.WriteLine($"Average: {invoices.Average()}");

                Console.Write("Restart (Y/N): ");

                choice = Console.ReadLine().ToLower() == "y";
            }

            Console.WriteLine("Goodbye");
            Console.ReadLine();
        }
    }
}
