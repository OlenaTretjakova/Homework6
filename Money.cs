using System;

namespace Homework6
{
    internal  class Money
    {
        protected string NameValute { get; set; } = string.Empty;
        protected  int WholePart { get; set; } = 0;
        protected int FractionalPart { get; set; } = 0;

        public Money()
        {
            NameValute = string.Empty;
            WholePart = 0;
            FractionalPart = 0;

        }
        public Money(string name):this()
        {

            this.NameValute = name;
        }
        public Money(string name, int wholePart, int fractionalPart) : this(name)
        {
            this.WholePart = wholePart;
            this.FractionalPart = fractionalPart;
        }

        public override string ToString()
        {
            return ($"{this.WholePart},{this.FractionalPart} {this.NameValute}.");
        }

        public void Discount(int value)
        {
            int newWholePart = (int)(this.WholePart - this.WholePart * value / 100);
            this.WholePart = newWholePart;

            int newFractional = (int)(this.FractionalPart - this.FractionalPart * value /100);
            this.FractionalPart = newFractional;
        }

    }
}
