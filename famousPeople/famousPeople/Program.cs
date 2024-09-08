namespace famousPeople
{
    internal class Program
    {
        class famousPeople
        {
            public string Name { get; set; }
            public int? BirthYear { get; set; } = null;
            public int? DeathYear { get; set; } = null;
        }
        static void Main(string[] args)
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
     };
            var after1900 = from person in stemPeople
                            where person.BirthYear > 1900
                            select person.Name;
            var containsLowerLL = from person in stemPeople
                                 where person.Name.Contains("ll")
                                 select person.Name;
            var bornAfter1950 = from person in stemPeople
                                where person.BirthYear > 1950
                                select person.Name;
            var bornX1920_2000 = from person in stemPeople
                                 where person.BirthYear > 1920
                                 where person.BirthYear < 2000
                                 orderby person.BirthYear
                                 select person.Name;
                                 
            var diedX1960_2015 = from person in stemPeople
                                 where person.DeathYear > 1960
                                 where person.DeathYear < 2015
                                 orderby person.Name
                                 select person.Name;
            var birthCount = bornX1920_2000.Count();
            Console.WriteLine("List of individuals born after 1900:");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var name in after1900)
                Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine("List of individuals whose name contains a double lowercase l - 'll':");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var name in containsLowerLL)
                Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine("List of individuals born after 1950:");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var name in bornAfter1950)
                Console.WriteLine(name);
            Console.WriteLine();
            Console.WriteLine("List of individuals born after 1920 and before 2000:");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var name in bornX1920_2000)
                Console.WriteLine(name);
            Console.WriteLine("Total in list: " + birthCount);
            Console.WriteLine();
            Console.WriteLine("List of individuals who died after 1960 and before 2015:");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var name in diedX1960_2015) 
                Console.WriteLine(name);
        }
    }
}
