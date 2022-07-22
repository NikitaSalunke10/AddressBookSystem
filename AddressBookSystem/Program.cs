using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook Program.");
AddressBook addressBook = new AddressBook(); // creating the object of AddressBook class
int option = 0;
while(option != 5) //while loop is used so user can enter option of which task to perform and it will execute till it get value 3
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Press 1 for add contact.\nPress 2 for list the contact.\nPress 3  to edit the contact.");
    Console.WriteLine("Press 4 to delete the contact.\nPress 5 to exit");
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
        case 5:// if option value 5 is entered then it matches with this case and it will exit the code after displaying message
            Console.WriteLine("Exiting from Program.");
            break;
        default: //if all the above cases doesn't match then it will print below message
            Console.WriteLine("Wrong option.");
            break;
    }
}