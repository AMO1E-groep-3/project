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
    public partial class LoginScreen : Form
    {
        Account account;
        public LoginScreen(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                account.AccountChange(int.Parse(textBox1.Text));
                this.Close();
            }
        }
    }
}
