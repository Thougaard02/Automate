using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate
{
    class VendingMachine
    {
        private Soda product;

        public Soda Product
        {
            get { return product; }
            set { product = value; }
        }

        private double moneyReceived;

        public double MoneyReceived
        {
            get { return moneyReceived; }
            set { moneyReceived = value; }
        }

        private double moneyReturn;

        public double MoneyReturn
        {
            get { return moneyReturn; }
            set { moneyReturn = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        //Creates and sets price acording to parametes
        public VendingMachine(double cocaCola,  double fanta, double sevenUp, double pepsiMax)
        {
            Product = new Soda();
            Product.Price = new SodaPrice(cocaCola, fanta, sevenUp, pepsiMax);
        }
    }
}
