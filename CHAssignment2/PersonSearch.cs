using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAssignment2
{
    public class PersonSearch
    {
        public void Run()
        {
            List<Person> people = GetPeople();
            string searchCriteria = GetSearchCriteria();
            DisplayPeople(people, searchCriteria);
        }

        public List<Person> GetPeople()
        {
            List<Person> people = new List<Person>();

            people.Add(new Person() { FirstName = "Rikki", LastName = "Mcphail" });
            people.Add(new Person() { FirstName = "Hagan", LastName = "Mcphail" });
            people.Add(new Person() { FirstName = "Janie", LastName = "Clarke" });
            people.Add(new Person() { FirstName = "Matt", LastName = "Brown" });
            people.Add(new Person() { FirstName = "Bill", LastName = "Wettingfeld" });

            return people;
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

        private void DisplayPeople(List<Person> people, string searchCriteria)
        {
            int peopleFound = 0;

            foreach (Person person in people)
            {
                string firstName = person.FirstName.ToUpper();
                string lastName = person.LastName.ToUpper();

                if (firstName.Contains(searchCriteria) || lastName.Contains(searchCriteria))
                {
                    Console.Write(String.Format("{0} {1} \n",
                        person.FirstName,
                        person.LastName)
                    );
                    peopleFound++;
                }

            }

            Console.WriteLine("\n" + peopleFound + "person(s) found!\n\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}
