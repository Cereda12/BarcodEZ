using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleScraping
{
    class EbayProduct
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
        private decimal _price;
        public decimal price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                    throw new Exception("Prezzo non valido");
                _price = value;
            }
        }
        private decimal _fullprice;
        public decimal fullprice
        {
            get { return _fullprice; }
            set
            {
                if (value <= 0)
                {
                    _fullprice = -1;
                    return;
                }
                _fullprice = value;
            }
        }
        public EbayProduct(string Name, decimal Price, decimal FullPrice)
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("Stringa non valida");
            this.name = Name;
            this.price = Price;
            this.fullprice = FullPrice;
        }
    }
}
