using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {

        string slovo = Console.ReadLine();
        string[] text = Console.ReadLine().Split('.', '!', '?');


        List<string> re4enua = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Contains(slovo))
            {
                string[] Temp = text[i].Split(' ', '-', '_', ',');

                if (Temp.Contains(slovo))
                {
                    re4enua.Add(text[i].Trim());
                }
            }
        }
        foreach (string s in re4enua)
        {
            Console.WriteLine(s);
        }
    }
}
