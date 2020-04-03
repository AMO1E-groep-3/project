namespace barSysteem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_voorraad = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox_voorraadSortering = new System.Windows.Forms.ComboBox();
            this.label_supply = new System.Windows.Forms.Label();
            this.label_sortBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_voorraad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_voorraad
            // 
            this.dataGridView_voorraad.AccessibleName = "voorraadGridView";
            this.dataGridView_voorraad.AllowUserToAddRows = false;
            this.dataGridView_voorraad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_voorraad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_voorraad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.amount,
            this.edit,
            this.delete});
            this.dataGridView_voorraad.Location = new System.Drawing.Point(131, 141);
            this.dataGridView_voorraad.Name = "dataGridView_voorraad";
            this.dataGridView_voorraad.Size = new System.Drawing.Size(847, 425);
            this.dataGridView_voorraad.TabIndex = 0;
            this.dataGridView_voorraad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_voorraad_CellClick);
            this.dataGridView_voorraad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_voorraad_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Naam";
            this.name.Name = "name";
            // 
            // price
            // 
            this.price.HeaderText = "Prijs PP";
            this.price.Name = "price";
            // 
            // amount
            // 
            this.amount.HeaderText = "Aantal";
            this.amount.Name = "amount";
            // 
            // edit
            // 
            this.edit.HeaderText = "Aanpassen";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.edit.Text = "Aanpassen";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "Verwijderen";
            this.delete.Name = "delete";
            this.delete.Text = "Verwijderen";
            this.delete.ToolTipText = "Verwijderen";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // comboBox_voorraadSortering
            // 
            this.comboBox_voorraadSortering.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_voorraadSortering.FormattingEnabled = true;
            this.comboBox_voorraadSortering.Items.AddRange(new object[] {
            "Amount",
            "Price",
            "Name (A-Z)",
            "Name (Z-A)",
            "Category"});
            this.comboBox_voorraadSortering.Location = new System.Drawing.Point(225, 106);
            this.comboBox_voorraadSortering.Name = "comboBox_voorraadSortering";
            this.comboBox_voorraadSortering.Size = new System.Drawing.Size(220, 21);
            this.comboBox_voorraadSortering.TabIndex = 3;
            // 
            // label_supply
            // 
            this.label_supply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_supply.AutoSize = true;
            this.label_supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_supply.Location = new System.Drawing.Point(126, 42);
            this.label_supply.Name = "label_supply";
            this.label_supply.Size = new System.Drawing.Size(112, 29);
            this.label_supply.TabIndex = 9;
            this.label_supply.Text = "Voorraad";
            // 
            // label_sortBy
            // 
            this.label_sortBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_sortBy.AutoSize = true;
            this.label_sortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_sortBy.Location = new System.Drawing.Point(127, 104);
            this.label_sortBy.Name = "label_sortBy";
            this.label_sortBy.Size = new System.Drawing.Size(75, 20);
            this.label_sortBy.TabIndex = 10;
            this.label_sortBy.Text = "Sorteren:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(695, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zoeken:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(765, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // InkopenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 601);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_sortBy);
            this.Controls.Add(this.label_supply);
            this.Controls.Add(this.comboBox_voorraadSortering);
            this.Controls.Add(this.dataGridView_voorraad);
            this.Name = "InkopenForm";
            this.Text = "InkopenForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_voorraad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_voorraad;
        private System.Windows.Forms.ComboBox comboBox_voorraadSortering;
        private System.Windows.Forms.Label label_supply;
        private System.Windows.Forms.Label label_sortBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label label2;
    }
}