using System;

namespace Homework6
{
    internal class Product : Money
    {
        public string Name { get; set; } = string.Empty;

        public Money Price { get; set; } 

        public int Discont {  get; set; }

        public Product() { }

        public Product(string name)
        {
            this.Name = name;
            this.Price = new Money();

        }

        public Product(string name, string valute, int wholePart, int fractionalPart) : this(name)
        {
            this.Price = new Money(valute, wholePart, fractionalPart);
        }

        public override string ToString()
        {
            return ($"{this.Name} : {this.Price}");
        }

        public void ApplyDiscount()
        {
            if (Discont >= 0 )
            {
                this.Price.Discount(Discont);
            }
            else
            {
                Console.WriteLine("Discount percentage must be more then 0 .");
            }
        }
    }
}
