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
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string[] Address { get; set; }
    }
    internal class AddressBook
    {
        public List<Person> People = new List<Person>(); // object is created of list class of type Person
        public void addContact() // with this method the values are taken from user through console
        {
            Person person = new Person(); // creating a object of person class to assign the values received from user 
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter the First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter the Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter the Mobile number: ");
            person.PhoneNumber = Console.ReadLine();
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
            if (People.Count != 0)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Following is your Contact List:");
                foreach (var person in People) // using foreach loop, it will print the contact stored in People list one by one by calling printContact method
                {
                    Console.WriteLine("-------------------------------------------");
                    printContact(person);
                }
            }
            else
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Address Book is empty.");
            }
        }
        public void editContact() //in this method, the contact is edited based on first name
        {
            string findContact;
            int option;
            if (People.Count != 0) //in this if condition it will check if there is any contact in list 
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Enter the first name you want to edit : ");
                findContact = Console.ReadLine(); // here the first name is store of which user want to edit the contact
                foreach (var person in People) // using foreach loop we are checking if the first name is present in list or not
                {
                    if (findContact == person.FirstName) // if the first name is present the it will go inside if statement and ask option
                    {
                        Console.WriteLine("1 for First Name.\n2 for Last Name.\n3 for Mobile number.\n 4 for Email ID.");
                        Console.WriteLine("5 for Address.\n6 for City.\n7 for State.\n8 for Zipcode. ");
                        Console.WriteLine("Please enter option number: ");
                        option = int.Parse(Console.ReadLine()); // here the option value is store of which field user want to edit
                        switch (option)
                        {
                            case 1:
                                Console.Write("Enter the First Name: ");
                                person.FirstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Enter the Last Name: ");
                                person.LastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Enter the Mobile number: ");
                                person.PhoneNumber = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write("Enter the Email ID: ");
                                person.Email = Console.ReadLine();
                                break;
                            case 5:
                                Console.Write("Enter the Address: ");
                                person.Address[0] = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Enter the City: ");
                                person.Address[1] = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write("Enter the State: ");
                                person.Address[2] = Console.ReadLine();
                                break;
                            case 8:
                                Console.Write("Enter the Zipcode: ");
                                person.Address[3] = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Wrong input");
                                break;
                        }
                        return;
                    }
                    else // if the condition becomes false then it will print below message
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Enter a valid name.");
                    }
                }
            }
            else // if the condition becomes false then it will print below message
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Address Book is empty.");
            } 
        }
        public void deleteContact() //In this method, a contact is deleted based on the first name
        {
            if (People.Count != 0)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Enter the first name you want to delete : ");
                string deleteContact = Console.ReadLine(); //from user first name is taken to delete the contact
                for (int i = 0; i < People.Count; i++) // for loop is used to find the name in list
                {
                    if (deleteContact.ToLower() == People[i].FirstName.ToLower()) // condition is checked whether the user given name with any present name in list
                    {
                        People.RemoveAt(i); //if name is present in list then that contact is removed from list
                        Console.WriteLine("Contact is deleted.");
                        
                    }
                    else // if the condition becomes false then it will print below message
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Enter a valid name.");
                    }
                }
            }
            else // if the condition becomes false then it will print below message
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Address Book is empty.");
            }
        }
    }
}
