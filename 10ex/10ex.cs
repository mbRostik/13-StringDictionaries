using System;
internal class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        for(int i = -1; i != a.Length; i++)
        {
            int k = 0;
            string temp="";
            for (int j = 0; j < a.Length; j++)
            {
                if (j != i)
                {
                    temp += a[j];
                }

            }
            for (int y = 0; y != a.Length / 2; y++)
            {
                if (temp[y] == temp[temp.Length - 1 - y])
                {
                    k++;
                }
            }
            if (k == a.Length /2 && i==-1)
            {
                Console.Write("Palidrom");
                return;
            }
            else if(k == a.Length/2 && i != -1)
            {
                Console.WriteLine(i);
                return;
            }
            
        }
        Console.WriteLine("Ne palidrom");

       
    }
}

