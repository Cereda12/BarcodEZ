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
                //try
                //{
                    string url1 = "https://www.amazon.it/Eastpak-Astuccio-Unisex-Taglia-5x22x9/dp/B000VZK4FK/ref=mp_s_a_1_2?dchild=1&keywords=eastpak+astuccio&qid=1612001436&sr=8-2";
                    string url2 = "https://www.amazon.it/dp/B087CHDW4Q";
                    string url3 = "https://www.ebay.it/itm/ASUS-ZENFONE-4-ZE554-64GB-4GB-RAM-NEVY-BLACK-24-mesi-garanzia-Italia/224281047834?_trkparms=5373%3A0%7C5374%3AFeatured";
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
                //}
                //catch(Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}                
            }            
            Console.ReadLine();
        }
    }
}
