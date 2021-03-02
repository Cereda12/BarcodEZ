using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Linq;
using System.Text;

namespace DemoConsoleAmazonScraping
{
    class AmazonScraping
    {
        /// <summary>
        /// Metodo che estrapola l'HTML della pagina di cui si passa l'URL
        /// </summary>
        /// <param name="url">L'URL della pagina web da cui si vuole estrapolare l'HTML</param>
        /// <returns></returns>
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
        /// Metodo che estrae i dati dall'HTML e restituisce un Json contenente vari elementi della pagina Amazon
        /// </summary>
        /// <param name="strHtml">L'HTML estrapolato dalla funzione AmazonScraping.GetRequest</param>
        /// <returns></returns>
        public static object DataParse(string strHtml)
        {
            string Name = string.Empty;
            string Price = string.Empty;
            string Description = string.Empty;

            //Uso HTML Agility pack
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(strHtml);
            htmlDocument.DocumentNode.Descendants()
                .Where(n => n.Name == "script" || n.Name == "style")
                .ToList()
                .ForEach(n => n.Remove());

            Name = htmlDocument.DocumentNode.SelectSingleNode("//span[@id='productTitle']").InnerText.Trim();
            Price = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='a-color-price']").InnerText.Trim();
            Description = htmlDocument.DocumentNode.SelectSingleNode("//div[@id='productDescription']//p").InnerText.Trim();

            return new
            {
                name = Name,
                price = Price,
                description=Description
            };
        }
    }
}
