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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fotoImage = new System.Windows.Forms.PictureBox();
            this.fileLocation = new System.Windows.Forms.Label();
            this.fotoInvoegen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorCheck = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDataView
            // 
            this.productsDataView.AllowUserToAddRows = false;
            this.productsDataView.AllowUserToDeleteRows = false;
            this.productsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foto,
            this.name,
            this.price,
            this.category,
            this.amount,
            this.remove});
            this.productsDataView.Location = new System.Drawing.Point(2, 64);
            this.productsDataView.Name = "productsDataView";
            this.productsDataView.ReadOnly = true;
            this.productsDataView.RowTemplate.Height = 65;
            this.productsDataView.Size = new System.Drawing.Size(455, 384);
            this.productsDataView.TabIndex = 0;
            this.productsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataView_CellContentClick);
            // 
            // artikelNaamLabel
            // 
            this.artikelNaamLabel.ForeColor = System.Drawing.Color.Gray;
            this.artikelNaamLabel.Location = new System.Drawing.Point(19, 102);
            this.artikelNaamLabel.Name = "artikelNaamLabel";
            this.artikelNaamLabel.Size = new System.Drawing.Size(190, 20);
            this.artikelNaamLabel.TabIndex = 1;
            this.artikelNaamLabel.Text = "voorbeeld: \'Aardappel\'";
            this.artikelNaamLabel.Enter += new System.EventHandler(this.artikelNaamLabel_Enter);
            this.artikelNaamLabel.Leave += new System.EventHandler(this.artikelNaamLabel_Leave);
            // 
            // prijsArtikelLabel
            // 
            this.prijsArtikelLabel.ForeColor = System.Drawing.Color.Gray;
            this.prijsArtikelLabel.Location = new System.Drawing.Point(19, 147);
            this.prijsArtikelLabel.Name = "prijsArtikelLabel";
            this.prijsArtikelLabel.Size = new System.Drawing.Size(190, 20);
            this.prijsArtikelLabel.TabIndex = 2;
            this.prijsArtikelLabel.Text = "voorbeeld: \'5.99\' moet met \'.\'";
            this.prijsArtikelLabel.Enter += new System.EventHandler(this.prijsArtikelLabel_Enter);
            this.prijsArtikelLabel.Leave += new System.EventHandler(this.prijsArtikelLabel_Leave);
            // 
            // aantalArtikelLabel
            // 
            this.aantalArtikelLabel.ForeColor = System.Drawing.Color.Gray;
            this.aantalArtikelLabel.Location = new System.Drawing.Point(19, 190);
            this.aantalArtikelLabel.Name = "aantalArtikelLabel";
            this.aantalArtikelLabel.Size = new System.Drawing.Size(190, 20);
            this.aantalArtikelLabel.TabIndex = 3;
            this.aantalArtikelLabel.Text = "voorbeeld: \'5\'";
            this.aantalArtikelLabel.Enter += new System.EventHandler(this.aantalArtikelLabel_Enter);
            this.aantalArtikelLabel.Leave += new System.EventHandler(this.aantalArtikelLabel_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artikelnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(17, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prijs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(17, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aantal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(16, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categorie";
            // 
            // categorieArtikelLabel
            // 
            this.categorieArtikelLabel.ForeColor = System.Drawing.Color.Gray;
            this.categorieArtikelLabel.Location = new System.Drawing.Point(19, 232);
            this.categorieArtikelLabel.Name = "categorieArtikelLabel";
            this.categorieArtikelLabel.Size = new System.Drawing.Size(190, 20);
            this.categorieArtikelLabel.TabIndex = 7;
            this.categorieArtikelLabel.Text = "voorbeeld: \'Groente\'";
            this.categorieArtikelLabel.Enter += new System.EventHandler(this.categorieArtikelLabel_Enter);
            this.categorieArtikelLabel.Leave += new System.EventHandler(this.categorieArtikelLabel_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product toevoegen";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.fotoImage);
            this.groupBox1.Controls.Add(this.fileLocation);
            this.groupBox1.Controls.Add(this.fotoInvoegen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.categorieArtikelLabel);
            this.groupBox1.Controls.Add(this.errorCheck);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.aantalArtikelLabel);
            this.groupBox1.Controls.Add(this.artikelNaamLabel);
            this.groupBox1.Controls.Add(this.prijsArtikelLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(460, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 390);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(-2, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 2);
            this.label14.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(-3, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 2);
            this.label13.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(-2, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(222, 2);
            this.label12.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(-2, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 2);
            this.label11.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(-3, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 2);
            this.label10.TabIndex = 19;
            // 
            // fotoImage
            // 
            this.fotoImage.Location = new System.Drawing.Point(20, 277);
            this.fotoImage.Name = "fotoImage";
            this.fotoImage.Size = new System.Drawing.Size(78, 59);
            this.fotoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoImage.TabIndex = 17;
            this.fotoImage.TabStop = false;
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(104, 283);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(103, 15);
            this.fileLocation.TabIndex = 16;
            this.fileLocation.Text = "no image found";
            // 
            // fotoInvoegen
            // 
            this.fotoInvoegen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fotoInvoegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotoInvoegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fotoInvoegen.Location = new System.Drawing.Point(107, 303);
            this.fotoInvoegen.Name = "fotoInvoegen";
            this.fotoInvoegen.Size = new System.Drawing.Size(59, 23);
            this.fotoInvoegen.TabIndex = 15;
            this.fotoInvoegen.Text = "Upload";
            this.fotoInvoegen.UseVisualStyleBackColor = false;
            this.fotoInvoegen.Click += new System.EventHandler(this.fotoInvoegen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(16, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Foto toevoegen";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-3, -4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 10);
            this.label6.TabIndex = 12;
            // 
            // errorCheck
            // 
            this.errorCheck.AutoSize = true;
            this.errorCheck.BackColor = System.Drawing.Color.Gainsboro;
            this.errorCheck.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorCheck.Location = new System.Drawing.Point(57, 54);
            this.errorCheck.Name = "errorCheck";
            this.errorCheck.Size = new System.Drawing.Size(104, 13);
            this.errorCheck.TabIndex = 1;
            this.errorCheck.Text = "niet alles is ingevuld!";
            this.errorCheck.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Toevoegen in Database";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(-3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 70);
            this.label9.TabIndex = 18;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(-7, -3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(697, 461);
            this.textBox1.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Picture Formats|*.png;*.jpg;*.jpeg;*.jfif|JPG Formats|*.jpg;*.jpeg;*.jfif|PNG" +
    " Formats|*.png";
            this.openFileDialog1.Title = "Voeg product toe";
            // 
            // foto
            // 
            this.foto.HeaderText = "foto";
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
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
            this.amount.ToolTipText = "De hoeveelheid van een product in database";
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
            this.Controls.Add(this.productsDataView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Name = "products";
            this.Text = "products";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoImage)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label errorCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button fotoInvoegen;
        private System.Windows.Forms.Label fileLocation;
        private System.Windows.Forms.PictureBox fotoImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewButtonColumn remove;
    }
}