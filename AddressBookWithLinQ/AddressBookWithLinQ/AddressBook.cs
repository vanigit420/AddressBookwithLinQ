using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESSBOOKwithLINQ
{
    internal class AddressBook
    {
        public void AddToDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("FirstName");
            table.Columns.Add("LastName");
            table.Columns.Add("Address");
            table.Columns.Add("City");
            table.Columns.Add("State");
            table.Columns.Add("ZipCode");
            table.Columns.Add("PhoneNumber");
            table.Columns.Add("Email");


            table.Rows.Add("Milan", "Biranwar", "Katraj", "Pune", "Maharashtra", "441601", "1234567892", "abcde@gamil.com");

            DisplayFirstNameFromTable(table);
            //DisplayLastNameFromTable(table);
            //DisplayAddressFromTable(table);
            //DisplayCityFromTable(table);
            //DisplayStateFromTable(table);
            //DisplayZipCodeFromTable(table);
            //DisplayPhoneNumberFromTable(table);
            //DisplayEmailFromTable(table);

        }

        public void DisplayFirstNameFromTable(DataTable table)
        {

            var FirstName = from firstname in table.AsEnumerable() select firstname.Field<string>("FirstName");
            Console.WriteLine("FirstName: ");
            foreach (string firstName in FirstName)
            {
                Console.WriteLine(firstName);
            }

        }

    }
}