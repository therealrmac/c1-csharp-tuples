using System;
using System.Collections.Generic;

namespace tuples2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("Hammer", 7.99, 10));
            transactions.Add(("Beans", 1.99, 20));
            transactions.Add(("Bacon", 4.99, 12));
            transactions.Add(("Tape", 2.99, 8));
            transactions.Add(("Water", 5.99, 10));

            int totalQuant=0;
            double totalPrice=0;
            foreach ((string product, double amount, int quantity) t in transactions)
            {
                totalQuant+= t.quantity;
                totalPrice+= t.amount* t.quantity;
                //Console.WriteLine(t.product);
                
            }
            Console.WriteLine("Total items sold: "+totalQuant);
            Console.WriteLine("Total price was: $"+totalPrice);
        }
    }
}
