using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barSysteem
{
    public partial class PenningMeesterForm : Form
    {
        public PenningMeesterForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            dataGridView2.Rows.Clear();
            int i = 0;
            string API_URL = "http://127.0.0.1/project/getReceipt.php";

            WebClient client = new WebClient();
            string json = client.DownloadString(API_URL);

                var objects = JArray.Parse(json); // parse as array  
                foreach (var item in objects)
                {

                    Receipt product = JsonConvert.DeserializeObject<Receipt>(item.ToString());
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells[0].Value = product.Products.ToString();
                    dataGridView2.Rows[i].Cells[1].Value = product.Price.ToString();
                    dataGridView2.Rows[i].Cells[2].Value = product.Date.ToString();
                    dataGridView2.Rows[i].Cells[3].Value = "Remove";
                    i++;
                }

                

        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.Remove(dataGridView2.Rows[index]);
        }
    }
}
