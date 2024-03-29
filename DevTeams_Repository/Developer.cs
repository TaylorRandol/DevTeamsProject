﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class Developer
    {
        public Developer() { }
        public Developer(string firstName, string lastName, string name, double idNumbers, bool pluralsight)
        {
            FirstName = firstName;
            LastName = lastName;
            Name = name;
            IDNumbers = idNumbers;
            Pluralsight = pluralsight;
        }
        //Names string
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Name { get; set; }

        //ID numbers double
        public double IDNumbers { get; set; }

        //access to Pluralsight bool
        public bool Pluralsight { get; set; }

        
    }
}
