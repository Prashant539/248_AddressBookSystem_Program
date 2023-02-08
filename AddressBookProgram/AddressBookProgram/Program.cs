using System;
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
                    "3) Find the edit contacts\n");

                int option = Convert.ToInt32(Console.ReadLine());
                
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

                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }
        }
    }
}