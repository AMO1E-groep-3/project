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
    public partial class bedrijfsleider : Form
    {
        DataTable table = new DataTable("Products");
        public bedrijfsleider()
        {
            InitializeComponent();

            /*
             * Wanneer de form bedrijfsleider geopend is, komt er automatisch informatie te staan van wat de 
             * properties van de kolommen moeten zijn.
             * 
             * Dit word later automatisch gedaan doormiddel van een database.
             */
            table.Columns.Add("Naam", typeof(string));
            table.Columns.Add("Prijs", typeof(double));
            table.Columns.Add("Aantal", typeof(int));
            //productenDataGridView.DataSource = table;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PenningMeesterForm form = new PenningMeesterForm();
            form.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InkopenForm form = new InkopenForm();
            form.Show();
        }

        private void bestelButton_Click(object sender, EventArgs e)
        {
            /* als de gebruiker klikt op een knop word er informatie gehaald vanuit de database
             * en die informatie word veranderd naar rows met producten
            */
            
            //table.Rows.Add("Aardappels", 5.99, 20);
            //productenDataGridView.DataSource = table;

            //table.Rows.Add(a.displayName, a.price, a.id);
            //productenGrid.Rows.Add();
        }

        private void unknownButton_Click(object sender, EventArgs e)
        {
        }
    }
}
