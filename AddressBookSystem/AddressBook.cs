using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Person
    {
        //here the values are assign to below variables and we are getting the value from console when addContact method is called
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string[] Address { get; set; }
    }
    internal class AddressBook
    {
        public List<Person> People = new List<Person>(); // object is created of list class of type Person
        public void addContact() // with this method the values are taken from user through console
        {
            Person person = new Person(); // creating a object of person class to assign the values received from user 
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
            People.Add(person); // with add method we are adding the contact in list People
        }
        public void printContact(Person person) // in this method, we are printing all the details
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
            Console.WriteLine("Following is your Contact List:");
            foreach(var person in People) // using foreach loop, it will print the contact stored in People list one by one by calling printContact method
            {
                printContact(person);
            }
        }
    }
}
