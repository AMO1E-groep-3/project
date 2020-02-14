using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace barSysteem
{
    class Receipt
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("products")]
        public string products { get; set; }
        [JsonProperty("totalPrice")]
        public decimal price { get; set; }
        [JsonProperty("date")]
        public DateTime date { get; set; }

        
    }
}
