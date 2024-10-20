using System;
using System.Collections.Generic;
using System.Text;

namespace ebebdeneme.Models
{
    public class Sil
    {
        public Sil(string name, string fiyat, string aralik, string url)
        {
            Id = name;
            Name = name;
            Fiyat = fiyat;
            Aralik = aralik;
            Url = url;

        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Fiyat { get; set; }
        public string Aralik { get; set; }

    }
}
