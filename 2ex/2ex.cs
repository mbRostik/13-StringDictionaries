using System;


internal class Program
{
    static void Main()
    {
        string str=Console.ReadLine();
        if (str.Length > 20)
        {
            Console.WriteLine(str.Substring(0, 19));
        }
        else
        {
            Console.Write(str.PadRight(20, '*'));
        }
        

    }
}