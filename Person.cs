using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Person_Lab
{
    internal class Person
    {
        //person instance variables to hold data
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        /*____________________________nick solution
        //properties!
        public int PersonID { get => PersonId; set personId; => value; }

        public int PersonId
        {
            get { return personId; }
            set { personId = value; }
        }
       ________________________________________________ */



        // classes have one or more constructors
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }
        //to Display person informations
        public void DisplayPersonInfo()
        {
            string faveCol = $"{personId}: {firstName} {lastName}'s favorite colour is {favoriteColour}";
            Console.WriteLine(faveCol);
        }
        // change favourite color
        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";
            string faveCol = $"{personId}: {firstName} {lastName}'s favorite colour is {favoriteColour}";
            Console.WriteLine(faveCol);
        }
        //to string method format
        public override string ToString()
        {
            return ($"PersonID: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavoriteColour: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}"); 
        }
        //to string method to add age
        public void AddAge()
        {
            int added = age += 10;
            string adding = $"{firstName} {lastName}'s age in 10 years is {added}";
            Console.WriteLine(adding);
        }
    }


}

