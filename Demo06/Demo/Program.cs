/* 
 * Created: 27.1.2016 
 * Authors: Albert Kuusjärvi 
 *Tehtävä 1 - Henkilörekisteri
    Toteutetaan opettajan kanssa yhdessä konsolipohjainen ohjelma, jolla voidaan hallita henkilöitä eli henkilörekisteri.          
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    /// <summary>
    /// This class contains Person properties.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //create an object from Persons
            Persons myFriends = new Persons();


            //create friends...
            Person person1 = new Person { Firstname="Hannes", Lastname ="Vehnä", SocialSecurityNumber="666666-666"};
            Person person2 = new Person { Firstname = "Otto", Lastname = "Niemi", SocialSecurityNumber = "010101-000" };
            Person person3 = new Person { Firstname = "Vesa", Lastname = "Ihan", SocialSecurityNumber = "123456-789" };

            //add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            //print collection
            myFriends.PrintCollection();

            //get one person 
            Console.WriteLine("Get one person from collection: ");
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person in that position...");
            }

            //find person with SocialSecurityNumber
            string socialSecurityNumber = "666666 - 666";
            Console.WriteLine("Find persons with sotu: " + socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 !=null)
            {
                Console.WriteLine(person5.ToString());
            }else
            {
                Console.WriteLine("Not found...");
            }
        }
    }
}
