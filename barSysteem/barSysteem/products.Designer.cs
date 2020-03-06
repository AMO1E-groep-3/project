namespace barSysteem
{
    partial class products
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
            this.productsDataView = new System.Windows.Forms.DataGridView();
            this.artikelNaamLabel = new System.Windows.Forms.TextBox();
            this.prijsArtikelLabel = new System.Windows.Forms.TextBox();
            this.aantalArtikelLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categorieArtikelLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsDataView
            // 
            this.productsDataView.AllowUserToAddRows = false;
            this.productsDataView.AllowUserToDeleteRows = false;
            this.productsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.category,
            this.amount,
            this.remove});
            this.productsDataView.Location = new System.Drawing.Point(2, 64);
            this.productsDataView.Name = "productsDataView";
            this.productsDataView.ReadOnly = true;
            this.productsDataView.Size = new System.Drawing.Size(455, 384);
            this.productsDataView.TabIndex = 0;
            this.productsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataView_CellContentClick);
            // 
            // artikelNaamLabel
            // 
            this.artikelNaamLabel.Location = new System.Drawing.Point(478, 259);
            this.artikelNaamLabel.Name = "artikelNaamLabel";
            this.artikelNaamLabel.Size = new System.Drawing.Size(190, 20);
            this.artikelNaamLabel.TabIndex = 1;
            this.artikelNaamLabel.Text = "voorbeeld: \'Aardappel\'";
            this.artikelNaamLabel.Click += new System.EventHandler(this.artikelNaamLabel_Click);
            // 
            // prijsArtikelLabel
            // 
            this.prijsArtikelLabel.Location = new System.Drawing.Point(478, 304);
            this.prijsArtikelLabel.Name = "prijsArtikelLabel";
            this.prijsArtikelLabel.Size = new System.Drawing.Size(190, 20);
            this.prijsArtikelLabel.TabIndex = 2;
            this.prijsArtikelLabel.Text = "voorbeeld: \'5.99\' moet met \'.\'";
            this.prijsArtikelLabel.Click += new System.EventHandler(this.prijsArtikelLabel_Click);
            // 
            // aantalArtikelLabel
            // 
            this.aantalArtikelLabel.Location = new System.Drawing.Point(478, 347);
            this.aantalArtikelLabel.Name = "aantalArtikelLabel";
            this.aantalArtikelLabel.Size = new System.Drawing.Size(190, 20);
            this.aantalArtikelLabel.TabIndex = 3;
            this.aantalArtikelLabel.Text = "voorbeeld: \'5\'";
            this.aantalArtikelLabel.Click += new System.EventHandler(this.aantalArtikelLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(475, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artikelnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(476, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prijs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(476, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aantal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(475, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categorie";
            // 
            // categorieArtikelLabel
            // 
            this.categorieArtikelLabel.Location = new System.Drawing.Point(478, 389);
            this.categorieArtikelLabel.Name = "categorieArtikelLabel";
            this.categorieArtikelLabel.Size = new System.Drawing.Size(190, 20);
            this.categorieArtikelLabel.TabIndex = 7;
            this.categorieArtikelLabel.Text = "voorbeeld: \'Groente\'";
            this.categorieArtikelLabel.Click += new System.EventHandler(this.categorieArtikelLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product toevoegen";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(460, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 271);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(461, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 10);
            this.label6.TabIndex = 12;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(649, -15);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(41, 45);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "⟳";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Producten in database";
            // 
            // name
            // 
            this.name.HeaderText = "naam";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.ToolTipText = "Alle namen in de database";
            // 
            // price
            // 
            this.price.HeaderText = "prijs";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.ToolTipText = "Prijzen van producten in database";
            // 
            // category
            // 
            this.category.HeaderText = "categorie";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.category.ToolTipText = "Categoriën van producten in database";
            // 
            // amount
            // 
            this.amount.HeaderText = "aantal";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.amount.ToolTipText = "Aantal producten van database";
            this.amount.Width = 45;
            // 
            // remove
            // 
            this.remove.HeaderText = "verwijder";
            this.remove.Name = "remove";
            this.remove.ReadOnly = true;
            this.remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.remove.ToolTipText = "Klik op de knop van het product, in de juiste rij, om het te verwijderen";
            this.remove.Width = 66;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categorieArtikelLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aantalArtikelLabel);
            this.Controls.Add(this.prijsArtikelLabel);
            this.Controls.Add(this.artikelNaamLabel);
            this.Controls.Add(this.productsDataView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label7);
            this.Name = "products";
            this.Text = "products";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataView;
        private System.Windows.Forms.TextBox artikelNaamLabel;
        private System.Windows.Forms.TextBox prijsArtikelLabel;
        private System.Windows.Forms.TextBox aantalArtikelLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox categorieArtikelLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
    }
}