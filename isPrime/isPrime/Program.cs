using System.Diagnostics;
using System;
//Обнова
class Program

{
    static void Main()
    {
        Debug.Assert(IsPrime(3) == true);
        Debug.Assert(IsPrime(6) == false);
        Debug.Assert(IsPrime(73) == true);
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}