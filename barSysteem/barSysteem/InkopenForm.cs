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
    public partial class InkopenForm : Form
    {
        public InkopenForm()
        {
            InitializeComponent();
            InitializeSupplyDataGridView();
        }

        public void InitializeSupplyDataGridView()
        {
            DataTable table = new DataTable("Products");

            // First add columns
            table.Columns.Add("Naam", typeof(string));
            table.Columns.Add("Prijs PP", typeof(decimal));
            table.Columns.Add("Aantal", typeof(int));

            // Dit is puur om te testen. Deze informatie word later uit een database gehaald
            //Product a = new Product("Brood", 0, 5.99m);
            //Product b = new Product("Doos eieren (6 stuks)", 1, 6.99m);
            //Product c = new Product("Kaas", 2, 2.99m);
            //Product d = new Product("Appel", 3, 0.99m);
            //Product e = new Product("Bananen (3 stuks)", 4, 2.99m);
            //Product f = new Product("Amandelen (200g)", 5, 2.99m);

            //// Add rows
            //table.Rows.Add(a.displayName, a.price, a.id);
            //table.Rows.Add(b.displayName, b.price, b.id);
            //table.Rows.Add(c.displayName, c.price, c.id);
            //table.Rows.Add(d.displayName, d.price, d.id);
            //table.Rows.Add(e.displayName, e.price, e.id);
            //table.Rows.Add(f.displayName, f.price, f.id);

            //table.Rows.Add(a.displayName, a.price, a.id);
            //table.Rows.Add(b.displayName, b.price, b.id);
            //table.Rows.Add(c.displayName, c.price, c.id);
            //table.Rows.Add(d.displayName, d.price, d.id);
            //table.Rows.Add(e.displayName, e.price, e.id);
            //table.Rows.Add(f.displayName, f.price, f.id);
            //table.Rows.Add(a.displayName, a.price, a.id);
            //table.Rows.Add(b.displayName, b.price, b.id);
            //table.Rows.Add(c.displayName, c.price, c.id);
            //table.Rows.Add(d.displayName, d.price, d.id);
            //table.Rows.Add(e.displayName, e.price, e.id);
            //table.Rows.Add(f.displayName, f.price, f.id);
            //table.Rows.Add(a.displayName, a.price, a.id);
            //table.Rows.Add(b.displayName, b.price, b.id);
            //table.Rows.Add(c.displayName, c.price, c.id);
            //table.Rows.Add(d.displayName, d.price, d.id);
            //table.Rows.Add(e.displayName, e.price, e.id);
            //table.Rows.Add(f.displayName, f.price, f.id);

            dataGridView_voorraad.AllowUserToAddRows = false; // De gebruiker kan niet zomaar de voorraad aanpassen
            dataGridView_voorraad.AllowUserToDeleteRows = false;
            dataGridView_voorraad.DataSource = table;
        }
    }
}
