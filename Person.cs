using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Channels;

namespace Oblig1_Modul3_redone
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public Person Father{ get; set; }
        public Person Mother{ get; set; }

        public void ShowPerson()
        {
            if (Id != 0) Console.WriteLine($"Id[{Id}]");
            if (FirstName != null) Console.WriteLine($"First Name: {FirstName}");
            if (LastName != null) Console.WriteLine($"Last Name: {LastName}");
            if (BirthYear != 0) Console.WriteLine($"Born: {BirthYear}");
            if (DeathYear != 0) Console.WriteLine($"Died: {DeathYear}");
            if (Father != null) Console.WriteLine($"Father: {Father.FirstName}");
            if (Mother != null) Console.WriteLine($"Mother: {Mother.FirstName}");
        }
    }
}
