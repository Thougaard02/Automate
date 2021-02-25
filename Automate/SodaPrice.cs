using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automate
{
    class SodaPrice
    {
        //Properties
        private double cocaCola;

        public double CocaCola
        {
            get { return cocaCola; }
            set { cocaCola = value; }
        }

        private double fanta;

        public double Fanta
        {
            get { return fanta; }
            set { fanta = value; }
        }

        private double sevenUp;

        public double SevenUp
        {
            get { return sevenUp; }
            set { sevenUp = value; }
        }

        private double pepsiMax;

        public double PepsiMax
        {
            get { return pepsiMax; }
            set { pepsiMax = value; }
        }

        //Price of the difference sodas
        public SodaPrice(double cocaCola, double fanta, double sevenUp, double pepsiMax  )
        {
            CocaCola = cocaCola;
            Fanta = fanta;
            SevenUp = sevenUp;
            PepsiMax = pepsiMax;
        }
    }
}
