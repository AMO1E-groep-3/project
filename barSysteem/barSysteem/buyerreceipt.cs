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
    public partial class buyerreceipt : Form
    {
        public buyerreceipt()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            string productname = textBox1.Text;
            string number = textBox2.Text;
            string totalprice = textBox3.Text;
            string urlAdress = "http://localhost/project/buyerreceipts.php?products=" + productname + "&number=" + number + "&totalprice=" + totalprice;

            using (WebClient client = new WebClient())
            {
                string downloadedString = client.DownloadString(urlAdress);
            }

            this.Close();
        }
    }
}
