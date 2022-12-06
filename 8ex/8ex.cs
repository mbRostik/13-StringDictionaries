using System;
internal class Program
{
    static void Main()
    {
        string[] a = Console.ReadLine().Split('.', ',', ':', ';', '!', '?', ' ');

        for(int i = 0; i < a.Length; i++)
        {
            int k = 0;
            string temp = a[i];
            for(int y = 0; y != a[i].Length / 2; y++)
            {
                if (temp[y] == temp[temp.Length - 1 - y])
                {
                    k++;
                }
            }
            if (k == a[i].Length / 2)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}

