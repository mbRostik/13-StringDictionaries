using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string all = Console.ReadLine();
        string[] temp = all.Split(' ', '>', '/');

        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] == "<upcase")
            {
                temp[i] = "";
                while (true)
                {
                    i++;
                    if (temp[i] == "upcase" || i == temp.Length - 1)
                    {
                        temp[i] = "";
                        break;
                    }
                    temp[i] = temp[i].ToUpper();
                    i++;
                    if (temp[i] == "upcase" || i == temp.Length - 1)
                    {
                        temp[i - 1] = temp[i - 1].Remove(temp[i - 1].Length - 1, 1);
                    }
                    i--;
                }
            }
        }
        foreach (var f in temp)
        {
            Console.Write(f + " ");
        }
    }
}