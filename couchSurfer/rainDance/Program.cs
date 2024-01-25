using System.ComponentModel;

namespace rainDance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to couch surfer. Find the best place to crash! Survive 20 rounds to win.");
            int hunger = 0, charisma = 0, sleep = 0, round = 0, choice = 0;
            Random rand = new Random();
            bool win = false;
            Console.WriteLine("Hey, couch surfer! Got a name?:");
            string name = Console.ReadLine();
            initValues(ref hunger, ref charisma, ref sleep, rand);
            returnRound(ref hunger, ref charisma, ref sleep, ref round, ref choice, ref win);
            while (hunger > 0 && charisma > 0 && sleep > 0 && win == false) 
            {
                choice = defineChoice();
                /* player choice will define where they stay.
                 * player choice one is Mike's place, with 4 potential outcomes 
                 * player choice two is Erin's place, with 4 potential outcomes 
                 * player choice three is Eddy's place, with 4 potential outcomes 
                 */ 
                if (choice == 1)
                {
                    bachelors(rand.Next(4), ref hunger, ref charisma, ref sleep);
                }
                else if (choice == 2)
                {
                    bachelors(rand.Next(4) + 4, ref hunger, ref charisma, ref sleep);
                }
                else
                    bachelors(rand.Next(4) + 8, ref hunger, ref charisma, ref sleep);
                returnRound(ref hunger, ref charisma, ref sleep, ref round, ref choice, ref win);
            }
            if (win)
                Console.WriteLine("You made it through homelessness. Great job " + name + "!");
            else if (hunger <= 0)
                Console.WriteLine("Your efforts to scrape by came to a halt. You lost by starvation.");
            else if (sleep <= 0)
                Console.WriteLine("Even the toughest of cookies need rest. You lost by exhaustion.");
            else
                Console.WriteLine("No one likes a cake without sugar. You weren't charming enough to win.");
        }

        private static void returnRound(ref int hunger, ref int charisma, ref int sleep, ref int round, ref int choice, ref bool win)
        {
            round += 1;
            Console.WriteLine();
            Console.WriteLine("----------------- Round " + round + " -----------------");
            Console.WriteLine("Sleep: " + sleep + " Hunger: " + hunger + " Charisma: " + charisma);
            Console.WriteLine();
            if (round >= 20)
            {
                win = true;
            }
            return;
        }

        private static void bachelors(int num, ref int hunger, ref int charisma, ref int sleep)
        {
            switch (num)
            {
                case 0:
                    Console.WriteLine();
                    Console.WriteLine("Mike and his wife were fighting all night. You raided a cold pizza from their fridge in the mean time.");
                    Console.WriteLine("Lose 20 sleep and 20 charisma. Gain 25 hunger points.");
                    sleep -= 20;
                    hunger += 25;
                    charisma -= 20;
                    break;
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Mike and his wife went out of town for business. You convince him to let you watch the house. You live like a king.");
                    Console.WriteLine("Gain 50 sleep, 50 hunger points, and 45 charisma");
                    sleep += 50;
                    hunger += 50;
                    charisma += 45;
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Mike makes you rake the yard to stay over. You attempt to persuade him otherwise, but he won't budge.");
                    Console.WriteLine("Gain 20 sleep, and 10 hunger points. Lose 25 charisma");
                    sleep += 20;
                    hunger -= 30;
                    charisma -= 25;
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Mike's parents are staying over. He forces you to sleep in his freezing basement so they don't think less of him. You keep your spirits about you.");
                    Console.WriteLine("Lose 15 sleep, and 10 hunger points. Gain 20 charisma");
                    sleep -= 15;
                    hunger -= 10;
                    charisma += 20;
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Erin says you can stay over if you buy him drinks at the corner store. It's already 1:00 AM... Nothing ventured nothing gained.");
                    Console.WriteLine("Lose 25 sleep and 15 hunger points. Gain 25 charisma.");
                    sleep -= 25;
                    hunger -= 15;
                    charisma += 25;
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("When you get to Erin's house you notice a smell like burning noodles and molding cheese. The smell lingers all night. You don't eat.");
                    Console.WriteLine("Lose 15 sleep and 25 hunger.");
                    sleep -= 15;
                    hunger -= 25;
                    break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine("Erin throws a party with a particularly ecentric group of friends. You meet someone interesting and get their number! Score.");
                    Console.WriteLine("Lose 10 sleep. Gain 20 huner points and 35 charisma.");
                    sleep -= 10;
                    hunger += 20;
                    charisma += 35;
                    break;
                case 7:
                    Console.WriteLine();
                    Console.WriteLine("Erin's house is full of dwarves and elves when you arrive. You remember Erin's kids visit on the weekends. You come back later.");
                    Console.WriteLine("Lose 15 sleep, 10 hunger points, and 20 charisma.");
                    sleep -= 15;
                    hunger -= 10;
                    charisma -= 20;
                    break;
                case 8:
                    Console.WriteLine();
                    Console.WriteLine("Eddy challenges you to a duel when you arrive. You win, you stay over. You choose Raiden. He chooses Sub-Zero. You win.");
                    Console.WriteLine("Gain 25 sleep, 15 hunger points, and 20 charisma.");
                    sleep += 25;
                    hunger += 15;
                    charisma += 20;
                    break;
                case 9:
                    Console.WriteLine();
                    Console.WriteLine("Eddy's girlfriend is over when you arrive. They leave you to go to Olive Garden. The fridge is bare.");
                    Console.WriteLine("Gain 15 sleep. Lose 20 hunger points.");
                    sleep += 15;
                    hunger -= 20;
                    charisma -= 10;
                    break;
                case 10:
                    Console.WriteLine();
                    Console.WriteLine("Eddy let's you stay over. Nothing out of the ordinary. A clap of thunder wakes you in the middle of the night.");
                    Console.WriteLine("Lose 10 sleep. Gain 10 hunger points.");
                    sleep += 10;
                    hunger += 10;
                    break;
                case 11:
                    Console.WriteLine();
                    Console.WriteLine("Eddy is passing a kidney stone and you're forced to drive him to the E.R. Some say it's worse than child birth.");
                    Console.WriteLine("Lose 15 sleep and 20 hunger points. Gain 10 charisma.");
                    sleep -= 15;
                    hunger -= 20;
                    charisma += 10;
                    break;
            }
        }
        private static int defineChoice()
        {
            Console.WriteLine("Mike, Erin, and Eddy are all willing to let you crash at their place. Where will you stay tonight? Choose 1 for Mike, 2 for Erin, or 3 for Eddy.");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Remember, 1 for Mike's place, 2 for Erin's, or 3 for Eddy's");
                choice = int.Parse(Console.ReadLine());
            }
            return choice;
        }
        private static void initValues(ref int hunger, ref int charisma, ref int sleep, Random rand)
        {
            hunger = rand.Next(50) + 50;
            charisma = rand.Next(75) + 25;
            sleep = rand.Next(80) + 20;
            return;
        }
    }
}
