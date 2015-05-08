using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAssignment2
{
    public class People
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Run()
        {
            AddPeople();
        }

        public void AddPeople()
        {

            //List<People> peopleList = new List<People>();
            
            //peopleList.Add(new People(){ FirstName = "Rikki", LastName="Mcphail" });
            //peopleList.Add(new People(){ FirstName = "Hagan", LastName="Mcphail" });
            //peopleList.Add(new People(){ FirstName = "Janie", LastName="Clarke" });
            //peopleList.Add(new People(){ FirstName = "Matt", LastName="Brown" });
            //peopleList.Add(new People(){ FirstName = "Bill", LastName="Wettingfeld" });

            string[,] peopleList = new string[,] 
            {
                {"Hagan","McPhail","8/14/1991","Dallas","TX","75243"},
                {"Rikki","McPhail","6/18/1993","Dallas","TX","75243"},
                {"Janie","Clarke","8/19/1991","Dallas","TX","75243"},
                {"Bill","Wettingfeld","11/11/1988","Frisco","TX","75243"},
                {"Matt","Brown","6/6/1986","Dallas","TX","75243"}
            };

            string searchCriteria = GetSearchCriteria();
            DisplayPeople(peopleList, searchCriteria);
        }

        private string GetSearchCriteria()
        {
            Console.Write("Search people for: \n");
            string searchCriteria = Console.ReadLine().ToUpper();
            Console.WriteLine();
            if (searchCriteria != "")
            {
                return searchCriteria;
            }
            else
            {
                Console.WriteLine("Please enter your search information\n");
                return GetSearchCriteria();
            }
        }

        private void DisplayPeople(string[,] peopleList, string searchCriteria)
        {
            bool didFindPerson = false;
            int peopleFound = 0;

            for (int a = 0; a < peopleList.GetLength(0); a++)
            {
                for (int z = 0; z < peopleList.GetLength(1); z++)
                {

                    string firstName = peopleList[a, 0].ToUpper();
                    string lastName = peopleList[a, 1].ToUpper();

                    if (firstName.Contains(searchCriteria) || lastName.Contains(searchCriteria))
                    {
                        Console.Write(peopleList[a, z] + " ");
                        didFindPerson = true;
                    }
                }

                if (didFindPerson == true)
                {
                    Console.WriteLine();
                    didFindPerson = false;
                    peopleFound++;
                }
            }
            Console.WriteLine("\n" + peopleFound + "person(s) found!\n\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}
