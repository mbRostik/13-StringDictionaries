using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        string all = Console.ReadLine();


        string[] temp = all.Split('.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ');
        List<string> words = new();
        List<string> ch = new();


        foreach (string item in temp)
        {
            if (item.Length > 0)
            {
                words.Add(item);
            }
        }

        for (int i = 0; i < words.Count - 1; i++)
        {
            ch.Add (all.Substring(all.IndexOf(words[i]) + words[i].Length,all.IndexOf(words[i + 1]) - (all.IndexOf(words[i]) + words[i].Length) ));
        }

        string all2 = "";
        int index = 0;
        for (int i = words.Count - 1; i >= 0; i--)
        {
            all2 += words[i];

            if (index < ch.Count)
            {
                all2 += ch[index++];
            }
        }
        all2 += all.Substring(all2.Length);

        Console.WriteLine(all2);
    }
}