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
        public bedrijfsleider()
        {
            InitializeComponent();
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
    }
}
