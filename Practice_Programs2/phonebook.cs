using System;
using System.Collections;

class ContactManager
{
    public static void Main()
    {
        var contactDirectory = new Hashtable();

        while (true)
        {
            Console.WriteLine("\n############# Contact Manager ###########");
            Console.WriteLine("\t1: Add Contact");
            Console.WriteLine("\t2: Retrieve Contact");
            Console.WriteLine("\t3: Exit");
            Console.WriteLine("\n#################################");
            Console.WriteLine("\n\nEnter choice: ");
            int userSelection = Convert.ToInt32(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    AddContactToDirectory(contactDirectory);
                    break;
                case 2:
                    RetrieveContactFromDirectory(contactDirectory);
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("\nYou have entered an invalid choice");
                    break;
            }
        }
    }

    private static void AddContactToDirectory(Hashtable contactDirectory)
    {
        Console.Write("Enter contact's full name: ");
        string contactFullName = Console.ReadLine();

        Console.Write("Enter contact's phone number: ");
        long contactPhoneNumber = Convert.ToInt64(Console.ReadLine());

        contactDirectory.Add(contactFullName, contactPhoneNumber);
    }

    private static void RetrieveContactFromDirectory(Hashtable contactDirectory)
    {
        Console.Write("Enter contact's full name: ");
        string contactFullName = Console.ReadLine();

        if (contactDirectory[contactFullName] == null)
        {
            Console.WriteLine("Contact not found in the directory");
        }
        else
        {
            long contactPhoneNumber = Convert.ToInt64(contactDirectory[contactFullName]);
            DisplayContactDetails(contactFullName, contactPhoneNumber);
        }
    }

    private static void DisplayContactDetails(string contactFullName, long contactPhoneNumber)
    {
        Console.WriteLine("\nContact Details:");
        Console.WriteLine("Name: " + contactFullName);
        Console.WriteLine("Phone Number: " + contactPhoneNumber.ToString("D11"));
        Console.WriteLine();
    }
}