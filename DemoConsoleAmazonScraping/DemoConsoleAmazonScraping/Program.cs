using System;
using Newtonsoft.Json;

namespace DemoConsoleScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            int scelta=0;
            while (scelta!=99)
            {
                string url1 = "https://www.amazon.it/Eastpak-Astuccio-Unisex-Taglia-5x22x9/dp/B000VZK4FK/ref=mp_s_a_1_2?dchild=1&keywords=eastpak+astuccio&qid=1612001436&sr=8-2";
                string url2 = "https://www.amazon.it/Capitano-Elasticizzata-Chiusura-Regolare-molteplici/dp/B07JJNJ5G4/ref=sr_1_2_sspa?__mk_it_IT=%C3%85M%C3%85%C5%BD%C3%95%C3%91&dchild=1&keywords=fascia+da+capitano&qid=1614421466&sr=8-2-spons&psc=1&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUFMSk9aVVhTVjVCNUYmZW5jcnlwdGVkSWQ9QTA0MTg3ODUzQzZYVkRSWFRTNTIyJmVuY3J5cHRlZEFkSWQ9QTA2NzI2MjQyUkdBNjU0NlVLUzM0JndpZGdldE5hbWU9c3BfYXRmJmFjdGlvbj1jbGlja1JlZGlyZWN0JmRvTm90TG9nQ2xpY2s9dHJ1ZQ==";
                string url3 = "https://www.ebay.it/itm/GRIGLIA-ELETTRICA-2000W-BARBECUE-GRILL-BISTECCHIERA-BBQ-DA-GIARDINO-O-INTERNO/203017653075?_trkparms=ispr%3D1&hash=item2f44cb8b53:g:LkMAAOSwJp5e4Lnb&amdata=enc%3AAQAFAAACcBaobrjLl8XobRIiIML1V4Imu%252Fn%252BzU5L90Z278x5ickkrmmq8hWevtuKE7%252F%252BLfVXtvephhz%252FrBmIfMez%252BIaccgi%252B6h8toR4WNzL96O%252BKqEbWaSPqrw9I6ihDDED85y26%252F%252F9OKqVd%252B7Rtzh2lF2nlWJ47ebj8LnZ4fAXZ1JqPt%252B0WinjlHWN51%252FUhTqjsst%252B%252FcJx9%252FSgi7iYMUfWydfsLwS0%252BfoZqHgcrULfi9PO4VQH67KSfrX7JWAxC6mnVgCwQdQL9hcvOf4hOZOAjbvkZI9%252BtbvJHobL%252Boc4MVSRAgXfVbCQnCbZH21iPTbt8N58aV5DPeLUhQZzLIZst5P%252Brx95KqGoiq9I2T%252FqbzQqBHExpFM7pYCyTLOJvv0lNc0FXIysxi%252FoFBtsJPN7ysy0gDAJTffJ%252FXWmSA2Gu%252BdrWTuHLCE8GURbeGtPz%252BwHXZZloZaTM284meUh53sOTjv24r3FdH4auJ%252BLLE0ncRujofIRumefIKShIJxLzre9bLB6ru%252F0rrS1z26bF0IPT3qk3oWsX7YLOSeaOMJiKTyUPfOcbDEIXEsaTM84ViIBbPVcuYhtBrt0vXt%252F0rhbq8cf6piVFpGh3AFyTpgR4epWifUapM56QVnrTWfT6E5Wj%252B9f%252FLjeJqUET7Tnuo31lwkkJIhArq9wDa4R%252BxzfoXFYs5sbO1AeTjeTLI1hq3yVJrEjaIlQ4cpfi6uwzTVCEa2cwZ2msH%252Fm3JIVCTkR6%252F0ZM%252BK2qo3HeP9t7ZCLhz%252Fyg1b1Ljs4jzQy1dnrUqyQNTiuNVaWeZX73VHEAV3Ks0mYg5kERNUiP9ZY8ltYmwIiQ9fHfAw%253D%253D%7Ccksum%3A2030176530751eb977c1e0c94c92adfd384a4f0e3e0d%7Campid%3APL_CLK%7Cclp%3A2334524";
                string url4 = "https://www.ebay.it/itm/COMPUTER-PORTATILE-NOTEBOOK-HP-255-G8-15-6-AMD-RAM-4GB-SSD-256GB-NVMe-WEBCAM/362797930441?hash=item54787117c9:g:EnQAAOSwixNgBsTN";
                string strHtml = string.Empty;
                scelta = int.Parse(Console.ReadLine());
                object result = default(object);
                switch (scelta)
                {
                    case 1:
                        {
                            Console.WriteLine($"Fetch Data From URL {url1}");
                            strHtml = AmazonScraping.GetRequest(url1);
                            result = AmazonScraping.DataParse(strHtml);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Fetch Data From URL {url2}");
                            strHtml = AmazonScraping.GetRequest(url2);
                            result = AmazonScraping.DataParse(strHtml);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Fetch Data From URL {url3}");
                            strHtml = EbayScraping.GetRequest(url3);
                            result = EbayScraping.DataParse(strHtml);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"Fetch Data From URL {url4}");
                            strHtml = EbayScraping.GetRequest(url4);
                            result = EbayScraping.DataParse(strHtml);
                            break;
                        }
                }
                Console.WriteLine("Result :");
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }            
            Console.ReadLine();
        }
    }
}
