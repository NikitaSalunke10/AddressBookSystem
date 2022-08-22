using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook Program.");
AddressBook addressBook = new AddressBook(); // creating the object of AddressBook class
int option = 0;
while(option != 12) //while loop is used so user can enter option of which task to perform and it will execute till it get value 3
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Press 1 for Add Contact.\nPress 2 for List the Contact.\nPress 3  to Edit the Contact.");
    Console.WriteLine("Press 4 to Delete the Contact.\nPress 5 to add Unique Contact.");
    Console.WriteLine("Press 6 to Display Unique Contacts.\nPress 7 to Search a Contact.");
    Console.WriteLine("Press 8 to Display Sorted Contacts.\nPress 9 to Write and Read Contacts from file.");
    Console.WriteLine("Press 10 to Write and Read Contacts from CSV file.\nPress 11 to Read and Write contacts in CSV using JSON.\nPress 12 to exit");
    Console.WriteLine("Please enter option number: ");
    option = int.Parse(Console.ReadLine()); // taking value of option through console  

    switch(option)
    {
        case 1: // if option value 1 is entered then it matches with this case and user will be able to add contact
            addressBook.addContact();
            break;
        case 2: //if option value 2 is entered then it matches with this case and user will get the list of contact store in List 
            addressBook.listContact();
            break;
        case 3:// if option value 3 is entered then it matches with this case and user will be able to edit the contact
            addressBook.editContact();
            break;
        case 4:// if option value 4 is entered then it matches with this case and user will be able to delete the contact
            addressBook.deleteContact();
            break;
        case 5: // if option 5 is entered then it will ask user to enter first name and that contact will be added in unique addressbook
            addressBook.AddUniqueContact();
            break;
        case 6: // if option 6 is entered then it will display the unique contacts from dictionary
            addressBook.displayUniqueContact();
            break;
        case 7: //option 7 is entered then it will ask for city or state to enter and search the contact
            addressBook.ViewPersonByCityState();
            break;
        case 8: //option 8 is entered then it will display the sorted contacts
            addressBook.SortContacts();
            break;
        case 9:// if option 9 is then all the contacts are written and read from file
            addressBook.ReadWriteFile();
            break;
        case 10: // if option 10 is then all the contacts are written and read from csv file
            addressBook.ReadWriteCSVFile();
            break;
        case 11:// if option 11 is then all the contacts are written and read using JSON
            addressBook.ReadWriteCSVJSON();
            break;
        case 12:// if option value 12 is entered then it matches with this case and it will exit the code after displaying message
            Console.WriteLine("Exiting from Program.");
            break;
        default: //if all the above cases doesn't match then it will print below message
            Console.WriteLine("Wrong option.");
            break;
    }
}