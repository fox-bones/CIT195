namespace lambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers of your choice: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            var sumResult = (int a, int b) =>
            {
                int calcSum = a + b;
                return calcSum;
            };
            var multResult = (int a, int b) =>
            {
                int calcProduct = a * b;
                return calcProduct;
            };
            var smallerNum = (int a, int b) =>
            {
                if (a > b)
                {
                    return $"{b} is smaller than {a}";
                }
                else if (a < b)
                {
                    return $"{a} is smaller than {b}";
                }
                else
                {
                    return $"{a} and {b} are the same value";
                }
            };
            Console.WriteLine($"The sum of {num1} and {num2} is {sumResult(num1, num2)}");
            Console.WriteLine($"The product of {num1} and {num2} is {multResult(num1, num2)}");
            Console.WriteLine(smallerNum(num1, num2));
        }
    }
}
