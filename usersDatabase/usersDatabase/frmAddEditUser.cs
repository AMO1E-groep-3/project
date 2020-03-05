using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TooSharp.Models;

namespace usersDatabase
{
    public partial class frmAddEditUser : Form
    {
        Account _Account = null;
        public frmAddEditUser()
        {
            InitializeComponent();
            lbTitle.Text = "Add User";
        }

        public frmAddEditUser(Account account)
        {
            InitializeComponent();
            btn1.Text = "Update";
            btn2.Visible = false;
            _Account = account;
            lbTitle.Text = "Update User";

            // validation
            _Account.onValidationError += Account_onValidationError;

            txtName.Text = _Account.Name;
            txtRol.Text = _Account.Rol;
            txtEmail.Text = _Account.Email;
            txtFreeDrink.Text = _Account.GratisDrank.ToString();
            txtBalance.Text = _Account.Saldo.ToString();
        }

        void ShowError(string Text)
        {
            lbError.Text = Text;
            pnlError.Visible = true;
            tmrError.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tmrError_Tick(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;
        }

        // add and update using toosharp
        private void btn1_Click(object sender, EventArgs e)
        {
            if (_Account == null)
            {

                // new account
                Account account = new Account()
                {
                    Name = txtName.Text,
                    Rol = txtRol.Text,
                    Email = txtEmail.Text,
                    GratisDrank = int.Parse(txtFreeDrink.Text),
                    Saldo = int.Parse(txtBalance.Text)
                };
                // validation
                account.onValidationError += Account_onValidationError;

                //save
                if (account.Save() > 0)
                {
                    MessageBox.Show("User Saved!");
                    this.Close();
                }
                

            }
            else
                {
                    // update account
                    _Account.Name = txtName.Text;
                    _Account.Rol = txtRol.Text;
                    _Account.Email = txtEmail.Text;
                    _Account.GratisDrank = int.Parse(txtFreeDrink.Text);
                    _Account.Saldo = int.Parse(txtBalance.Text);

                //  save account
                if (_Account.Save() > 0) MessageBox.Show("User Updated!");
                this.Close();
            };
        }

        private void Account_onValidationError(object sender, TooSharp.Core.TsExeptionArgs e)
        {
            ShowError(e.exception.Message);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
