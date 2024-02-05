namespace myProject
{
    class Character
    {
        private int _id;
        private string _name;
        private string _race;
        private int _age;

        public Character()
        {
            _id = 0;
            _name = string.Empty;
            _race = string.Empty;
            _age = 0;
        }
        public Character(int id, string name, string race, int age)
        {
            _id = id;
            _name = name;
            _race = race;
            _age = age;
        }

        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            _id = id;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetRace()
        {
            return _race;
        }
        public void SetRace(string race)
        {
            _race = race;
        }
        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Character aggy = new Character(003, "Aggy the Crushing", "Dwarf", 68);
            Character brooch = new Character(004, "Brooch of Iron Knuckle", "Dwarf", 73);
            Character player = new Character();
            Character follower = new Character();

            Console.WriteLine("Welcome to character creation. Here, you'll create a character and a follower.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey(true);
            Console.WriteLine();

            player.SetId(001);
            follower.SetId(002);
            Console.WriteLine("Dwarf, Elf, Human, or Felis");
            Console.WriteLine("Choose your race, traveller: ");
            player.SetRace(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("What do the people of the world call you?: ");
            player.SetName(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Interesting... How many winters have you endured?");
            player.SetAge(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine($"{player.GetName()}... Such a peculiar name! ");
            Console.WriteLine();

            Console.WriteLine("Press any key to create your follower:");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("Dawrf, Elf, Human, or Felis. Who shall accompany you?: ");
            follower.SetRace(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Choose a name for your companion: ");
            follower.SetName(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"I see... How many years has {follower.GetName()} walked the lands?: ");
            follower.SetAge(int.Parse(Console.ReadLine()));
            Console.WriteLine();

            Console.WriteLine("Here's a recap of what you told me:");
            Console.WriteLine();
            Console.WriteLine($"Player name: {player.GetName()}");
            Console.WriteLine($"Player race: {player.GetRace()}");
            Console.WriteLine($"Player age: {player.GetAge()}");
            Console.WriteLine();
            Console.WriteLine($"Follower name: {follower.GetName()}");
            Console.WriteLine($"Follower race: {follower.GetRace()}");
            Console.WriteLine($"Follower age: {follower.GetAge()}");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue:");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.Write("Along your journey, you will be accompanied by two dwarves from the Iron Plains. They plainly hand you their information on parchment as you approach the dock of the ship you'll be taking across the Baron Sea.");
            Console.WriteLine();
            Console.WriteLine($"{aggy.GetName()}, the {aggy.GetRace()}. Avid sailor and professional trapper. At the service of the world for {aggy.GetAge()} years.");
            Console.WriteLine("and");
            Console.WriteLine($"{brooch.GetName()}, the {brooch.GetRace()}. A hammer weilder of the Iron Plains. His warrior spirit has burned for {brooch.GetAge()} years.");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine("Best of luck to you on your travels! May you live long and prosper.");
        }
    }
}
