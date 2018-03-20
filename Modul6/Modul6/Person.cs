using System;

namespace Modul6
{
    class Person
    {
        public DateTime Birthday { get; set; }
        public string FirstName;
        public string LastName;
        public SetGender Gender { get; set; }
        public Sport Sport { get; set; }

        public enum SetGender
        {
            Male, Female
        }




        public void MakePerson(string firstName, string lastName)
        {
            Birthday = DateTime.Today;
            FirstName = firstName;
            LastName = lastName;
            Gender = SetGender.Male;
            Sport = Sport.Tennis;
        }

    }
}