
using System.Diagnostics;
using VendingMachine;
using System.Data.SqlClient;
using Npgsql;

//Connect to the postgres database named Automaten
NpgsqlConnection conn = new NpgsqlConnection("\r\nHost=127.0.0.1;Port=5432;Database=Automaten;Username=postgres;Password=Kode1234!");

//Open the connection to the database
conn.Open();

//Make a command to select all in the table item
NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM item", conn);

//Read what in the database
NpgsqlDataReader rdr = cmd.ExecuteReader();

//Loop through the table
while (rdr.Read())
{
    //Print out what is in the table
    Console.WriteLine(rdr[0]);
}

//Test to see if it works
Console.WriteLine("Virker");

//Closing the connection to the database
conn.Close();


//Makes an interface withe all the services that needs to be in the machine
IVendingMachineController ctrl = new VendingMachineController(new MoneyService(), new GuiService(), new ItemService());

//Shows the method InsertMoney and and how many money you have (ShowMoney)
ctrl.ShowMoney(ctrl.InsertMoney());

//Show all the items
ctrl.ShowAllItems();

//Shows method to select items and show the selected items
ctrl.ShowSelctedItems(ctrl.SelectItem());