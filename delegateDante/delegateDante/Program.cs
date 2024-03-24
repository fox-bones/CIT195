using System.Net.NetworkInformation;

namespace delegateDante
{
    internal class Program
    {
        public delegate void InfernoQuotes();
        public class Quotes
        {
            public static void andI()
            {
                Console.WriteLine("\"And I — my head oppressed by horror — said:");
                Console.WriteLine("\"Master, what is it that I hear? Who are");
                Console.WriteLine("those people so defeated by their pain?\"");
            }
            public static void andMe()
            {
                Console.WriteLine("And he to me: \"This miserable way");
                Console.WriteLine("is taken by the sorry souls of those");
                Console.WriteLine("who lived without disgrace and without praise.");
            }
            public static void they()
            {
                Console.WriteLine("They now commingle with the coward angels,");
                Console.WriteLine("the company of those who were not rebels");
                Console.WriteLine("nor faithful to their God, but stood apart.");
            }
            public static void theHeavens()
            {
                Console.WriteLine("The heavens, that their beauty not be lessened,");
                Console.WriteLine("have cast them out, nor will deep Hell receive them —");
                Console.WriteLine("even the wicked cannot glory in them.\"");
            }
            public static void author()
            {
                Console.WriteLine("Dante Alighieri");
                Console.WriteLine();
            }
            public static void title()
            {
                Console.WriteLine("Inferno");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // creating multicast object
            InfernoQuotes quoteObj = new InfernoQuotes(Quotes.title);
            // adding methods
            quoteObj += Quotes.author;
            quoteObj += Quotes.andI;
            quoteObj += Quotes.andMe;
            quoteObj += Quotes.they;
            quoteObj += Quotes.theHeavens;
            // calling multicast obj
            quoteObj();
        }
    }
}
