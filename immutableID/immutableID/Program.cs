namespace immutableID
{
    internal class Program
    {
        class Student
        {
            // auto-implemented properties
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }
            // parameterized constructor
            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
            public Student(int i)
            {
                Id = i;
                FirstName = "";
                LastName = "";
            }

        }
        static void Main(string[] args)
        {
            Student a0001 = new Student(1);
            a0001.FirstName = "Gretchen";
            a0001.LastName = "Briar";
            Student a0002 = new Student(2, "Richard", "Martin");
            
            Console.WriteLine(a0001.Id);
            Console.WriteLine(a0001.FirstName);
            Console.WriteLine(a0001.LastName);
            Console.WriteLine();
            Console.WriteLine(a0002.Id);
            Console.WriteLine(a0002.FirstName);
            Console.WriteLine(a0002.LastName);
        }
    }
}
