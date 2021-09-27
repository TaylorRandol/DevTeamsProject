using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DeveloperRepo
    {
        public readonly List<Developer> developers = new List<Developer>();
        //CRUD
        //Create
        public bool AddToDirectory(Developer content)
        {
            int startingCount = developers.Count;

            developers.Add(content);

            bool wasAdded = (developers.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read(GET)
        public List<Developer> GetDevelopers()
        {
            return developers;
        }
        //Get by Name
        public Developer GetDeveloperByName(string developerYouAreLookingFor)
        {
            foreach (Developer name in developers)
            {
                if(name.Name.ToLower() == developerYouAreLookingFor.ToLower())
                {
                    return name;
                }
            }
            return null;
        }
        //Get by ID
        public Developer GetDeveloperByID(double idYouAreLookingFor)
        {
            foreach (Developer id in developers)
            {
                if(id.IDNumbers == idYouAreLookingFor)
                {
                    return id;
                }
            }
            return null;
        }
        //Update
        public bool UpdateDevInfo(Developer currentInfo, Developer updatedInfo)
        {
            if(currentInfo != null)
            {
                currentInfo.Name = updatedInfo.Name;
                currentInfo.IDNumbers = updatedInfo.IDNumbers;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete
        public bool DeleteInfo(Developer currentInfo)
        {
            bool result = developers.Remove(currentInfo);
            return result;
        }
    }
}
