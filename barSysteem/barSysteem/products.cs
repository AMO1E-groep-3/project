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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace barSysteem
{
    public partial class products : Form
    {
        public products()
        {
            
            InitializeComponent();



            //string urlAddress = "http://localhost/project/getDataBedrijfs.php"; // adres van php bestand

            //using (WebClient client = new WebClient()) // maak een webclient aan voor connectie
            //{
                
            //    //    // this string contains the webpage's source
            //    //string pageSource = client.DownloadString(urlAddress); // download de string van het opgegeven url

            //    ////Image.FromStream(pageSourceImg);
            //    ////Image image = Image.FromFile("D:/A_ROC/A_PROJECT/Leerjaar 1/Periode 3/Barsysteem/barSysteem/barSysteem/obj/Debug/img");
            //    //var objects = JArray.Parse(pageSource);
            //    //foreach (var item in objects)
            //    //{
            //    //    Product product = JsonConvert.DeserializeObject<Product>(item.ToString());
            //    //    Product imgSource = JsonConvert.DeserializeObject<Product>(item.ToString());
            //    //    productsDataView.Rows.Add(product.DisplayName, product.Price, product.Categorie, product.Amount, "X");
            //    //}

            //    string pageSource = client.DownloadString(urlAddress); // download de string van het opgegeven url

            //    //Image frikandelBroodje = Image.FromFile("D:/A_ROC/A_PROJECT/Leerjaar 1/Periode 3/Barsysteem/barSysteem/barSysteem/obj/Debug/img");
            //    //Image saucijzenBroodje = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
            //    //Image broodjeKroket = Image.FromFile("D:/a_all-pictures/Saved Pictures/external-content.duckduckgo.com.jfif");
            //    //Image twix = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
            //    //Image kitkat = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
            //    //Image chipsNaturel = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
            //    //Image chipsPaprika = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
            //    //Image blikCola = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
            //    //Image appelsap = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
            //    //Image waterfles = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
            //    var objects = JArray.Parse(pageSource);
            //    foreach (var item in objects)
            //    {
            //        Product product = JsonConvert.DeserializeObject<Product>(item.ToString());
            //        productsDataView.Rows.Add(product.DisplayName, product.Price, product.Categorie, product.Amount, "X");
            //    }
            //}
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string urlAddress = "http://localhost/project/getDataBedrijfs.php"; // adres van php bestand
            productsDataView.Rows.Clear();
            using (WebClient client = new WebClient()) // maak een webclient aan voor connectie
            {
                // this string contains the webpage's source
                string pageSource = client.DownloadString(urlAddress); // download de string van het opgegeven url

                Image frikandelBroodje = Image.FromFile("D:/Program Files/XAMPP/htdocs/project/img/frikandelbroodje.jfif");
                //Image saucijzenBroodje = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
                //Image broodjeKroket = Image.FromFile("D:/a_all-pictures/Saved Pictures/external-content.duckduckgo.com.jfif");
                //Image twix = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
                //Image kitkat = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
                //Image chipsNaturel = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
                //Image chipsPaprika = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
                //Image blikCola = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
                //Image appelsap = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
                //Image waterfles = Image.FromFile("./obj/Debug/img/external-content.duckduckgo.com");
                var objects = JArray.Parse(pageSource);
                foreach (var item in objects)
                {
                    Product product = JsonConvert.DeserializeObject<Product>(item.ToString());
                    productsDataView.Rows.Add(frikandelBroodje, product.Name, product.Price, product.Category, product.Aantal, "X");
                }

        }
    }

    private void productsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (artikelNaamLabel.Text == "voorbeeld: 'Aardappel'" || prijsArtikelLabel.Text == "voorbeeld: '5.99' moet met '.'" || aantalArtikelLabel.Text == "voorbeeld: '5'" || categorieArtikelLabel.Text == "voorbeeld: 'Groente'" || artikelNaamLabel.ForeColor == Color.Gray)
        {
            errorCheck.Visible = true;
        }
        else
        {
            errorCheck.Visible = false;
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

    private void artikelNaamLabel_Enter(object sender, EventArgs e)
    {
        if (artikelNaamLabel.Text == "voorbeeld: 'Aardappel'")
        {
            artikelNaamLabel.Text = "";

            artikelNaamLabel.ForeColor = Color.Black;
        }
    }

    private void artikelNaamLabel_Leave(object sender, EventArgs e)
    {
        if (artikelNaamLabel.Text == "")
        {
            artikelNaamLabel.Text = "voorbeeld: 'Aardappel'";

            artikelNaamLabel.ForeColor = Color.Gray;
        }
    }

    private void prijsArtikelLabel_Enter(object sender, EventArgs e)
    {
        if (prijsArtikelLabel.Text == "voorbeeld: '5.99' moet met '.'")
        {
            prijsArtikelLabel.Text = "";

            prijsArtikelLabel.ForeColor = Color.Black;
        }
    }

    private void prijsArtikelLabel_Leave(object sender, EventArgs e)
    {
        if (prijsArtikelLabel.Text == "")
        {
            prijsArtikelLabel.Text = "voorbeeld: '5.99' moet met '.'";

            prijsArtikelLabel.ForeColor = Color.Gray;
        }
    }

    private void aantalArtikelLabel_Enter(object sender, EventArgs e)
    {
        if (aantalArtikelLabel.Text == "voorbeeld: '5'")
        {
            aantalArtikelLabel.Text = "";

            aantalArtikelLabel.ForeColor = Color.Black;
        }
    }

    private void aantalArtikelLabel_Leave(object sender, EventArgs e)
    {
        if (aantalArtikelLabel.Text == "")
        {
            aantalArtikelLabel.Text = "voorbeeld: '5'";

            aantalArtikelLabel.ForeColor = Color.Gray;
        }
    }

    private void categorieArtikelLabel_Enter(object sender, EventArgs e)
    {
        if (categorieArtikelLabel.Text == "voorbeeld: 'Groente'")
        {
            categorieArtikelLabel.Text = "";

            categorieArtikelLabel.ForeColor = Color.Black;
        }
    }

    private void categorieArtikelLabel_Leave(object sender, EventArgs e)
    {
        if (categorieArtikelLabel.Text == "")
        {
            categorieArtikelLabel.Text = "voorbeeld: 'Groente'";

            categorieArtikelLabel.ForeColor = Color.Gray;
        }
    }

    private void fotoInvoegen_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileLocation.Text = openFileDialog1.SafeFileName;
                fotoImage.Image = new Bitmap(openFileDialog1.FileName);
            }
            else
            {
                Image foto = Image.FromFile("./obj/Debug/img/image-unavailable.png");
                fotoImage.Image = foto;
            }
        }
        else
        {
            Image foto = Image.FromFile("D:/A_ROC/A_PROJECT/Leerjaar 1/Periode 3/Barsysteem (new)/barSysteem/barSysteem/obj/Debug/img/image-unavailable.png");
            fotoImage.Image = foto;
        }
    }
}
}
