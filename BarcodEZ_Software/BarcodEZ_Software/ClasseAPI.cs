using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using RestSharp;

namespace BarcodEZ_Software
{
    public class ClasseAPI
    {
        #region Chiave API
        private static string key = "e3a9ddf2d3mshdc71524468db118p1d82edjsnb5391767148e";
        #endregion

        public static int ricerche = 0;

        public static string ReqAsin(string ean)
        {
            if (ricerche > 5)
                throw new Exception("Troppe richieste");

            var client = new RestClient($"https://amazon-price1.p.rapidapi.com/upcToAsin?upc={ean}&marketplace=ES");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", key);
            request.AddHeader("x-rapidapi-host", "amazon-price1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            ricerche++;

            var Risp = (Risposta)JsonConvert.DeserializeObject<Risposta>(response.Content);

            if (string.IsNullOrEmpty(Risp.Asin))
                return "Prodotto non trovato";

            return Risp.Asin;
        }
        public class Risposta
        {
            public string Asin { get; set; }
        }

        public static string ReqLink(string asin)
        {
            return $"https://www.amazon.es/dp/{asin}";
        }
    }
}