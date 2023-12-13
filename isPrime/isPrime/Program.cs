using System;

//Шедеврокомментарий
class Program
{
    static void Main()
    {
        int num;
        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num))
        {
            Console.WriteLine(num + " is a prime number");
        }
        else
        {
            Console.WriteLine(num + " is not a prime number");
        }
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