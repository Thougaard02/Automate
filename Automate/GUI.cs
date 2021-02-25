using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate
{
    class GUI
    {
        User user = new User();

        private void Menu()
        {
            //Console menu
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("               Select a soda you want             ");
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Coca Cola");
            Console.WriteLine("2. Fanta");
            Console.WriteLine("3. 7 Up");
            Console.WriteLine("4. Pepsi Max");
            Console.WriteLine("5. Exit");
        }

        public void Machine()
        {
            //Object of vendingmachine and the price of the sodas
            VendingMachine vendingMachine = new VendingMachine(5.99, 9.99, 15.98, 30.99);

            while (true)
            {
                Menu();
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                user.SelectSoda(vendingMachine, userInput);
                Console.WriteLine(user.BuySoda(vendingMachine));
                Console.WriteLine("Insert money into the vending machine!");
                vendingMachine.MoneyReceived = double.Parse(Console.ReadLine());
                Console.WriteLine(user.ReturnMoney(vendingMachine));
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
