using System;

class Program
{
    
    static bool IsPowerOfTwo(int n)
    {
        
        if (n == 1)
            return true;

        
        if (n <= 0 || n % 2 != 0)
            return false;

        
        return IsPowerOfTwo(n / 2);
    }

    static void Main(string[] args)
    {
        Console.Write("Въведете число: ");
        int num = int.Parse(Console.ReadLine());

        if (IsPowerOfTwo(num))
            Console.WriteLine($"{num} е степен на 2.");
        else
            Console.WriteLine($"{num} не е степен на 2.");
    }
}