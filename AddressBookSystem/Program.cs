using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook Program.");
AddressBook addressBook = new AddressBook(); // creating the object of AddressBook class
int option = 0;
while(option != 8) //while loop is used so user can enter option of which task to perform and it will execute till it get value 3
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Press 1 for add contact.\nPress 2 for list the contact.\nPress 3  to edit the contact.");
    Console.WriteLine("Press 4 to delete the contact.\nPress 5 to add Unique contact.");
    Console.WriteLine("Press 6 to display Unique Contacts.\nPress 7 to search a contact.\nPress 8 to exit");
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
            addressBook.SearchContact();
            break;
        case 8:// if option value 7 is entered then it matches with this case and it will exit the code after displaying message
            Console.WriteLine("Exiting from Program.");
            break;
        default: //if all the above cases doesn't match then it will print below message
            Console.WriteLine("Wrong option.");
            break;
    }
}