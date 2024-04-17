using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    internal class Irion:Device
    {
        public string Brend { get; set; }

        public Irion(string brend, string name, string description) : base(name, description)
        {
            Brend = brend;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"It is class Iron {base.ToString()}"; 
        }

        public void SoundIron()
        {
            Console.WriteLine("Sound iron.");
        }
    }
}
