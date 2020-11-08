using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLINQ
{
    public class Mgmt
    {
        public static DataTable dataTable = new DataTable();
        /// <summary>
        /// Creates the data table
        /// </summary>
        public static void CreateTable_UC2()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(int));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("EmailID", typeof(string));

            dataTable.Rows.Add("Rachit", "Rathi", "Mumbai", "Juhu", "Mah", 400080, "122345", "rachit@gmail.com");
            dataTable.Rows.Add("Yash", "Patil", "Mumbai", "Goregaon", "Mah", 400080, "185345", "yash@gmail.com");
            dataTable.Rows.Add("Tanmay", "Maity", "Kolkatta", "Eden", "Bengal", 600080, "122744", "tanmay@gmail.com");
            dataTable.Rows.Add("Parth", "Trivedi", "Rajkot", "Jaamnagar", "Gujarat", 600804, "928345", "parth@gmail.com");
            dataTable.Rows.Add("Mohit", "Rathi", "Mumbai", "Thane", "Mah", 700805, "522345", "mohit@gmail.com");

            DisplayDataTable();

        }
        /// <summary>
        /// Displays the data table.
        /// </summary>
        public static void DisplayDataTable()
        {
            var stringTable = from product in dataTable.AsEnumerable() select product;

            foreach (var row in stringTable)
            {
                Console.WriteLine("FirstName: " + row.Field<string>("FirstName") + ", LastName: " + row.Field<string>("LastName") + ", Address: " + row.Field<string>("Address") + " , City: " + row.Field<string>("City") + " , State: " + row.Field<string>("State") + ", Zip: " + row.Field<int>("Zip") + " , PhoneNumber: " + row.Field<string>("PhoneNumber") + ", EmailID: " + row.Field<string>("EmailID"));
            }
        }
    }
}
