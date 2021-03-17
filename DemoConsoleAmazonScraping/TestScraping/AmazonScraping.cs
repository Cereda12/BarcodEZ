using System.Net;
using System.IO;
using System.Linq;
using System;

namespace DemoConsoleScraping
{
    class AmazonScraping
    {
        /// <summary>
        /// Metodo che estrapola l'HTML della pagina di cui si passa l'URL
        /// </summary>
        /// <param name="url">L'URL della pagina web da cui si vuole estrapolare l'HTML</param>
        /// <returns>La stringa dell'html corrispondente</returns>
        public static string GetRequest(string url)
        {
            string strhtml = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                strhtml = reader.ReadToEnd();
            }
            return strhtml;
        }
        /// <summary>
        /// Metodo che estrae i dati dall'HTML e restituisce un oggetto AmazonProduct contenente vari elementi della pagina Amazon
        /// </summary>
        /// <param name="strHtml">L'HTML estrapolato dalla funzione AmazonScraping.GetRequest</param>
        /// <returns>Oggetto AmazonProduct</returns>
        public static AmazonProduct DataParse(string strHtml)
        {
            string Name = string.Empty;
            string Price = string.Empty;
            string FullPrice = string.Empty;
            string Description = string.Empty;
            decimal FinalPrice = 0;
            decimal FinalFullPrice = 0;
            string[] price = new string[2];
            string[] fullprice = new string[2];

            //Uso HTML Agility pack
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(strHtml);
            htmlDocument.DocumentNode.Descendants()
                .Where(n => n.Name == "script" || n.Name == "style")
                .ToList()
                .ForEach(n => n.Remove());

            Name = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='productTitle']").InnerText.Trim();

            Price = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='priceblock_ourprice']")?.InnerText.Trim();
            if (Price == null)
            {
                Price = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='priceblock_dealprice']")?.InnerText.Trim();
                if (Price == null)
                {
                    Price = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='a-color-price']")?.InnerText.Trim();
                }
                else
                {
                    FullPrice = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='priceBlockStrikePriceString a-text-strike']")?.InnerText.Trim();
                }
            }

            Description = htmlDocument.DocumentNode.SelectSingleNode("//div[@id='productDescription']//p")?.InnerText.Trim();
            if (Description == null)
            {
                Description = "Descrizione non disponibile. Visitare la pagina del prodotto";
            }

            price = Price.Split((char)160);
            FinalPrice = decimal.Parse(price[0]);
            if (!(string.Compare(FullPrice, "") == 0))
            {
                fullprice = FullPrice.Split((char)160);
                FinalFullPrice = decimal.Parse(fullprice[0]);
            }
            AmazonProduct result = new AmazonProduct(Name, FinalPrice, Description, FinalFullPrice);

            return result;
        }
    }
}
