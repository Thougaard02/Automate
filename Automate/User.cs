using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate
{
    class User
    {
        //User select a soda flavour
        public void SelectSoda(VendingMachine vendingMachine, int userInput)
        {
            //Coca Cola = 1
            //Fanta = 2
            //Seven Up = 3
            //Pepsi Max = 4

            if (userInput == 1)
            {
                vendingMachine.Product.Flavour = Flavours.CocaCola;
            }
            else if (userInput == 2)
            {
                vendingMachine.Product.Flavour = Flavours.Fanta;
            }
            else if (userInput == 3)
            {
                vendingMachine.Product.Flavour = Flavours.Fanta;
            }
            else if (userInput == 4)
            {
                vendingMachine.Product.Flavour = Flavours.Fanta;
            }
        }
        //Buy the soda you selected
        public string BuySoda(VendingMachine vendingMachine)
        {
            if (vendingMachine.Product.Flavour == Flavours.CocaCola)
            {
                vendingMachine.Price = vendingMachine.Product.Price.CocaCola;
                return $"You chose Coca Cola, it will be {vendingMachine.Product.Price.CocaCola}";
            }
            else if (vendingMachine.Product.Flavour == Flavours.Fanta)
            {
                vendingMachine.Price = vendingMachine.Product.Price.Fanta;
                return $"You chose Fanta, it will be {vendingMachine.Product.Price.Fanta}";
            }
            else if (vendingMachine.Product.Flavour == Flavours.SevenUp)
            {
                vendingMachine.Price = vendingMachine.Product.Price.SevenUp;
                return $"You chose 7 Up, it will be {vendingMachine.Product.Price.SevenUp}";
            }
            else if (vendingMachine.Product.Flavour == Flavours.PepsiMax)
            {
                vendingMachine.Price = vendingMachine.Product.Price.SevenUp;
                return $"You chose Pepsi Max, it will be {vendingMachine.Product.Price.PepsiMax}";
            }
            return null;
        }

        public string ReturnMoney(VendingMachine vendingMachine)
        {
            if (vendingMachine.MoneyReceived >= vendingMachine.Price)
            {
                vendingMachine.MoneyReturn = vendingMachine.MoneyReceived - vendingMachine.Price;
                return $"Returning {vendingMachine.MoneyReturn} back";
            }
            else
            {
                return "You have to insert more money";
            }
        }
    }
}
