namespace SimpleInheritance
{
    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }
    // derived class of Animal 
    class Penguin : Animal
    {
        public double age;
        public double weight;
        public string type;
        public Penguin()
            : base()
        {
            age = 0;
            weight = 0;
            type = "";
        }
        public Penguin(string name, int age, int weight, string type)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.type = type;
        }
        public void getName()
        {
            Console.WriteLine($"May name is {name}.");
        }
        public void sound()
        {
            Console.WriteLine("I like to quack.");
        }
        public void getAge()
        {
            Console.WriteLine($"I am {age} years old.");
        }
        public void getWeight()
        {
            Console.WriteLine($"I weigh {weight} pounds.");
        }
        public void getType()
        {
            Console.WriteLine($"I'm a {type} penguin.");
        }
        public void display()
        {
            getName();
            sound();
            getAge();
            getType();
            getWeight();
        }
    }
    class Cat : Animal
    {
        public int age;
        public string color;
        public int weight;

        public Cat() 
            :base()
        {
            name = "";
            age = 0;
            color = "";
            weight = 0;
        }
        public Cat(string name, int age, string color, int weight)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.weight = weight;
        }
        public void display()
        {
            Console.WriteLine($">> Displaying Cat Record");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Weight: {weight} lbs.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Penguin emperor = new Penguin();
            emperor.name = "Biggie";
            emperor.type = "emperor";
            emperor.age = 8;
            emperor.weight = 52; 
            emperor.display();
            Console.WriteLine();

            // derived class object using parameterized constructor
            Penguin macaroni = new Penguin("Max", 14, 10, "macaroni");
            macaroni.display();
            Console.WriteLine();

            // another derived class object using default constructor
            Cat hermes = new Cat();
            hermes.name = "Hermes";
            hermes.age = 3;
            hermes.color = "black";
            hermes.weight = 9;
            hermes.display();
            Console.WriteLine();

            // another derived class object using parameterized constructor
            Cat tart = new Cat("Tart", 2, "Tabi", 10);
            tart.display();
        }

    }
}
