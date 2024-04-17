using System;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money sum1 = new Money();
            Console.WriteLine(sum1.ToString());

            Money sum2 = new Money("$", 1000, 01);
            Console.WriteLine(sum2.ToString());

            Product product1 = new Product();
            Console.WriteLine(product1.ToString());

            Product product2 = new Product("book", "$", 20, 35);
            product2.Discont = 10;
            Console.WriteLine(product2.ToString());

            product2.ApplyDiscount();
            Console.WriteLine(product2.ToString());

            Irion irion1 = new Irion("Bosch","Irion", "Irion description");

            Console.WriteLine(irion1.ToString());
            irion1.SoundIron();

            ITDeveliper dev1 = new ITDeveliper("Google", "Tretjacova", new DateTime(1972, 12, 29));

            Console.WriteLine(dev1.ToString());


            Console.ReadLine();
        }
    }
}
