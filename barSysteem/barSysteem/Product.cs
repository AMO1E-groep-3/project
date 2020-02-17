using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barSysteem
{
    /// <summary>
    /// Alle benodigde variabelen om een type product te beschrijven
    /// </summary>
    [Serializable]
    public class Product
    {
        //public string displayName; // De naam die in de dataGridView word vermeld
        //public int id; // Identifier
        //public decimal price; // Prijs per product

        //public Product(string displayName, int id, decimal price)
        //{
        //    this.displayName = displayName;
        //    this.id = id;
        //    this.price = price; 
        //}
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }

    }
}
