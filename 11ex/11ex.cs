using System;
internal class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        if (a.Length > b.Length)
        {
            int k = 0;
            for(int i = 0; i != b.Length; i++)
            {
                if (a[i] == b[i])
                {
                    k++;
                }
                else
                {
                    k = -1;
                    break;
                }
            }
            if (k != -1)
            {
                Console.WriteLine("Yeas, "+a+" contains "+b);
                return;
            }
        }
        else
        {
            int k = 0;
            for (int i = 0; i != a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    k++;
                }
                else
                {
                    k = -1;
                    break;
                }
            }
            if (k != -1)
            {
                Console.WriteLine("Yeas, " + b + " contains " + a);
                return;
            }
        }

        for(int i = 0; i != a.Length; i++)
        {
            for(int y = 0; y != b.Length; y++)
            {
                if (a[i] == b[y])
                {
                    Console.WriteLine("Yes, both of them have " + a[i]);
                    return;
                }
            }
        }
        Console.WriteLine("Nothing");
    }
}

