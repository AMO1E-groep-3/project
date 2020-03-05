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
    public partial class FormUsersList : Form
    {
        public FormUsersList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmAddEditUser().ShowDialog();
            ReloadData();
        }

        void ReloadData()
        {
            if(txtSearch.Text.Trim().Length>0)
            {
                // search Data
                populatedData(Accounts.Records()
                    .Where(Accounts.COLUMNS.email, "LIKE", "%" + txtSearch.Text + "%")
                    .Get());
            }
            else
            {
                // fetch all Data
               populatedData(Accounts.Records().Get());
            }
        }

        void populatedData(IEnumerable<Account> accounts)
        {
            table.Rows.Clear();
            foreach (var c in accounts)
            {
                table.Rows.Add(new object[] { 
                    c.Id,
                    c.Name,
                    c.Rol,
                    c.Email,
                    c.GratisDrank,
                    c.Saldo,
                    "Edit",
                    "Delete"
                });
                table.Rows[table.RowCount - 1].Tag = c;
            }
        }

        private void FormUsersList_Shown(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            ReloadData();
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6) // edit
            {
                new frmAddEditUser((Account)table.CurrentRow.Tag).ShowDialog();
                ReloadData();
            }
            if (e.ColumnIndex == 7) // delete
            {
                Account account = (Account)table.CurrentRow.Tag;
                if(MessageBox.Show("Delete " + account.Name + "?", "Confirm", MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    account.Delete();
                    ReloadData();
                }
            }
        }
    }
}
