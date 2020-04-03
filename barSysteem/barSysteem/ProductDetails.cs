using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barSysteem
{
    public partial class ProductDetails : Form
    {
        private Form1 inkopenForm;
        Product product;
        int rowIndex;


        public ProductDetails(Form1 inkopenForm, Product product, int rowIndex)
        {
            InitializeComponent();
            this.product = product;
            this.inkopenForm = inkopenForm;
            this.rowIndex = rowIndex;

            label_naam.Text = product.Name.ToString();
            textBox_price.Text = product.Price.ToString();
            textBox_amount.Text = product.Aantal.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button_aanpassen_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(textBox_price.Text, out decimal price))
                product.Price = price;
            if (int.TryParse(textBox_amount.Text, out int amount))
                product.Aantal = amount;

            inkopenForm.UpdateProductInDataGridView(product, rowIndex);
            this.Close();
        }

        private void Label_naam_Click(object sender, EventArgs e)
        {

        }
    }
}
