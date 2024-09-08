using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace numbersCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue tracker: ");
            Queue<int> waitingLine = new Queue<int>();
            // adding items to queue
            waitingLine.Enqueue(1);
            waitingLine.Enqueue(2);
            waitingLine.Enqueue(3);
            waitingLine.Enqueue(4);
            waitingLine.Enqueue(5);
            if (waitingLine.Contains(2))
            {
                Console.WriteLine("There is more than one in queue");
            }
            // removing first in queue 
            Console.WriteLine("Now assisting the next in queue, #" + waitingLine.Dequeue());
            // displaying queue count
            Console.WriteLine("There are currently " + waitingLine.Count + " in queue.");
            Console.WriteLine(); // break!

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Priority queue musical sales: ");
            PriorityQueue<string, int> hotItems = new PriorityQueue<string, int>();
            // adding items to priority queue
            hotItems.Enqueue("Stage Microphone", 3);
            hotItems.Enqueue("Audio Interface", 2);
            hotItems.Enqueue("Mixer", 1);
            hotItems.Enqueue("Cort Bass Guitar", 3);
            hotItems.Enqueue("Set of congas", 2);
            // displaying and removing items with the highest to lowest priority 
            Console.WriteLine("Sold " + hotItems.Dequeue());
            Console.WriteLine("Sold " + hotItems.Dequeue());
            Console.WriteLine("Sold " + hotItems.Dequeue());
            Console.WriteLine("Sold " + hotItems.Dequeue());
            Console.WriteLine("Sold " + hotItems.Dequeue());
            Console.WriteLine("There are " + hotItems.Count + " items left in stock");
            Console.WriteLine(); // break!

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Number stack monitor: ");
            Stack<int> numberStack = new Stack<int>();
            // adding numbers to stack
            numberStack.Push(1);
            numberStack.Push(2);
            numberStack.Push(3);
            numberStack.Push(4);
            numberStack.Push(5);
            // checking if the stack is present
            if (numberStack.Contains(1))
            {
                Console.WriteLine("The stack is present");
            }
            // removing the last item from the stack
            Console.WriteLine("Removing " + numberStack.Pop() + " from the stack");
            Console.WriteLine("There are now " + numberStack.Count + " items in the stack.");
            // concatenating all stack items to be displayed
            Console.WriteLine("Remaining items in stack: " + String.Join(",", numberStack));
            Console.WriteLine(); // break!
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Rainbow linked list: ");
            string[] words = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            LinkedList<string> rainbow = new LinkedList<string>(words);
            LinkedListNode<string> node = rainbow.Find("green");
            Console.WriteLine("The first color of the rainbow: " + rainbow.First());
            Console.WriteLine("The last color of the rainbow: " + rainbow.Last());
            Console.WriteLine("Adding a new color.... ");
            rainbow.AddBefore(node, "chartreuse");
            Console.WriteLine("Removing violet...");
            rainbow.RemoveLast();
            Console.WriteLine("Remaining colors in the rainbow: " + rainbow.Count);
            foreach (string color in rainbow)
            {
                Console.WriteLine(color);
            }
            Console.WriteLine(); // break!

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Instrument dictionary: ");
            Dictionary<string, string> instruments = new Dictionary<string, string>();
            instruments.Add("Drums", "Percussion");
            instruments.Add("Guitar", "Strings");
            instruments.Add("Piano", "Strings");
            instruments.Add("Flute", "Woodwind");
            instruments.Add("Trumpet", "Brass");

            Console.WriteLine("Instrument list keys: ");
            Dictionary<string, string>.KeyCollection keys = instruments.Keys;
            foreach (string k in keys)
            {
                Console.WriteLine("Key: {0}", k);
            }
            Console.WriteLine();

            Console.WriteLine("Instrument list values: ");
            Dictionary<string, string>.ValueCollection values = instruments.Values;
            foreach (string v in values)
            {
                Console.WriteLine("Value: {0}", v);
            }
            Console.WriteLine();
            Console.WriteLine("Instruments list Key/Value Pairs");
            foreach (KeyValuePair<string, string> kvp in instruments)
            {
                Console.WriteLine($"Key: {kvp.Key}  Value: {kvp.Value}");
            }
            Console.WriteLine("Removing trumpet/brass pair from dictionary...");
            instruments.Remove("Trumpet");
            Console.WriteLine("Remaining dictionary items: " + instruments.Count);
            Console.WriteLine(); // break!

            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Sorted list... Add an int and name it with a string. Ex. 6 = 'six'");
            SortedList<int, string> numberName = new SortedList<int, string>();
            numberName.Add(1, "one");
            numberName.Add(2, "two");
            numberName.Add(3, "three");
            numberName.Add(4, "four");
            numberName.Add(5, "five");
            Console.WriteLine("Add another pair starting with an int: ");
            int userInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Add a corresponding string to name the int: ");
            string userString = Console.ReadLine();
            if (numberName.ContainsValue(userString))
                Console.WriteLine($"{userInt} is one of the values in your list");
            else
            {
                // check for userInt key in list (can't have dups)
                if (numberName.ContainsKey(userInt))
                {
                    Console.WriteLine($"{userInt} is an already existing key");
                    numberName.Remove(userInt);
                    numberName.Add(userInt, userString);
                    Console.WriteLine($"Your current number {userInt} has been removed and {userString} has been added");
                }
                else
                {
                    numberName.Add(userInt, userString);
                    Console.WriteLine($"{userInt} {userString} was added to your list");
                }
                foreach (KeyValuePair<int, string> bl in numberName)
                {
                    Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
                }
                Console.WriteLine(); // break!

            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Hashset roots: ");
            HashSet<string> roots = new HashSet<string>();
            roots.Add("onion");
            roots.Add("shallots");
            roots.Add("garlic");
            roots.Add("chives");
            roots.Add("leeks");
            HashSet<string> tubers = new HashSet<string>();
            tubers.Add("potato");
            tubers.Add("yam");
            tubers.Add("ginger");
            tubers.Add("radish");
            tubers.Add("wasabi");
            HashSet<string> others = new HashSet<string>();
            others.Add("carrots");
            others.Add("turnips");
            others.Add("ginger");
            others.Add("potato");
            others.Add("turmeric");
            roots.UnionWith(tubers);
            foreach (string root in roots)
            {
                Console.WriteLine(root);
            }
            Console.WriteLine();
            HashSet<string> dups = new HashSet<string>();
            dups = others;
            dups.IntersectWith(tubers);
            Console.WriteLine("Duplicates: ");
            foreach (string dup in dups)
            {
                Console.WriteLine(dup);
            }
            Console.WriteLine(); // break!
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            List<string> musicalNotes = new List<string>();
            musicalNotes.Add("A");
            musicalNotes.Add("B");
            musicalNotes.Add("C");
            musicalNotes.Add("D");
            musicalNotes.Add("E");
            string[] sharps = { "A#", "B#", "C#" };
            musicalNotes.AddRange(sharps);
            musicalNotes.Sort();
            Console.WriteLine("Collection of some notes on a keyboard: ");
            foreach (string note in musicalNotes)
            {
                Console.WriteLine(note);
            }
            Console.WriteLine();
            musicalNotes.Remove("E");
            musicalNotes.Reverse();
            Console.WriteLine("Reversed order, with E removed: ");
            foreach (string note in musicalNotes)
            {
                Console.WriteLine(note);
            }
        }
    }
}
