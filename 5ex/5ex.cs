using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string ssulka = Console.ReadLine();

        string protocol = "";
        string server = "";
        string resource = "";

        if (Regex.IsMatch(ssulka, @"(\w|\W)+://(\w|\W)+"))
        {
            for (int i = 0; i < ssulka.Length; i++)
            {
                if (i + 1 < ssulka.Length && ssulka[i] != '/' && ssulka[i + 1] != '/')
                {
                    protocol += ssulka[i];
                }
                else
                {
                    break;
                }
            }
        }

        if (Regex.IsMatch(ssulka, @"[A-Z,a-z,0-9]+/(\w|\W)+"))
        {
            for (int i = protocol.Length + 3; i < ssulka.Length; i++)
            {
                if (i + 2 < ssulka.Length && ssulka[i] != '/')
                {
                    server += ssulka[i];
                }
                else
                {
                    break;
                }
            }
            for (int i = protocol.Length + 3 + server.Length + 1; i < ssulka.Length; i++)
            {
                resource += ssulka[i];
            }
        }
        else
        {
            if (protocol != "")
            {
                for (int i = protocol.Length + 3; i < ssulka.Length; i++)
                {
                    server += ssulka[i];
                }
            }
            else
            {
                for (int i = protocol.Length; i < ssulka.Length; i++)
                {
                    server += ssulka[i];
                }
            }
            
        }

        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resource);
    }
}