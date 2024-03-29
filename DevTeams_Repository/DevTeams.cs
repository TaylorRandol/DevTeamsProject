﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DevTeams
    {
        public DevTeams() { }
        public DevTeams(List<Developer> developers, string teamMembers, string teamName, double teamID)
        {
            Developers = developers;
            TeamMembers = teamMembers;
            TeamName = teamName;
            TeamID = teamID;
        }
        public List<Developer> Developers { get; set; }
        //Team members--ie Developers
        public string TeamMembers { get; set; }

        //Team Name string
        public string TeamName { get; set; }

        //Team ID double
        public double TeamID { get; set; }
    }
}
