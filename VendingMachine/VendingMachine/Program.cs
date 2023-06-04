
using System.Diagnostics;
using VendingMachine;

//Makes an interface withe all the services that needs to be in the machine
IVendingMachineController ctrl = new VendingMachineController(new MoneyService(), new GuiService(), new ItemService());

//Shows the method InsertMoney and and how many money you have (ShowMoney)
ctrl.ShowMoney(ctrl.InsertMoney());

//Show all the items
ctrl.ShowAllItems();

//Shows method to select items and show the selected items
ctrl.ShowSelctedItems(ctrl.SelectItem());