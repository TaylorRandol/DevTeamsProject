using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DevTeamRepo
    {
        public readonly List<DevTeams> devTeams = new List<DevTeams>();
        //CRUD
        //Create Dev Team
        //Add individual Devs to a Team
        public bool AddToTeamDirectory(DevTeams content)
        {
            int startingCount = devTeams.Count;

            devTeams.Add(content);

            bool wasAdded = (devTeams.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read Dev Teams
        public List<DevTeams> GetDevTeams()
        {
            return devTeams;
        }
        //Read Dev Team by Name
        public DevTeams GetTeamByName(string teamYouAreLookingFor)
        {
            foreach (DevTeams devTeam in devTeams)
            {
                if (devTeam.TeamName.ToLower() == teamYouAreLookingFor.ToLower())
                {
                    return devTeam;
                }
            }
            return null;
        }
        //Read Dev Team by ID
        public DevTeams GetTeamByID(double teamYouAreLookingFor)
        {
            foreach (DevTeams devTeams in devTeams)
            {
                if (devTeams.TeamID == teamYouAreLookingFor)
                {
                    return devTeams;
                }
            }
            return null;
        }
        //Read individual devs in a team
        public DevTeams GetDevTeamByDev(string devTeamYouAreLookingFor)
        {
            foreach (DevTeams name in devTeams)
            {
                if(name.TeamName.ToLower() == devTeamYouAreLookingFor.ToLower())
                { return name; }
            }
            return null;
        }

        //Update Dev Teams
        //name and id of team
        public bool UpdateDevTeam(DevTeams existingDevTeam, DevTeams newDevTeams)
        {
            if (existingDevTeam != null)
            {
                existingDevTeam.TeamMembers = newDevTeams.TeamMembers;
                existingDevTeam.TeamName = newDevTeams.TeamName;
                existingDevTeam.TeamID = newDevTeams.TeamID;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete Dev Teams
        //Delete individual devs from a team
        public bool DeleteDevTeams(DevTeams existingDevTeams)
        {
            bool result = devTeams.Remove(existingDevTeams);
            return result;
        }
    }
}
