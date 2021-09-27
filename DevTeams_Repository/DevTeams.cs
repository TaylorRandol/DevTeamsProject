using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DevTeams
    {
        public DevTeams() { }
        //Team members--ie Developers
        public List<Developer> DevTeam { get; set; }

        //Team Name string
        public string TeamName { get; set; }

        //Team ID double
        public double TeamID { get; set; }
    }
}
