﻿using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();
            for (int i = 0; i < girls.Count; i++)
            {
                order.Add(girls[i]);
                order.Add(boys[i]);
            }
            //var order = new List<string> { girls[0], boys[0], girls[1], boys[1], girls[2], boys[2], girls[3], boys[3], girls[4], boys[4]};

            for (int i = 0; i < order.Count; i++)
            {
                Console.WriteLine(order[i]);
            }

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            
            Console.ReadLine();
        }
    }
}