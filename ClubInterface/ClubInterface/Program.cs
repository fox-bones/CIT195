namespace ClubInterface
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
    }
    internal class Program
    {
        class ChessClub : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Age { get; set; }
            public ChessClub()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Wins = 0;
                Losses = 0;
                Age = 0;
            }
            public ChessClub(int id, string firstName, string lastName, int wins, int losses, int age)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Wins = wins;
                Losses = losses;
                Age = age;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public void Relay()
            {
                Console.WriteLine("ID: " + Id);
                Console.WriteLine("Name: " + this.Fullname());
                Console.WriteLine("Wins: " + Wins);
                Console.WriteLine("Losses: " + Losses);
                Console.WriteLine("Age: " + Age);
            }
        }
        static void Main(string[] args)
        {
            ChessClub member1 = new ChessClub(1, "Roger", "Rabbit", 34, 23, 32);
            member1.Relay();
        }
    }
}
