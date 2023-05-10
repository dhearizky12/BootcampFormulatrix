using System;
namespace GenericsDemo
{
    public class ClsMain
    {
        private static void Main()
        {
            bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            bool IsEqual2 = ClsCalculator.AreEqual<int>(10, 10);

            // Cetak IsEqual
            for (int i = 0; i < 1; i++)
            {
                if (IsEqual)
                { Console.WriteLine("Both are Equal"); }
                else
                { Console.WriteLine("Both are Not Equal"); }
            }

            // Cetak IsEqual2
            for (int i = 0; i < 1; i++)
            {
                if (IsEqual2)
                { Console.WriteLine("Both are Equal2"); }
                else
                { Console.WriteLine("Both are Not Equal2"); }
            }
        }
    }

    public class ClsCalculator
    {
        //TAKE INT 
        //public static bool AreEqual(int value1, int value2)
        //{
        //    return value1 == value2;
        //}
        public static bool AreEqual<T>(T value1, T value2)
        { return value1.Equals(value2); }

    }
}

