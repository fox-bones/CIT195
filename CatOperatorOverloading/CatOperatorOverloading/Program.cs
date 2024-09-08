namespace CatOperatorOverloading
{
    internal class Cat
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public Cat(string name, string breed, int age, DateTime date)
        {
            Name = name;
            Breed = breed;
            Age = age;
            Birthday = date;
        }
        public Cat()
        {
            this.Name = string.Empty;
            this.Breed = string.Empty;
            this.Age = 0;
            this.Birthday = DateTime.MinValue;
        }

        // Overload unary operators ++ and -- 
        public static Cat operator ++(Cat obj)
        {
            obj.Age++;
            return obj;
        }
        public static Cat operator --(Cat obj)
        {
            obj.Age--;
            return obj;
        }
        // Overload Comparison Operators > and <
        public static bool operator >(Cat left, Cat right)
        {
            bool larger = false;
            if (left.Age > right.Age)
                larger = true;
            return larger;
        }
        public static bool operator <(Cat left, Cat right)
        {
            bool smaller = false;
            if (left.Age < right.Age)
                smaller = true;
            return smaller;
        }
        public static Cat operator -(Cat obj)
        {
            obj.Age = -obj.Age;
            return obj;
        }
        public static Cat operator +(Cat obj, Cat obj2)
        {
            Cat newCat = new Cat();
            newCat.Age = obj2.Age + obj.Age;
            return newCat;
        }
        static void Main(string[] args)
        {
            Cat hermes = new Cat("Hermes", "Shorthair", 3, new DateTime(2021, 8, 15, 0, 00, 0));
            Cat tart = new Cat("Tart", "Tabi", 2, new DateTime(2022, 5, 15, 0, 00, 0));
            Cat willis = new Cat("Willis", "Shorthair", 0, new DateTime(2024, 5, 15, 0, 00, 0));
            List<Cat> CatList = new List<Cat>();
            CatList.Add(hermes);
            CatList.Add(tart);
            CatList.Add((willis));
            for (int i = 0; i < CatList.Count; i++)
            {
                // defaulting Age property to one year
                if (CatList[i].Age < 1)
                {
                    CatList[i].Age = 0;
                    CatList[i]++;
                    Console.WriteLine(CatList[i].Name + "'s age has been defaulted to 1");
                }
            }
            Console.WriteLine();
            // confirming universal mathematics
            Console.WriteLine("Confirming time moves forward...");
            if (hermes > tart)
                Console.WriteLine("Hermes is older than Tart. All is well with the Cosmos");
            else
                Console.WriteLine("Something happened...");
            Console.WriteLine();
            // adding up total years of all cat's lives
            int totalYears = 0;
            Console.WriteLine("Total years between all cats: ");
            for (int i = 0; i < CatList.Count; i++)
            {
                totalYears += CatList[i].Age;
                Console.WriteLine(totalYears);
            }

        }
    }
}
