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
            Console.WriteLine("Band members: ");
            Console.WriteLine();
            BandMember stacy = new BandMember("Stacy", 28, "Vocals");
            BandMember ed = new BandMember("Ed", 35, "Guitar");
            BandMember chris = new BandMember("Chris", 22, "Bass");
            BandMember aaron = new BandMember("Aaron", 31, "Keys");
            stacy.Relay();
            ed.Relay();
            chris.Relay();
            aaron.Relay();
        }
    }
}
