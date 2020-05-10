using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Oblig1_Modul3_redone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'help' to get started");
            var listOfPeople = PersonList();
            while (true)
            {
                var input = Console.ReadLine();
                input = input.ToLower();

                if (input == "help")
                {
                    ShowHelp();
                }
                else if (input == "list")
                {
                    Console.Clear();
                    ShowAllPeople(listOfPeople);
                }
                else if (input.StartsWith("id"))
                {
                    Console.Clear();
                    int id = Convert.ToInt32(input.Substring(3, 1));
                    listOfPeople[id - 1].ShowPerson();
                }
            }
        }

        private static void ShowHelp()
        {
            Console.Clear();
            Console.WriteLine("Write 'list' to get a list of all the people.");
            Console.WriteLine("Write 'id' + a number to get information on a person with the corresponding id");
        }

        public static void ShowAllPeople(List<Person> listOfPeople)
        {
            for (var i = 0; i < listOfPeople.Count; i++)
            {
                listOfPeople[i].ShowPerson();
                Console.WriteLine();
            }
        }

        public static List<Person> PersonList()
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };
            var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            var sonja = new Person { Id = 7, FirstName = "Sonja", BirthYear = 1937 };
            var olav = new Person { Id = 8, FirstName = "Olav", BirthYear = 1903 };

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            var list = new List<Person>
            {
                sverreMagnus, ingridAlexandra, haakon, metteMarit, marius, harald, sonja, olav
            };
            return list;
        }

    }
}
