namespace myParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("How many random numbers would you like to generate?");
            int values = int.Parse(Console.ReadLine());
            int[] numbers = new int[values];
            for (int i = 0; i < values; i++)
            {
                numbers[i] = r.Next(1, 10);
            }
            foreach (var item in  numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Adding all numbers yields: {Add(numbers)}");
            Console.WriteLine($"Multiplying all numbers yields: {Mult(numbers)}");
        }
        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }
        static int Mult(params int[] numbers)
        {
            int total = 1;
            foreach (int number in numbers)
            {
                total *= number;
            }
            return total;
        }
    }
}
