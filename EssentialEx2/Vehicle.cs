using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential17
{
    internal class Vehicle
    {
        private string marka;
        private string model;
        private string color;
        private int yaerOfManufacture;

        public Vehicle(string marka,string model, string color, int year)
        {
            this.marka = marka;
            this.model = model;
            this.color = color;
            this.yaerOfManufacture = year;
        }

       public string Marka
        {
            get { return marka; }
        }

        public string Model
        {
            get { return model; }
        }

        public string Color
        {
            get { return color; }
        }

        public int YearOfManufacture
        {
            get { return yaerOfManufacture; }
        }
    }
}
