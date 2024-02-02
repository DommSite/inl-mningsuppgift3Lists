using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace listinlämning_3
{
    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, int> landlista = new Dictionary<string, int>();
            landlista.Add("Norge", 385);
            landlista.Add("Sverige", 450);
            landlista.Add("Danmark", 43);
            landlista.Add("Finland", 338);

            Console.WriteLine("Välj ett av länderna:");
            foreach (KeyValuePair<string, int> item in landlista)
            {
                Console.WriteLine(item.Key);
            }
                string val = Console.ReadLine();
            foreach(KeyValuePair<string, int> item in landlista)
            {
                if(val==item.Key)
                {
                    Console.WriteLine(item.Key + " har arean: " + item.Value);
                }
            }
        }
    }
}
