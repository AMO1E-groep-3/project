using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace barSysteem
{
    public class Account
    {
        public delegate void AccountChangingEvent(object sender, AccountChangingEventArgs e);
        public event AccountChangingEvent AccountChanging;
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("freedrinks")]
        public byte freeDrinks { get; set; }
        [JsonProperty("saldo")]
        public decimal saldo { get; set; }
        [JsonProperty("role")]
        public string role { get; set; }

        public void AccountChange(int id)
        {
            //api to set every var with a value

            string url = "http://biko.famschouten.com/project/checkId.php?id=" + id+"";

            string API_URL = url;

            WebClient client = new WebClient();
            string json = client.DownloadString(API_URL);
            try
            {
                var objects = JRaw.Parse(json);
                Account newAccount = JsonConvert.DeserializeObject<Account>(objects.ToString());
                this.id = newAccount.id;
                this.name = newAccount.name;
                this.freeDrinks = newAccount.freeDrinks;
                this.saldo = newAccount.saldo;
                this.role = newAccount.role;

                AccountChangingEventArgs eventArgs3 = new AccountChangingEventArgs()
                {

                };
                if (AccountChanging != null)
                {
                    AccountChanging(this, eventArgs3);
                }
                if (!eventArgs3.Handled)
                {

                }

            }
            catch 
            {

                throw;
            }
            



        }




    }
    public class AccountChangingEventArgs : EventArgs {
        public bool Handled { get; set; }

       
    }
}
