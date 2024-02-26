using System.ComponentModel;
using System.Reflection;

namespace SealedClass
{
    interface IEmployee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string Fullname();
        public double Pay();
    }
    internal class Program
    {
        class Employee : IEmployee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Employee()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            public Employee(int id, string firstName, string lastName)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
            }
            public string Fullname()
            {
                return FirstName + " " + LastName;
            }
            public virtual double Pay()
            {
                double salary;
                Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
                salary = double.Parse(Console.ReadLine());
                return salary;
            }
            public void Relay()
            {
                Console.WriteLine("Id: " + Id);
                Console.WriteLine("Name: " + this.Fullname());
            }
        }
        sealed class Executive : Employee
        {
            public string Title { get; set; }
            public double Salary { get; set; }
            public Executive() : base()
            {
                Title = string.Empty;
                Salary = 0;
            }
            public Executive(int id, string firstName, string lastName, string title, double salary) 
                : base(id, firstName, lastName)
            {
                Title = title;
                Salary = salary;
            }
            public override double Pay()
            {
                double salary;
                Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
                salary = double.Parse(Console.ReadLine());
                return salary;
            }
            public void Relay()
            {
                Console.WriteLine("Id: " + Id);
                Console.WriteLine("Name: " + this.Fullname());
                Console.WriteLine("Title: " +  Title);
                Console.WriteLine("Salary: " + Salary);
            }
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "Jhin", "Mudra");
            Executive vP = new Executive(2, "Gretchen", "Bramble", "Vice President", 200000);
            emp1.Relay();
            Console.WriteLine();
            vP.Relay();
        }
    }
}
