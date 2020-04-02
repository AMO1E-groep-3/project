using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace barSysteem
{
    /// <summary>
    /// Alle benodigde variabelen om een type product te beschrijven
    /// </summary>
    [Serializable]
    public class Product
    {
        public delegate void getProductEvent(object sender, getProductEvent e);
        public event getProductEvent fetchingProduct;
        // Dit is een comment om commiten te testen

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
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("aantal")]
        public decimal Aantal { get; set; }

        public void getProduct(DataGridView gridView, int id)
        {
            if (id > 0)
            {
                //api to set every var with a value
                string url = "http://127.0.0.1/project/getProduct.php?id=" + id;

                string API_URL = url;

                using (WebClient client = new WebClient())
                {
                    string pageSource = client.DownloadString(url);
                    Console.WriteLine("pagesource:" + pageSource);

                    var objects = JArray.Parse(pageSource);
                    foreach (var obj in objects)
                    {
                        Product product = JsonConvert.DeserializeObject<Product>(obj.ToString());
                        gridView.Rows.Add(product.Id, product.Name, product.Price, product.Category, product.Aantal);
                    }
                }
            }
            else
            {
                Console.WriteLine("product kan niet worden toegevoegd");
            }
        }
        public class getProductEventArgs : EventArgs
        {
            public bool Handled { get; set; }


        }

    }
}

