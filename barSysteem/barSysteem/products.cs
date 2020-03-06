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

namespace barSysteem
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void artikelNaamLabel_Click(object sender, EventArgs e)
        {
            if (artikelNaamLabel.Text == "voorbeeld: 'Aardappel'")
            {
                artikelNaamLabel.Text = "";
                
            }
        }

        private void prijsArtikelLabel_Click(object sender, EventArgs e)
        {
            if (prijsArtikelLabel.Text == "voorbeeld: '5.99' moet met '.'")
            {
                prijsArtikelLabel.Text = "";
            }
        }

        private void aantalArtikelLabel_Click(object sender, EventArgs e)
        {
            if (aantalArtikelLabel.Text == "voorbeeld: '5'")
            {
                aantalArtikelLabel.Text = "";
            }
        }

        private void categorieArtikelLabel_Click(object sender, EventArgs e)
        {
            if (categorieArtikelLabel.Text == "voorbeeld: 'Groente'")
            {
                categorieArtikelLabel.Text = "";
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            productsDataView.Rows.Add();
            for (int i = 0; i < productsDataView.Rows.Count; i++)
            {
                productsDataView.Rows[i].Cells[0].Value = "Aardappel";
                productsDataView.Rows[i].Cells[1].Value = 1.50;
                productsDataView.Rows[i].Cells[2].Value = "Groente";
                productsDataView.Rows[i].Cells[3].Value = 10;
                productsDataView.Rows[i].Cells[4].Value = "X";
            }
        }

        private void productsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = productsDataView.CurrentCell.RowIndex;
            productsDataView.Rows.Remove(productsDataView.Rows[index]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = artikelNaamLabel.Text;
            string prijs = prijsArtikelLabel.Text;
            string aantal = aantalArtikelLabel.Text;
            string categorie = categorieArtikelLabel.Text;

            string urlAddress = "http://localhost/project/addProductBedrijfsleider.php?name=" + name + "&prijs=" + prijs + "&aantal=" + aantal + "&categorie=" + categorie; // adres van php bestand

            using (WebClient client = new WebClient()) // maak een webclient aan voor connectie
            {
                // this string contains the webpage's source
                string pageSource = client.DownloadString(urlAddress); // download de string van het opgegeven url
            }
        }
    }
}
