using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace barSysteem
{
    /// <summary>
    /// Form1 is actually InkopenForm
    /// </summary>
    public partial class Form1 : Form
    {
        // Temporary:
        private List<Product> products;


        public Form1()
        {
            InitializeComponent();
            
            products = new List<Product>();

            // Add mock products
            GetProductsFromDB();
        }

        private void DataGridView_voorraad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView_voorraad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int editColumn = 3;
            int removeColumn = 4;

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            if (row == null)
                return;


            if (e.ColumnIndex == editColumn)
            {
                ProductDetails form = new ProductDetails(this, products[e.RowIndex], e.RowIndex);
                form.Show();
            }
            else if(e.ColumnIndex == removeColumn)
            {
                if(products[e.RowIndex].Aantal > 0)
                    products[e.RowIndex].Aantal--;
            }
        }

        /// <summary>
        /// Get products from DB using getSupply.php
        /// </summary>
        private void GetProductsFromDB()
        {
            string urlAddress = "http://localhost/project/getSupply.php";

            using (WebClient client = new WebClient())
            {
                string pageSource = client.DownloadString(urlAddress);
                var objects = JArray.Parse(pageSource);

                dataGridView_voorraad.Rows.Clear();

                foreach (var item in objects)
                {
                    Product product = JsonConvert.DeserializeObject<Product>(item.ToString());
                    products.Add(product);
                    dataGridView_voorraad.Rows.Add(product.Name, product.Price, product.Aantal);
                }               
            }
        }

        public void UpdateProductInDataGridView(Product updatedProduct, int rowIndex)
        {
            DataGridViewRow row = dataGridView_voorraad.Rows[rowIndex];
            
            row.Cells[0].Value = updatedProduct.Name;
            row.Cells[1].Value = updatedProduct.Price;
            row.Cells[2].Value = updatedProduct.Aantal;
        }

        public void UpdateProductsInDB()
        {
            string urlAddress = "http://localhost/project/updateSupply.php";


            using (WebClient client = new WebClient())
            {
                string pageSource = client.DownloadString(urlAddress);
                var objects = JArray.Parse(pageSource);

                dataGridView_voorraad.Rows.Clear();

                foreach (var item in objects)
                {
                    Product product = JsonConvert.DeserializeObject<Product>(item.ToString());
                    products.Add(product);
                    dataGridView_voorraad.Rows.Add(product.Name, product.Price, product.Aantal);
                }
            }
        }
    }
}
