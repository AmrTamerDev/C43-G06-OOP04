namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int Result1 = Calculator.Sum(5, 6);
            //int Result2 = Calculator.Sum(10, 6);
            //double Result3 = Calculator.Sum(5.5, 6.6);

            //Console.WriteLine(Result1);
            //Console.WriteLine(Result2);
            //Console.WriteLine(Result3);

            //Rectangle rectangle1 = new Rectangle();
            //Console.WriteLine(rectangle1);

            //Rectangle rectangle2 = new Rectangle(1,2);
            //Console.WriteLine(rectangle2);

            //Rectangle rectangle3 = new Rectangle(1);
            //Console.WriteLine(rectangle3);

            //ComplexNumber complexNumber1 = new ComplexNumber();
            //ComplexNumber complexNumber2 = new ComplexNumber();
            //ComplexNumber complexNumber3 = new ComplexNumber();
            //ComplexNumber complexNumber4 = new ComplexNumber();

            //complexNumber1.Real = 10;
            //complexNumber2.Real = 20;

            //complexNumber1.Imaginary = 30;
            //complexNumber2.Imaginary = 40;

            //complexNumber3 = complexNumber1 + complexNumber2;
            //complexNumber4 = complexNumber1 - complexNumber2;

            //Console.WriteLine(complexNumber3);
            //Console.WriteLine(complexNumber4);

            //Manager manager = new Manager();
            //manager.Work();

            //Employee employee = new Employee();
            //employee.Work();

            //BaseClass baseClass = new BaseClass();
            //baseClass.DisplayMessage();

            //BaseClass baseClass1 = new DerivedClass1();
            //baseClass1.DisplayMessage();

            //BaseClass baseClass2 = new DerivedClass2();
            //baseClass2.DisplayMessage();

            Duration D1 = new Duration(1, 10, 15);
            D1.ToString();
            Console.WriteLine(D1);

            Duration D2 = new Duration(3600);
            D2.ToString();
            Console.WriteLine(D2);

            Duration D3 = new Duration(7800);
            D3.ToString();
            Console.WriteLine(D3);

            Duration D4 = new Duration(666);
            D4.ToString();
            Console.WriteLine(D4);

            D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3);

            D3 = --D2;
            Console.WriteLine(D3);

            D3 = D1 - D2;
            Console.WriteLine(D3);

            if (D1 > D2)
                Console.WriteLine("D1 is bigger");
            else
                Console.WriteLine("D2 is bigger");

            if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal");
            else
                Console.WriteLine("D2 is bigger");
        }
    }
}
