using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
    internal class AddressBook
    {
        public List<Person> People = new List<Person>(); // object is created of list class of type Person
        Dictionary<string, List<Person>> dict = new Dictionary<string, List<Person>>();
        public void addContact() // with this method the values are taken from user through console
        {
            Person person = new Person(); // creating a object of person class to assign the values received from user 
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter the First Name: ");
            person.FirstName = Console.ReadLine();
            bool check = checkDuplicate(person.FirstName); // check will store the true or false value returned from method
            if(check) // if value is true then the name is already exits and will come out of method
            {
                return;
            }
            Console.Write("Enter the Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter the Mobile number: ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter the Email ID: ");
            person.Email = Console.ReadLine();
            Console.Write("Enter the Address: ");
            person.Address = Console.ReadLine();
            Console.Write("Enter the City: ");
            person.City = Console.ReadLine();
            Console.Write("Enter the State: ");
            person.State = Console.ReadLine();
            Console.Write("Enter the Zipcode: ");
            person.ZipCode = Console.ReadLine();
            People.Add(person); // with add method we are adding the contact in list People
        }
        public void printContact(Person person) // in this method, we are printing all the details
        {
            Console.WriteLine("Full name : " + person.FirstName+ " "+person.LastName);
            Console.WriteLine("Mobile number : "+person.PhoneNumber);
            Console.WriteLine("Email ID : "+person.Email);
            Console.WriteLine("Address : " + person.Address);
            Console.WriteLine("City : " + person.City);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("Zipcode : " + person.ZipCode);
        }
        public Boolean checkDuplicate(string firstName)// this method is used to check whether the name is already present in list or not
        {
            foreach(var person in People)
            {
                if(person.FirstName == firstName)
                {
                    Console.WriteLine("Name already exits.");
                    return true;
                }
            }
            return false;
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
                    if (findContact.ToLower() == person.FirstName.ToLower()) // if the first name is present the it will go inside if statement and ask option
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
                                person.Address = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Enter the City: ");
                                person.City = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write("Enter the State: ");
                                person.State = Console.ReadLine();
                                break;
                            case 8:
                                Console.Write("Enter the Zipcode: ");
                                person.ZipCode = Console.ReadLine();
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
        public void AddUniqueContact() // this method is used to store the contact in dictionary so it will have unique contacts
        {
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter the First Name you want to add in Unique Contact Book: ");
            string firstName = Console.ReadLine(); 
            foreach (var person in People)
            {
                if(People.Contains(person)) 
                {
                    dict.Add(firstName, People); // it will add the unique contact only and not the duplicate
                }
            }
        }
        public void displayUniqueContact() //this method is used to display the unique contacts
        {
            foreach(var item in dict)
            {
                foreach(var contact in item.Value)
                {
                    Console.WriteLine("-------------------------------------------");
                    printContact(contact);
                }
            }
        }
        public void SearchContact() // this method is used to search a contact based on city or state
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the City or State to search contact: ");
            string result = Console.ReadLine();
            foreach(Person person in People.FindAll(e => e.City.Equals(result) || e.State.Equals(result)))
            {
                Console.WriteLine("-------------------------------------------");
                printContact(person);
            }
        }
        public void ViewPersonByCityState() // this method is used to create dictionary of city and state wise
        {
            Dictionary<string, List<Person>> CityAddressBook = new Dictionary<string, List<Person>>();
            Dictionary<string, List<Person>> StateAddressBook = new Dictionary<string, List<Person>>();
            Console.WriteLine("Press 1 if want to search by City or Press 2 if want to search by state");
            int choice = Convert.ToInt32(Console.ReadLine());
            string city, state;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Enter the city you want to search: ");
                    city = Console.ReadLine();
                    CityAddressBook[city] = new List<Person>();
                    foreach(Person person in People.FindAll(e => e.City.Equals(city)))
                    {
                        CityAddressBook[city].Add(person);
                    }
                    foreach (var person in CityAddressBook) // it will print CityAddressBood dictionary
                    {
                        foreach (var item in person.Value)
                        {
                            Console.WriteLine("-------------------------------------------");
                            printContact(item);
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Total count of people at {0} city: {1}", city, CityAddressBook[city].Count); // this will print the city and count of contacts in that same city
                    break;
                case 2:
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Enter the state you want to search: ");
                    state = Console.ReadLine();
                    StateAddressBook[state] = new List<Person>();
                    foreach (Person person in People.FindAll(e => e.State.Equals(state)))
                    {
                        StateAddressBook[state].Add(person);
                    }
                    foreach (var person in StateAddressBook)// it will print StateAddressBood dictionary
                    {
                        foreach (var item in person.Value)
                        {
                            Console.WriteLine("-------------------------------------------");
                            printContact(item);
                        }
                    }
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Total count of people at {0} state: {1}", state, StateAddressBook[state].Count);// this will print the state and count of contacts in that same state
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
        public void SortContacts() // this method is used to display sorted contacts
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Press 1 to Sort by Name.\nPress 2 to Sort by City");
            Console.WriteLine("Press 3 to Sort by State.\nPress 4 to Sort by ZipCode");
            Console.WriteLine("Please enter the option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    foreach (Person person in People.OrderBy(name => name.FirstName)) // OrderBy is used to sort the contacts by first names
                    {
                        Console.WriteLine("-------------------------------------------");
                        printContact(person);
                    }
                    break;
                case 2:
                    foreach (Person person in People.OrderBy(city => city.City)) // OrderBy is used to sort the contacts by City
                    {
                        Console.WriteLine("-------------------------------------------");
                        printContact(person);
                    }
                    break;
                case 3:
                    foreach (Person person in People.OrderBy(state => state.State)) // OrderBy is used to sort the contacts by state
                    {
                        Console.WriteLine("-------------------------------------------");
                        printContact(person);
                    }
                    break;
                case 4:
                    foreach (Person person in People.OrderBy(code => code.ZipCode)) // OrderBy is used to sort the contacts by zip code
                    {
                        Console.WriteLine("-------------------------------------------");
                        printContact(person);
                    }
                    break;
                default :
                    Console.WriteLine("Wrong input");
                    break ;
            }
        }
        public void ReadWriteFile() // this method is used to write and read the contacts
        {
            string path = @"C:\Users\LENOVO\source\repos\AddressBookSystem\AddressBookSystem\Contacts.txt"; // path of the file is stored in path
            using(StreamWriter sw = new StreamWriter(path)) 
            {
                foreach(Person person in People)//foreach loop is used to write all contacts in file
                {
                    sw.WriteLine("-------------------------------------------");
                    sw.WriteLine("Full name : " + person.FirstName + " " + person.LastName);
                    sw.WriteLine("Mobile number : " + person.PhoneNumber);
                    sw.WriteLine("Email ID : " + person.Email);
                    sw.WriteLine("Address : " + person.Address);
                    sw.WriteLine("City : " + person.City);
                    sw.WriteLine("State : " + person.State);
                    sw.WriteLine("Zipcode : " + person.ZipCode);
                }
                sw.Close();
                Console.WriteLine(File.ReadAllText(path)); // all the contacts in the file are displayed
            }
        }
        public void ReadWriteCSVFile()//this method is used to write and read contacts from csv file
        {
            string path1 = @"C:\Users\LENOVO\source\repos\AddressBookSystem\AddressBookSystem\AddressBook.csv"; //path of csv file is stored in path
            Console.WriteLine("Writing contacts in CSV file");
            using (var writer = new StreamWriter(path1))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(People); //contacts are written in csv file 
            }
            using (var reader = new StreamReader(path1))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>().ToList(); // contacts from csv file are converted in list and stored in records
                Console.WriteLine("Reading contacts from CSV file");
                foreach (Person person in records)//foreach loop is used to print all contacts
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Full name : " + person.FirstName + " " + person.LastName);
                    Console.WriteLine("Mobile number : " + person.PhoneNumber);
                    Console.WriteLine("Email ID : " + person.Email);
                    Console.WriteLine("Address : " + person.Address);
                    Console.WriteLine("City : " + person.City);
                    Console.WriteLine("State : " + person.State);
                    Console.WriteLine("Zipcode : " + person.ZipCode);
                }
            }
        }
    }
}
