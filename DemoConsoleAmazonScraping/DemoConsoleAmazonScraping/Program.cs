using System;
using Newtonsoft.Json;

namespace DemoConsoleScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            string url1 = "https://www.amazon.it/Eastpak-Astuccio-Unisex-Taglia-5x22x9/dp/B000VZK4FK/ref=mp_s_a_1_2?dchild=1&keywords=eastpak+astuccio&qid=1612001436&sr=8-2";
            string url2 = "https://www.amazon.it/STABILO-ORIGINAL-Evidenziatore-colore-Giallo/dp/B0017YOQ44/ref=sr_1_10?__mk_it_IT=%C3%85M%C3%85%C5%BD%C3%95%C3%91&dchild=1&keywords=stabilo+boss&qid=1613216368&sr=8-10";
            string url3 = "https://www.amazon.it/Capitano-Elasticizzata-Chiusura-Regolare-molteplici/dp/B07JJNJ5G4/ref=sr_1_2_sspa?__mk_it_IT=%C3%85M%C3%85%C5%BD%C3%95%C3%91&dchild=1&keywords=fascia+da+capitano&qid=1614421466&sr=8-2-spons&psc=1&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUFMSk9aVVhTVjVCNUYmZW5jcnlwdGVkSWQ9QTA0MTg3ODUzQzZYVkRSWFRTNTIyJmVuY3J5cHRlZEFkSWQ9QTA2NzI2MjQyUkdBNjU0NlVLUzM0JndpZGdldE5hbWU9c3BfYXRmJmFjdGlvbj1jbGlja1JlZGlyZWN0JmRvTm90TG9nQ2xpY2s9dHJ1ZQ==";
            string url4 = "https://www.amazon.it/Hydraflow-Industries-BAI002-realizzare-Sushi-Maki/dp/B002AVYQNY/ref=sr_1_4?__mk_it_IT=%C3%85M%C3%85%C5%BD%C3%95%C3%91&dchild=1&keywords=bazooka+sushi&qid=1614421550&sr=8-4";
            string strHtml = string.Empty;
            scelta = int.Parse(Console.ReadLine());
            switch(scelta)
            {
                case 1:
                    {
                        Console.WriteLine($"Fetch Data From URL {url1}");
                        strHtml = AmazonScraping.GetRequest(url1);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Fetch Data From URL {url2}");
                        strHtml = AmazonScraping.GetRequest(url2);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Fetch Data From URL {url3}");
                        strHtml = AmazonScraping.GetRequest(url3);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"Fetch Data From URL {url4}");
                        strHtml = AmazonScraping.GetRequest(url4);
                        break;
                    }
            }            
            object result = AmazonScraping.DataParse(strHtml);
            Console.WriteLine("Result :");
            Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            Console.ReadLine();
        }
    }
}
