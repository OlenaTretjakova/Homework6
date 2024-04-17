namespace Homework6
{
    internal class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public  virtual string ToString() => $"It is base class Device {Name} , {Description}";
    }


}
