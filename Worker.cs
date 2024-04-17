using System;

namespace Homework6
{
    internal abstract class Worker
    {
        public string Name { get; set; }
        public DateTime Age { get; set; }

        public Worker(string name, DateTime aga)
        {
            Name = name;
            Age = aga;
        }
        public override string ToString()
        {
            return $"name:{Name}, aga:{Age}";
        }
    }


}
