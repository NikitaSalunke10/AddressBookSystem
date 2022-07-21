using AddressBookSystem;

Console.WriteLine("Welcome to AddressBook Program.");
AddressBook addressBook = new AddressBook(); // creating the object of AddressBook class
//addressBook.addContact(); // calling this method to add the contact
//addressBook.listContact(); //calling this method to print the list of contacts
int option = 0;
while(option != 3) //while loop is used so user can enter option of which task to perform and it will execute till it get value 3
{
    Console.WriteLine("Press 1 for add contact./n Press 2 for list the contact./n Press 3 to exit.");
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
        case 3:// if option value 3 is entered then it matches with this case and it will exit the code after displaying message
            Console.WriteLine("Exiting from Program.");
            break;
        default: //if all the above cases doesn't match then it will print below message
            Console.WriteLine("Wrong option.");
            break;
    }
}