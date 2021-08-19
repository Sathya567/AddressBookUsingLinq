using System;

namespace AddressBookSystem_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_To_AddressBookSystem_Linq");
            AddressBookModel model = new AddressBookModel();
            AddressBookDataTable dataTable = new AddressBookDataTable();
            dataTable.CreateTable(model);
            dataTable.Display();
        }
    }
}
