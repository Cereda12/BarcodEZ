using System.Net;
using System.IO;
using System.Linq;

namespace DemoConsoleScraping
{
    class EbayScraping
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
        /// Metodo che estrae i dati dall'HTML e restituisce un oggetto EbayProduct contenente vari elementi della pagina Amazon
        /// </summary>
        /// <param name="strHtml">L'HTML estrapolato dalla funzione EbayScraping.GetRequest</param>
        /// <returns>Oggetto EbayProduct</returns>
        public static EbayProduct DataParse(string strHtml)
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

            Name = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='vi-lkhdr-itmTitl']").InnerText.Trim();
            Price = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='prcIsum']").InnerText.Trim();
            FullPrice = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='orgPrc']")?.InnerText.Trim();

            price = Price.Split((char)32);
            if(string.Compare(price[0], "EUR")!=0)
            {
                Price = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='convbidPrice']").InnerText.Trim();
                price = Price.Split((char)32);
                string price2 = price[1].Substring(0, price[1].IndexOf(',') + 3);
                price[1] = price2;
            }
            FinalPrice = decimal.Parse(price[1]);
            if (!(string.Compare(FullPrice, null) == 0))
            {
                fullprice = FullPrice.Split((char)32);
                FinalFullPrice = decimal.Parse(fullprice[1]);
            }
            EbayProduct result = new EbayProduct(Name, FinalPrice, FinalFullPrice);

            return result;
        }
        /// <summary>
        /// Metodo che estra il link appartenente al primo prodotto trovato ricercando con il codice ean
        /// </summary>
        /// <param name="ean">Il codice ean del prodotto da ricercare</param>
        /// <returns>L'url del prodotto corrispondente all'ean</returns>
        public static string ExtractFirstHref(string ean)
        {
            string searchingUrl = string.Empty;
            string extractedUrl = string.Empty;
            string strHtml = string.Empty;

            if (ean.Length!=13 && ean.Length!=8)
            {
                extractedUrl = null;
                return extractedUrl;
            }
            searchingUrl = $"https://www.ebay.it/sch/{ean}";
            strHtml = GetRequest(searchingUrl);

            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(strHtml);
            htmlDocument.DocumentNode.Descendants()
                .Where(n => n.Name == "script" || n.Name == "style")
                .ToList()
                .ForEach(n => n.Remove());
            extractedUrl = htmlDocument.DocumentNode.SelectSingleNode("//div[@id='mainContent']//li[1]//a")?.Attributes["href"].Value;

            return extractedUrl;
        }
    }
}
