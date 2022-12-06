using System;
internal class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        for (int i = a.Length - 1; i > -1; i--)
        {
            Console.Write(a[i]);
        }
    }
}

