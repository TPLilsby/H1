using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    //class for the Controller, that controls how the machine behave
    //implment the Controller inteface
    class VendingMachineController : IVendingMachineController
    {
        //Readonly varable for the diffren interfaces
        private readonly IMoneyService _moneyService;
        private readonly IGuiService _guiService;
        private readonly IItemService _itemService;

        //Constroctor with the diffrent interfaces
        public VendingMachineController(IMoneyService money, IGuiService gui, ItemService itemService)
        {
            _moneyService = money;
            _guiService = gui;
            _itemService = itemService;
        }

        //Insert money
        public double InsertMoney()
        {
            return this._guiService.InsertMoney();
        }

        //Show money to GUI
        public void ShowMoney(double amount)
        {
            this._guiService.ShowMoney(this._moneyService.CalculateTotalPayment(amount));
        }

        //Select items to buy
        public int SelectItem()
        {
            return this._guiService.SelectItem();
        }

        //Show the selected items
        public void ShowSelctedItems(int id)
        {
            this._guiService.ShowSelectedItem(this._guiService.SelectItem());
        }

        public void ShowAllItems()
        {
            this._guiService.ShowAllItems(this._itemService.GetAllItems());
        }

        //Kan ikke få den til at vis avaivable items udfra pris så jeg ShowAllItems/GetAllItems

        /*public void ShowAvaivableItems()
        {
            this._guiService.ShowAvaivableItems(this._itemService.GetAvaivableItems());
        }*/
    }
}
