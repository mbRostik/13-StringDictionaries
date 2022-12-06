using System;
internal class Program
{
    static void Main()
    {
        string[] a = Console.ReadLine().Split('.', ',', ':', ';', '!', '?', ' ');

        for (int i = 0; i < a.Length; i++)
        {
            string temp = a[i];
            if (temp.Length > 0)
            {
                char first = char.ToUpper(temp[0]);

                string temp2 = "";
                temp2 += first;
                for (int y = 1; y != temp.Length; y++)
                {
                    temp2 += temp[y];
                }
                a[i] = temp2;
            }
            
        }
        foreach (string temp in a)
        {
            Console.Write(temp+" ");
        }
    }
}

