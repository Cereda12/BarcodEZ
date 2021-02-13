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
    class Json
    {
        string Asin { get; }
    }
    public class ClasseAPI
    {
        static bool permesso = false;

        public static string ReqAsin(string ean)
        {
            if (!permesso)
                throw new Exception("Troppe richieste");

            var client = new RestClient($"https://amazon-price1.p.rapidapi.com/upcToAsin?upc={ean}&marketplace=ES");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "e3a9ddf2d3mshdc71524468db118p1d82edjsnb5391767148e");
            request.AddHeader("x-rapidapi-host", "amazon-price1.p.rapidapi.com");
            IRestResponse response = client.Execute(request);

            var Risp = (Risposta)JsonConvert.DeserializeObject<Risposta>(response.Content);
            if (string.IsNullOrEmpty(Risp.Asin))
                return "Prodotto non trovato";
            return Risp.Asin;
        }
        public class Risposta
        {
            public string Asin { get; set; }
        }

        public string ReqLink(string asin)
        {
            return $"https://www.amazon.es/dp/{asin}";
        }
    }
}