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
        public int Id { get; set; }
        [JsonProperty("producten")]
        public string Products { get; set; }
        [JsonProperty("totalPrice")]
        public decimal Price { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        
    }
}
