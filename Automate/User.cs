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

            switch (userInput)
            {
                case 1:
                    vendingMachine.Product.Flavour = Flavours.CocaCola;
                    break;
                case 2:
                    vendingMachine.Product.Flavour = Flavours.Fanta;
                    break;
                case 3:
                    vendingMachine.Product.Flavour = Flavours.SevenUp;
                    break;
                case 4:
                    vendingMachine.Product.Flavour = Flavours.CocaCola;
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
            }
        }

        // Buy the soda you selected
        public string BuySoda(VendingMachine vendingMachine)
        {
            //Check is product flavour is equal to the enum of flavours and selects the flavour you picked in "SelectSoda" metheod
            if (vendingMachine.Product.Flavour == Flavours.CocaCola)
            {
                vendingMachine.Price = vendingMachine.Product.Price.CocaCola;
                return $"You choose Coca Cola, it will be {vendingMachine.Product.Price.CocaCola}";
            }
            else if (vendingMachine.Product.Flavour == Flavours.Fanta)
            {
                vendingMachine.Price = vendingMachine.Product.Price.Fanta;
                return $"You choose Fanta, it will be {vendingMachine.Product.Price.Fanta}";
            }
            else if (vendingMachine.Product.Flavour == Flavours.SevenUp)
            {
                vendingMachine.Price = vendingMachine.Product.Price.SevenUp;
                return $"You choose 7 Up, it will be {vendingMachine.Product.Price.SevenUp}";
            }
            else if (vendingMachine.Product.Flavour == Flavours.PepsiMax)
            {
                vendingMachine.Price = vendingMachine.Product.Price.SevenUp;
                return $"You choose Pepsi Max, it will be {vendingMachine.Product.Price.PepsiMax}";
            }
            return null;
        }

        public string ReturnMoney(VendingMachine vendingMachine)
        {
            //Checks if user have insert enough money to buy for the soda
            if (vendingMachine.MoneyReceived >= vendingMachine.Price)
            {
                //Calculates the amount of money to give back
                vendingMachine.MoneyReturn = vendingMachine.MoneyReceived - vendingMachine.Price;
                return $"Returning {vendingMachine.MoneyReturn} back";
            }
            //If the user has not inserted enough money
            else
            {
                return "You have to insert more money";
            }
        }
    }
}
