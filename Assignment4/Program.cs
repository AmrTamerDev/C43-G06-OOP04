namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Result1 = Calculator.Sum(5, 6);
            int Result2 = Calculator.Sum(10, 6);
            double Result3 = Calculator.Sum(5.5, 6.6);

            Console.WriteLine(Result1);
            Console.WriteLine(Result2);
            Console.WriteLine(Result3);
        }
    }
}
