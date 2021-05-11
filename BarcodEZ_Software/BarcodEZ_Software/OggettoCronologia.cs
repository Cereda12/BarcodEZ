using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BarcodEZ_Software
{
    class OggettoCronologia : IDisposable
    {
        private string _EAN;
        public string EAN
        {
            get { return _EAN; }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valore non valido");
                if (value.Length != 8 && value.Length != 13) 
                    throw new Exception("Valore non valido");
                _EAN = value;
            }
        }

        private DateTime _data;        
        public DateTime data
        {
            get { return _data; }

            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Valore non valido");
                _data = value;                     
            }
        }
        public OggettoCronologia(string ean, DateTime Data)
        {
            if (string.IsNullOrEmpty(ean))
                throw new Exception("Valore non valido");
            EAN = ean;
            data = Data;
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
