namespace AnimalInheritance
{
    // base Class 
    class Animal
    {
        private string name; // only accessible within this class
        protected string type; // accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }
    class Elephant : Animal
    {
        public int weight;
        public int height;
        private string temperament;
        public void setTemperament(string temperament)
        {
            this.temperament = temperament;
        }
        public virtual string getTemperament()
        {
            return this.temperament;
        }
        public override string getName()
        {
            return base.getName();
        }
        public override string getType()
        {
            return base.getType();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // base class object
            Animal animal = new Animal();
            animal.setName("Dash");
            animal.setType("Grayhound");
            // color can be accessed anywhere - it's public
            animal.color = "gray";

            Console.WriteLine($">> Displaying animal information");
            Console.WriteLine($"Name: {animal.getName()}");
            Console.WriteLine($"Type: {animal.getType()}");
            Console.WriteLine($"Color: {animal.color}");
            Console.WriteLine();

            // object of derived class Elephant
            Elephant elephant = new Elephant();
            elephant.setName("Dumbo");
            elephant.setType("african");
            // color can be accessed anywhere - it's public
            elephant.color = "gray";
            elephant.weight = 13000;
            elephant.height = 12;
            // temperament is protected - it can't be altered publicly like color
            elephant.setTemperament("bullish");

            Console.WriteLine(">> Displaying elephant information");
            Console.WriteLine($"Name: {elephant.getName()}");
            Console.WriteLine($"Type: {elephant.getType()}");
            Console.WriteLine($"Color: {elephant.color}");
            Console.WriteLine($"Weight: {elephant.weight} lbs.");
            Console.WriteLine($"Height: {elephant.height} ft.");
            Console.WriteLine($"Temperament: {elephant.getTemperament()}");
        }
    }
}
