namespace mathDelegates
{
    public delegate void MathDelegate(double a, double b);
    public class MathSolutions
    {
        /*public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }*/
        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($"{a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($"{b} is smaller than {a}");
            else
                Console.WriteLine($"{b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Action<double, double> Sum = delegate (double x, double y) { Console.WriteLine(x + y); };
            Func <double, double, double> Product = delegate (double a, double b) { return a * b; };
            MathDelegate smallerDelegate = new MathDelegate(answer.GetSmaller);
            Sum(num1, num2);
            Console.WriteLine(Product(num1, num2));
            smallerDelegate(num1, num2);
        }
    }
}
