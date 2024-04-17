using System;

namespace Homework6
{
    internal class ITDeveliper : Worker
    {
        public string Company { get; set; }
        public ITDeveliper(string company, string name, DateTime age) : base(name, age)
        {
            Company = company;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Company: {Company}, {base.ToString()}";
        }
    }
}
