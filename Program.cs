﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche" };
            for (int i = 0; i < week.Length; i++)
            {
                week[4] = "Vendredi";
                Console.WriteLine(week[i]);

            }
        }
    }
}
