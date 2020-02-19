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
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("gratisDrank")]
        public byte FreeDrinks { get; set; }
        [JsonProperty("saldo")]
        public decimal Saldo { get; set; }
        [JsonProperty("rol")]
        public string Role { get; set; }


        public void AccountChange(int id)
        {
            //api to set every var with a value
                
            string url = "http://127.0.0.1/project/checkId.php?id=" + id +"";

            string API_URL = url;

            WebClient client = new WebClient();
            string json = client.DownloadString(API_URL);
            try
            {
                var objects = JRaw.Parse(json);
                Account newAccount = JsonConvert.DeserializeObject<Account>(objects.ToString());
                this.Id = newAccount.Id;
                this.Name = newAccount.Name;
                this.FreeDrinks = newAccount.FreeDrinks;
                this.Saldo = newAccount.Saldo;
                this.Role = newAccount.Role;

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
