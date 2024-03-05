namespace clubMemberIndexer
{
    internal class Program
    {
        public const int Size = 5;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
            }
            //indexer get and set methods
            public string this[int index]
            {
                get
                {
                    string tmp;
                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = Members[index];
                    }
                    return tmp;
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            ClubMembers Baristas = new ClubMembers();
            Baristas[0] = "John";
            Baristas[1] = "Gretchen";
            Baristas[2] = "Frenchy";
            Baristas[3] = "Boston";
            Baristas[4] = "Art";
            Baristas.ClubType = "Coffee";
            Baristas.ClubLocation = "The Commons";
            Baristas.MeetingDate = "Saturdays @ 6:00am";
            
            // iterate through class to display names
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine(Baristas[i]);
            }
            Console.WriteLine(); // space
            Console.WriteLine(Baristas.ClubType);
            Console.WriteLine(Baristas.ClubLocation);
            Console.WriteLine(Baristas.MeetingDate);
        }
    }
}
