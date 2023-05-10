namespace MyProgram
{
    public delegate TResult MyDelegate<T1, T2, TResult>(T1 a, T2 b);

    class Program2
    {
        static void Main(string[] args)
        {
            MyDelegate<int, int, int> addDelegate = Kalkulator1.Add;
            MyDelegate<double, int, double> multiplyDelegate = Kalkulator1.Multiply;
            int result1 = addDelegate(3, 2);
            var result2 = multiplyDelegate(3.4, 2);

            Console.WriteLine("Result of addDelegate: " + result1);
            Console.WriteLine("Result of multiplyDelegate: " + result2);
        }
    }

    // public delegate TResult MyDelegate2<T1, T2, TResult>(T1 a, T2 b);

    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         MyDelegate2<int, int, int> addDelegate = Kalkulator1.Add;
    //         MyDelegate2<double, int, double> multiplyDelegate = Kalkulator1.Multiply;
    //         int result1 = addDelegate(3, 2); // result1 will be 5
    //         var result2 = multiplyDelegate(3.4, 2); // result2 will be 6.8

    //         Console.WriteLine("Result of addDelegate: " + result1);
    //         Console.WriteLine("Result of multiplyDelegate: " + result2);
    //     }
    // }

    class Kalkulator1
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Multiply(double a, int b)
        {
            return a * b;
        }
    }
}
