using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential17
{
    internal class Buyer
    {
        private string model;
        private string buyerName;
        private string phoneNumber;

        public Buyer(string model, string name, string phone)
        {
            this.model = model;
            this.buyerName = name;
            this.phoneNumber = phone;
        }

        public string Model
        {
            get { return model; } 
        }

        public string BuyerName
        {
            get { return buyerName; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
        }
    }
}
