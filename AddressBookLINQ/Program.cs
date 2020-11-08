using System;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book LINQ!");
            Console.WriteLine();
            Console.WriteLine("Created DataTable for AddressBook");
            Mgmt.CreateTable();
            Console.WriteLine();
            Console.WriteLine("UC3 Insert Row into DataTable AddressBook");
            Mgmt.InsertRowIntoTable();
            Console.WriteLine();
            Console.WriteLine("UC4 Edit Record By Name into DataTable AddressBook");
            Mgmt.EditContactByName();

        }
    }
}
