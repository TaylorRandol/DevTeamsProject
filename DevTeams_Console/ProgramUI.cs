using DevTeams_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Console
{
    class ProgramUI
    {
        private DeveloperRepo _repo = new DeveloperRepo();
        bool isRunning = true;

        public void Run()
        {
            RunMenu();
        }
        //create dev 
        //create dev team
        //add devs to a team
        //show all devs
        //show all dev teams
        //find a specific dev
        //find a specific dev team
        //update dev 
        //update dev team
        //delete dev 
        //delete dev team
        //pluralsight licenses
        //exit
                    /*"Komodo Insurance\n\n" +
                    "Create new Developer Info:\n" +
                    "Show all Developers:\n" +
                    "Find Specific Developer:\n" +
                    "Update Developer Info:\n" +
                    "Remove Developer Info:\n" +
                    "Create new Dev Team\n" +
                    "Show all Dev Team\n" +
                    "Find Specific Dev Team\n" +
                    "Update Dev Team Info:\n" +
                    "Remove Dev Team Info:\n" +
                    "Pluralsight License:\n" +
                    "Exit"*/
        private void RunMenu()
        {
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Komodo Insurance\n\n" +
                    "1. Create new Developer Info:\n" +
                    "2. Show all Developers:\n" +
                    "3. Find Specific Developer:\n" +
                    "4. Update Developer Info:\n" +
                    "5. Remove Developer Info:\n" +
                    "6. Create new Dev Team\n" +
                    "7. Show all Dev Team\n" +
                    "8. Find Specific Dev Team\n" +
                    "9. Update Dev Team Info:\n" +
                    "10. Remove Dev Team Info:\n" +
                    "11. Pluralsight License:\n" +
                    "0. Exit\n\n" +
                    "Enter the number of your selection:\n");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //create dev
                        AddNewDevs();
                        break;
                    case "2":
                        //show all dev
                        ShowAllDevs();
                        break;
                    case "3":
                        //Find specific dev
                        ShowDev();
                        break;
                    case "4":
                        //update dev info
                        PickUpdate();
                        break;
                    case "5":
                        //remove dev info
                        RemoveContentFromRepo();
                        break;
                    case "6":
                        //create new dev team
                        break;
                    case "7":
                        //show all dev teams
                        break;
                    case "8":
                        //find specific dev team
                        break;
                    case "9":
                        //Update dev team
                        break;
                    case "10":
                        //remove dev team
                        break;
                    case "11":
                        //pluralsight
                        break;
                    case "0":
                        //Exit
                        isRunning = false;
                        break;

                    default:
                        //random/wrong input
                        Console.WriteLine("Please enter a valid number between 1 and 3.");
                        WriteRead();
                        break;
                }
            }
        }

        //Create a menu with options matching you repository
        //1. create new dev, 2. show all devs, 3. search specific dev(by name, by id), 4. update dev(name, ID, pluralsight),  5. delete dev info
        //Developers

        //Dev Teams
        //1. Create new Dev Team, 2. show all dev teams, 3. search specific dev team, 4. update dev team, 5. delete dev team
        //Dev Teams
        private void DevTeams()
        {
            Console.Clear();
            Console.WriteLine
                (
                "Developer Teams\n\n" +
                "Enter the number of your selection:\n" +
                "1. Create a new Dev Team:\n" +
                "2. Show all current Developer Teams:\n" +
                "3. Search specific Dev Team by Name:\n" +
                "4. Search specific Dev Team by ID:\n" +
                "5. Update current Dev Team Info:\n" +
                "6. Remove current Dev Team Info:\n" +
                "7. Return\n" +
                "8. Exit Program"
                );

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    //Create dev team
                    break;
                case "2":
                    //show all teams
                    break;
                case "3":
                    //Search by name
                    break;
                case "4":
                    //Search by id
                    break;
                case "5":
                    //update teams
                    break;
                case "6":
                    //delete team info
                    break;
                case "7":
                    //return
                    RunMenu();
                    break;
                case "8":
                    //Exit
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid number between 1 and 8.");
                    WriteRead();
                    break;
            }
        }

        //Pluralsight Licenses
        private void Pluralsight()
        {
            Console.Clear();
            Console.WriteLine
                (
                "Pluralsight Licenses\n\n" +
                "Enter a number to make a selection\n" +
                "1. Developers without Licenses\n" +
                "2. Developers with Licenses\n" +
                "3. Return\n" +
                "4. Exit Program"
                );

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    //Devs needing Licenses
                    break;
                case "2":
                    //Devs with licenses
                    break;
                case "3":
                    //return
                    RunMenu();
                    break;
                case "4":
                    //exit
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid number between 1 and 4.");
                    WriteRead();
                    break;
            }
        }

        //Creating Content
        private void AddNewDevs()
        {
            Console.Clear();

            Developer dev = new Developer();

            Console.WriteLine("New Dev Info\n\n" +
                "Please enter a First Name:");
            dev.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter a Last Name:");
            dev.LastName = Console.ReadLine();

            Console.WriteLine("Please enter an ID number:");
            dev.IDNumbers = Convert.ToDouble(Console.ReadLine());

            dev.Name = $"{dev.FirstName} {dev.LastName}";

            Console.WriteLine($"Does {dev.Name} have access to Pluralsight?\n" +
                $"1. Yes\n" +
                $"2. No");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //yes
                    dev.Pluralsight = true;
                    break;
                case "2":
                    //no
                    dev.Pluralsight = false;
                    break;
                default:
                    //wrong input
                    Console.WriteLine("Please enter a valid number 1 or 2.");
                    break;
            }
            _repo.AddToDirectory(dev);
        }

        //Getting all content
        private void ShowAllDevs()
        {
            Console.Clear();

            List<Developer> listOfDevs = _repo.GetDevelopers();

            foreach (Developer dev in listOfDevs)
            {
                DisplayDevs(dev);
            }
            WriteRead();
        }
        private void ShowDev()
        {
            Console.Clear();

            Console.WriteLine("Enter the number of your selection:\n" +
                "1. Search by Dev Full Name\n" +
                "2. Search by Dev ID");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    ShowDevName();
                    break;
                case "2":
                    ShowDevID();
                    break;
            }

        }
        //getting specific content(by name)
        private void ShowDevName()
        {
            Console.Clear();

            Console.WriteLine("Who are you looking for?\n" +
                "Full Name:");
            string name = Console.ReadLine();

            Developer developer = _repo.GetDeveloperByName(name);

            if (developer != null)
            {
                DisplayDevs(developer);
            }
            else
            {
                Console.WriteLine("Unfortunately, we don't have that developer on file.");
            }
            WriteRead();
        }
        //getting specific content (by id)
        private void ShowDevID()
        {
            Console.Clear();

            Console.WriteLine("Who are you looking for?\n" +
                "ID Number:");
            double id = Convert.ToDouble(Console.ReadLine());

            Developer developer = _repo.GetDeveloperByID(id);

            if (developer != null)
            {
                DisplayDevs(developer);
            }
            else
            {
                Console.WriteLine("Unfortunately, we don't have that ID on file.");
            }
            WriteRead();
        }
        //Pick Update
        private void PickUpdate()
        {
            Console.Clear();

            Console.WriteLine("Update specific Dev Info\n\n" +
                "1. Update only Dev Name\n" +
                "2. Update only Dev ID\n" +
                "3. Update All\n" +
                "4. Return\n\n" +
                "Enter the number of your selction:\n");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    //only name
                    UpdateDevName();
                    break;
                case "2":
                    //only id
                    UpdateID();
                    break;
                case "3":
                    //All
                    UpdateDev();
                    break;
                case "4":
                    //return
                    RunMenu();
                    break;
                default:
                    Console.WriteLine("The number you entered was invalid.");
                    WriteRead();
                    break;
            }
        }
        //Update Content(by name)
        private void UpdateDevName()
        {
            Console.Clear();

            Console.WriteLine("What is the full name of the Developer you want to update?");
            string targetName = Console.ReadLine();

            Developer targetDev = _repo.GetDeveloperByName(targetName);

            if (targetDev == null)
            {
                Console.WriteLine("We are unable to find that Developer.");
                WriteRead();
                return;
            }
            Developer developerUP = new Developer();

            Console.WriteLine($"Current Name: {targetDev.Name}\n" +
                $"Current ID: {targetDev.IDNumbers}\n" +
                $"Please enter a new Full Name:\n");
            developerUP.IDNumbers = targetDev.IDNumbers;
            developerUP.Name = Console.ReadLine();

            if (_repo.UpdateDevInfo(targetDev, developerUP))
            {
                Console.WriteLine("Update successful");
            }
            else
            {
                Console.WriteLine("Update failed");
            }
            WriteRead();
        }
        private void UpdateDev()
        {
            Console.Clear();

            Console.WriteLine("What is the full name of the Developer you want to update?");
            string targetName = Console.ReadLine();

            Developer targetDev = _repo.GetDeveloperByName(targetName);

            if (targetDev == null)
            {
                Console.WriteLine("We are unable to find that Developer.");
                WriteRead();
                return;
            }

            Developer developerUP = new Developer();
            //Updated Name
            Console.WriteLine($"Original Name: {targetDev.Name}\n" +
                $"Please enter a new Full Name: ");
            developerUP.Name = Console.ReadLine();
            //Updated ID Number
            Console.WriteLine($"Original ID: {targetDev.IDNumbers}\n" +
                $"Plese enter a new ID Number: ");
            developerUP.IDNumbers = Convert.ToDouble(Console.ReadLine());

            if (_repo.UpdateDevInfo(targetDev, developerUP))
            {
                Console.WriteLine("Update successful");
            }
            else
            {
                Console.WriteLine("Update failed");
            }
            WriteRead();
        }
        //Update Content (by id)
        private void UpdateID()
        {
            Console.Clear();

            Console.WriteLine("What is the full name of the Developer you want to update?");
            string targetName = Console.ReadLine();

            Developer targetDev = _repo.GetDeveloperByName(targetName);

            if (targetDev == null)
            {
                Console.WriteLine("We are unable to find that Developer.");
                WriteRead();
                return;
            }
            Developer developerUP = new Developer();

            Console.WriteLine($"Current Name: {targetDev.Name}\n" +
                $"Current ID: {targetDev.IDNumbers}\n" +
                $"Please enter a new ID Number:\n");
            developerUP.Name = targetDev.Name;
            developerUP.IDNumbers = Convert.ToDouble(Console.ReadLine());

            if (_repo.UpdateDevInfo(targetDev, developerUP))
            {
                Console.WriteLine("Update successful");
            }
            else
            {
                Console.WriteLine("Update failed");
            }
            WriteRead();
        }

        //Deleting Content
        private void RemoveContentFromRepo()
        {
            Console.Clear();

            List<Developer> developers = _repo.GetDevelopers();

            int index = 1;

            foreach (Developer developer in developers)
            {
                Console.WriteLine($"{index}. {developer.Name}");
                index++;
            }

            Console.WriteLine("What Developer would you like to remove?");
            int targetName = int.Parse(Console.ReadLine());
            int targetIndex = targetName - 1;

            if (targetIndex >= 0 && targetIndex < developers.Count)
            {
                Developer targetDev = developers[targetIndex];

                if (_repo.DeleteInfo(targetDev))
                {
                    Console.WriteLine($"{targetDev.Name} was successfully deleted.");
                }
                else
                {
                    Console.WriteLine("Oh no, something went wrong.");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid selection");
            }
            WriteRead();
        }

        //Helper Methods
        private void WriteRead()
        {
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private void DisplayDevs(Developer developer)
        {
            Console.WriteLine(
                $"Name: {developer.Name}\n" +
                $"ID Number: {developer.IDNumbers}\n" +
                $"Pluralsight License: {developer.Pluralsight}\n");
        }

        private void ReturnDev()
        {

        }
    }
}
