using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBookProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Person person = new Person();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("Select Option:\n" +
                    "1) Find the Create Contacts\n" +
                    "2) Find the Display of Contacts\n" +
                    "3) Find the edit contacts\n" +
                    "4) Find the delete contacts\n" +
                    "5) Ability to add Multiple person in AddressBook\n" +
                    "6) Ability to add Multiple AddressBook using Dictionary\n" +
                    "7) Find the DisplayList of Dictionary\n" +
                    "8) Ability to ensure there is no Duplicate entry os same person\n" +
                    "9) Ability to search Person in a City or State in Address Book\n" +
                    "10) Ability to view Person by City or State\n");

                int option = Convert.ToInt32(Console.ReadLine());
                int count = 0;

                switch (option)
                {
                    case 1:
                        Person.CreateContacts();
                        break;
                    case 2:
                        Person.Display();
                        break;

                    case 3:
                        Person.editContact();
                        break;
                    case 4:
                        Console.WriteLine("Enter name to delete from the record");
                        string name = Console.ReadLine();
                        Person.DeleteContact(name);
                        break;
                    case 5:
                        Person.AddMultipleContacts();
                        break;
                   
                    case 6:
                        person.NewUser();
                        break;
                    case 7:
                        Person person1 = new Person();
                        person1.DisplayList();
                        break;

                    case 8:
                        Person.DuplicateContact();
                        break;
                    case 9:
                        Person person2 = new Person();
                        person2.SearchPersonByCity();
                        break;
                    case 10:
                        Person person3 = new Person();
                        person3.ViewPersonsByCity();
                        break;

                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}