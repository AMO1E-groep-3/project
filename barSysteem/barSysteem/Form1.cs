using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class mainForm : Form
    {
        Account account = new Account();
        Product p;


        public mainForm()
        {
            InitializeComponent();
            account.AccountChanging += Account_AccountChanging;
            p = new Product();
            

        }
        private void Account_AccountChanging(object sender, AccountChangingEventArgs e)
        {
            nameLabel.Text = account.Name;
            saldoLabel.Text = account.Saldo.ToString();
            rolLabel.Text = account.Role;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectGategoryPanel.Visible = true;
            sodaPanel.Visible = false;
            alcoholicPanel.Visible = false;
            juicesPanel.Visible = false;
            snacksPanel.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selectGategoryPanel.Visible = false;
            sodaPanel.Visible = true;
            alcoholicPanel.Visible = false;
            juicesPanel.Visible = false;
            snacksPanel.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectGategoryPanel.Visible = false;
            sodaPanel.Visible = false;
            alcoholicPanel.Visible = true;
            juicesPanel.Visible = false;
            snacksPanel.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectGategoryPanel.Visible = false;
            sodaPanel.Visible = false;
            alcoholicPanel.Visible = false;
            juicesPanel.Visible = true;
            snacksPanel.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectGategoryPanel.Visible = false;
            sodaPanel.Visible = false;
            alcoholicPanel.Visible = false;
            juicesPanel.Visible = false;
            snacksPanel.Visible = true;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LoginScreen form = new LoginScreen(account);
            form.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            if (account.Role == "Admin")
            {
                bedrijfsleider form = new bedrijfsleider();
                form.Show();                
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void ItemListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = itemListDataGridView.CurrentCell.RowIndex;
            itemListDataGridView.Rows.Remove(itemListDataGridView.Rows[index]);
        }

        private void SelectGategoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button39_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 1);
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 2);
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 3);
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 4);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 5);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 6);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 7);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 8);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 9);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 10);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 11);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 12);
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 13);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 14);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 15);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            p.getProduct(itemListDataGridView, 16);
        }
    }
}
