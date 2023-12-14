using System.Diagnostics;
using System;
public class Program
{
    static void Main()
    {
        Debug.Assert(IsPrime(3) == true);
        Debug.Assert(IsPrime(6) == false);
        Debug.Assert(IsPrime(73) == true);
    }
    public static bool IsPrime(int x)
    {
        if (x <= 1) return false;
        if (x == 2) return true;
        if (x % 2 == 0) return false;
        for (int i = 3; i <= Math.Sqrt(x); i += 2) {if (x % i == 0) { return false; } }
        return true;
    }
}