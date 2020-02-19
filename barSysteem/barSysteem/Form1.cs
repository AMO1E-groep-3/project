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
        public mainForm()
        {
            InitializeComponent();
            account.AccountChanging += Account_AccountChanging;
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
    }
}
