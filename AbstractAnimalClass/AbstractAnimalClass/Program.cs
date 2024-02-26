namespace AbstractAnimalClass
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }
    internal class Program
    {
        class Cat : Animal
        {
            public override string Name { get; set; }
            public string Color { get; set; }
            public int Age { get; set; }
            public string Type { get; set; }
            public Cat()
            {
                Name = string.Empty;
                Color = string.Empty;
                Age = 0;
                Type = string.Empty;
            }
            public Cat(string name, string color, int age, string type)
            {
                Name = name;
                Color = color;
                Age = age;
                Type = type;
            }
            public override string Describe()
            {
                return "I am a " + Type + "\nMy name is " + Name + "\nI'm a noteable " + Color + " color" +
                    "\nI'm " + Age + " years old";
            }
        }
        static void Main(string[] args)
        {
            Cat hermes = new Cat();
            hermes.Name = "Hermes";
            hermes.Color = "black";
            hermes.Age = 3;
            hermes.Type = "cat";
            Cat tart = new Cat("Tart", "tabi", 3, "cat");
            Console.WriteLine(hermes.Describe());
            Console.WriteLine();
            Console.WriteLine(tart.Describe());
        }
    }
}
