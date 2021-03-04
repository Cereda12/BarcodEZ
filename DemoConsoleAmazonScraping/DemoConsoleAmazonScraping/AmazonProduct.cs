using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleAmazonScraping
{
    public class AmazonProduct
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Stringa non valida");
                _name = value;
            }
        }
        private string _price;
        public string price
        {
            get { return _price; }
            set
            {
                //decimal result;
                //if (!decimal.TryParse(value, out result))
                //    throw new Exception("Stringa non valida");
                //if (result <= 0)
                //    throw new Exception("Prezzo non valido");
                _price = value;
            }
        }
        private string _description;
        public string description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Stringa non valida");
                _description = value;
            }
        }
        public AmazonProduct(string Name, string Price, string Description)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Price) || string.IsNullOrEmpty(Description))
                throw new Exception("Stringa non valida");
            this.name = Name;
            this.price = Price;
            this.description = Description;
        }
    }
}
