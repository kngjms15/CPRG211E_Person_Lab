using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Person_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Person 1
            Person person1;
            person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);

            //Person2
            Person person2;
            person2 = new Person(2, "Gina", "James", "Green", 18, false);
            
            //Person3
            Person person3;
            person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            
            //Person4
            Person person4;
            person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //Run program outputs
            person2.DisplayPersonInfo();
            Console.WriteLine(person3.ToString());
            person1.ChangeFavoriteColour();
            person4.AddAge();
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person4.ToString());
            //person1.DisplayPersonInfo();




        }
    }
}
