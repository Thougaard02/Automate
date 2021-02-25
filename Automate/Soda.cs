using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate
{
    //Enum variation of sodas
    public enum Flavours
    {
        CocaCola,
        PepsiMax,
        Fanta,
        SevenUp
    }
    class Soda
    {
        //Properties
        private Flavours flavour;

        public Flavours Flavour
        {
            get { return flavour; }
            set { flavour = value; }
        }

        private SodaPrice price;

        public SodaPrice Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
