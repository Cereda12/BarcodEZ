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
            string Description = string.Empty;
            decimal FinalPrice = 0;
            string[] price = new string[2];

            //Uso HTML Agility pack
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(strHtml);
            htmlDocument.DocumentNode.Descendants()
                .Where(n => n.Name == "script" || n.Name == "style")
                .ToList()
                .ForEach(n => n.Remove());

            Name = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='vi-lkhdr-itmTitl']").InnerText.Trim();
            Price = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='prcIsum']").InnerText.Trim();
            price = Price.Split((char)32);
            FinalPrice = decimal.Parse(price[1]);
            EbayProduct result = new EbayProduct(Name, FinalPrice);

            return result;
        }
    }
}
