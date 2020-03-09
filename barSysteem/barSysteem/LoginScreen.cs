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
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if(int.TryParse(textBox1.Text, out int result))
            //    {
            //        if(account.AccountChange(result))
            //        {
            //            return;
            //        }
            //        else
            //        {   
            //            DisplayError("Niet bestaand account");
            //            result = default;
            //            textBox1.Clear();
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        DisplayError("Er is geen geldige waarde ingevoerd: " + textBox1.Text);
            //        textBox1.Clear();

            //        return;
            //    }
            //}
        }

        public void DisplayError(string errorText)
        {
            label2.Text = errorText;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                if (int.TryParse(textBox1.Text, out int result))
                {
                    if (account.AccountChange(result))
                    {
                        return;
                    }
                    else
                    {
                        DisplayError("Niet bestaand account");
                        result = default;
                        textBox1.Clear();
                        return;
                    }
                }
                else
                {
                    DisplayError("Er is geen geldige waarde ingevoerd: " + textBox1.Text);
                    textBox1.Clear();

                    return;
                }
        }
    }
}
