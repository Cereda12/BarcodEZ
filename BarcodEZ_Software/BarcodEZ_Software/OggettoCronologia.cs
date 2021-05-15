using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BarcodEZ_Software
{
    class OggettoCronologia : IDisposable
    {
        private string _Ean;
        public string Ean
        {
            get { return _Ean; }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valore non valido");
                if (value.Length != 8 && value.Length != 12 && value.Length != 13) 
                    throw new Exception("Valore non valido");
                _Ean = value;
            }
        }

        private DateTime _Data;        
        public DateTime Data
        {
            get { return _Data; }

            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Valore non valido");
                _Data = value;                     
            }
        }
        public OggettoCronologia(string ean, DateTime Data)
        {
            if (string.IsNullOrEmpty(ean))
                throw new Exception("Valore non valido");
            Ean = ean;
            this.Data = Data;
        }

        bool disposed = false;

        protected virtual void Dispose(bool disposine)
        {
            if(!disposed)
            {
                if(disposine)
                {

                }
                disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~OggettoCronologia()
        {
            Dispose(false);
        }
        public static void Serializza(List<OggettoCronologia> item)
        {
            string json = JsonConvert.SerializeObject(item, Formatting.Indented);
            File.WriteAllText("cronologia.json", json);
        }
        public static List<OggettoCronologia> Deserializza()
        {
            string json = File.ReadAllText("cronologia.json");
            return JsonConvert.DeserializeObject<List<OggettoCronologia>>(json);
        }
    }
}
