using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Dictionary<string, string> lydi = new Dictionary<string, string>();

        while (true)
        {
            string[] all = Console.ReadLine().Split();

            if (all[0] == "End")
            {
                break;
            }

            else if (all[0] == "A")
            {
                if (lydi.ContainsKey(all[1]))
                {
                    foreach (var person in lydi)
                    {
                        if (person.Key == all[1])
                        {
                            var mike = new KeyValuePair<string, string>(all[1], all[2]);
                            lydi.Remove(all[1]);
                            lydi.Add(mike.Key, mike.Value);
                            break;
                        }
                    }
                }
                else
                {
                    lydi.Add(all[1], all[2]);
                }


            }
            else if (all[0] == "S")
            {
                if (lydi.ContainsKey(all[1]))
                {
                    foreach (var person in lydi)
                    {
                        if (person.Key == all[1])
                        {
                            Console.WriteLine(all[1] + " -> " + person.Value);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Contact " + all[1] + " does not exist");
                }
            }
            else if (all[0] == "All")
            {
                var selectedPeople = from p in lydi 
                                     orderby p.Key  
                                     select p;

                foreach (var person in selectedPeople)
                {
                    Console.WriteLine(person.Key + " -> " + person.Value);
                }
            }
        }

    }
}

