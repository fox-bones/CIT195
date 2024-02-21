using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;

namespace ProtectedMultipleObjects
{
    class Cup
    {
        protected int _id;
        protected string _type;
        protected double _price;
        public Cup()
        {
            _id = 0;
            _type = "";
            _price = 0;
        }
        public Cup(int id, string type, double price)
        {
            this._id = id;
            this._type = type;
            this._price = price;
        }
        public void setId(int id) { _id = id; }
        public int getId() { return _id; }
        public void setType(string type) { _type = type; }
        public string getType() { return _type; }
        public void setPrice(double price) { _price = price; }
        public double getPrice() { return _price; }
        public virtual void makeChange()
        {
            Console.WriteLine("ID: ");
            setId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Type: ");
            setType(Console.ReadLine());
            Console.WriteLine("Price: ");
            setPrice(double.Parse(Console.ReadLine()));
        }
        public virtual void print()
        {
            Console.WriteLine();
            Console.WriteLine($"ID: {getId()}");
            Console.WriteLine($"Type: {getType()}");
            Console.WriteLine($"Price: {getPrice()}");
        }
    }
    class Mug : Cup //derived class from Cup
    {
        protected string _color;
        protected string _material;
        public Mug()
            : base()
        {
            this._color = "";
            this._material = "";
        }
        public Mug(int id, string type, double price, string color, string material)
            : base(id, type, price)
        {
            this._color = color;
            this._material = material;
        }
        public void setColor(string color) { this._color = color; }
        public string getColor() { return _color; }
        public void setMaterial(string material) { this._material = material; }
        public string getMaterial() { return _material; }
        // change method
        public override void makeChange()
        {
            base.makeChange();
            Console.WriteLine("Color: ");
            setColor(Console.ReadLine());
            Console.WriteLine("Material: ");
            setMaterial(Console.ReadLine());
        }
        public override void print()
        {
            base.print();
            Console.WriteLine($"Color: {getColor()}");
            Console.WriteLine($"Material: {getMaterial()}");
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cups would you like to add to inventory?: ");
            int maxCups;
            while (!int.TryParse(Console.ReadLine(), out maxCups))
                Console.WriteLine("Please enter a whole number");
            // array of cup objects
            Cup[] cups = new Cup[maxCups];
            Console.WriteLine("How many mugs do you want to enter?: ");
            int maxMugs;
            while (!int.TryParse(Console.ReadLine(), out maxMugs))
                Console.WriteLine("Please enter a whole number");
            // array of mug objects
            Mug[] mugs = new Mug[maxMugs];

            int choice, rec, type;
            int cupCounter = 0, mugCounter = 0;
            choice = Menu();
            while (choice != 4)
            {
                Console.WriteLine("Enter 1 for cup or 2 for mug");
                while (!int.TryParse(Console.ReadLine(), out type))
                    Console.WriteLine("1 for cup or 2 for mug");
                try
                {
                    switch (choice)
                    {
                        case 1: // adding item
                            if (type == 1) // cup
                            {
                                if (cupCounter <= maxCups)
                                {
                                    cups[cupCounter] = new Cup();
                                    cups[cupCounter].makeChange();
                                    cupCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of cups have been added");
                            }
                            else // mug
                            {
                                if (cupCounter <= maxMugs)
                                {
                                    mugs[mugCounter] = new Mug();
                                    mugs[mugCounter].makeChange();
                                    mugCounter++;
                                }
                                else
                                    Console.WriteLine("The maximum number of mugs has been added");
                            }
                            break;
                        case 2: // change
                            Console.WriteLine("Enter the record number you want to change: ");
                            while (!int.TryParse(Console.ReadLine(), out rec))
                                Console.Write("Enter the record number you want to change: ");
                            rec--;
                            if (type == 1) // cup
                            {
                                while (rec > cupCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                cups[rec].makeChange();
                            }
                            else // mug
                            {
                                while (rec > mugCounter - 1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range, try again");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the record number you want to change: ");
                                    rec--;
                                }
                                mugs[rec].makeChange();
                            }
                            break;
                        case 3: // Print all
                            if (type == 1) // cups
                            {
                                for (int i = 0; i < cupCounter; i++)
                                    cups[i].print();
                            }
                            else // Employee
                            {
                                for (int i = 0; i < mugCounter; i++)
                                    mugs[i].print();
                            }
                            break;
                        default:
                            Console.WriteLine("You made an invalid selection, please try again");
                            break;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private static int Menu()
        {
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            int selection = 0;
            while (selection < 1 || selection > 4)
                while (!int.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("1-Add  2-Change  3-Print  4-Quit");
            return selection;
        }
    }
}

