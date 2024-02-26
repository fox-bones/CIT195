using System.ComponentModel;
using System.Reflection.Metadata;

namespace MusicClub
{
    interface IClub
    {
        public string Name { get; set; }
        public int Age { get; set; }
        void Relay();
    }
    internal class Program
    {
        class BandMember : IClub
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Instrument {  get; set; }
            public BandMember() {
                Name = string.Empty;
                Age = 0;
                Instrument = string.Empty;
            }
            public BandMember(string name, int age, string inst) {
                Name = name;
                Age = age;
                Instrument = inst;
            }
            public void Relay()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
                Console.WriteLine("Instrument: " + Instrument);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many members are you adding?");
            int InputAmount = int.Parse(Console.ReadLine());
            var members = new List<BandMember>();
            for (int i = 0; i < InputAmount; i++)
            {
                members.Add(new BandMember());
            }
            for (int i = 0; i < members.Count; i++)
            {
                Console.WriteLine("Enter member " + (i + 1) + "'s name: ");
                members[i].Name = Console.ReadLine();
                Console.WriteLine("Enter member " + (i + 1) + "'s age: ");
                members[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter member " + (i + 1) + "'s instrument: ");
                members[i].Instrument = Console.ReadLine();
            }
            Console.WriteLine();
            for (int i = 0; i < members.Count; i++)
            {
                members[i].Relay();
            }
        }
    }
}
