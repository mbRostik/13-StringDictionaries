using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {

        string em = Console.ReadLine();
        string text = Console.ReadLine();

        string temp = "";
        for(int i = 0; i != em.Length; i++)
        {
            if(em[i] == '@')
            {
                for(int y = i; y != em.Length;y++)
                {
                    temp += em[y];
                }
                break;
            }
            temp += '*';
        }

        text = text.Replace(em, temp);
        Console.WriteLine(text); 
    }
}
