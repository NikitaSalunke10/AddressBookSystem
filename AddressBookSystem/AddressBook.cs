using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string[] Address { get; set; }
    }
    internal class AddressBook
    {
        public List<Person> People = new List<Person>();
        public void addContact()
        {
            Person person = new Person();
            Console.Write("Enter the First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter the Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter the Mobile number: ");
            person.PhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the Email ID: ");
            person.Email = Console.ReadLine();
            string[] add = new string[4];
            Console.Write("Enter the Address: ");
            add[0] = Console.ReadLine();
            Console.Write("Enter the City: ");
            add[1] = Console.ReadLine();
            Console.Write("Enter the State: ");
            add[2] = Console.ReadLine();
            Console.Write("Enter the Zipcode: ");
            add[3] = Console.ReadLine();
            person.Address = add;
            People.Add(person);
        }
        public void printContact(Person person)
        {
            Console.WriteLine("Full name : " + person.FirstName+ " "+person.LastName);
            Console.WriteLine("Mobile number : "+person.PhoneNumber);
            Console.WriteLine("Email ID : "+person.Email);
            Console.WriteLine("Address : " + person.Address[0]);
            Console.WriteLine("City : " + person.Address[1]);
            Console.WriteLine("State : " + person.Address[2]);
            Console.WriteLine("Zipcode : " + person.Address[3]);
        }
        public void listContact()
        {
            if(People.Count == 0)
            {
                Console.WriteLine("Your contact list is empty.");
                return;
            }
            Console.WriteLine("Following is your Contact List:");
            foreach(var person in People)
            {
                printContact(person);
            }
        }
    }
}
