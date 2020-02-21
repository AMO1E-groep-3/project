namespace barSysteem
{
    partial class InkopenForm
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
            this.dataGridView_bestellen = new System.Windows.Forms.DataGridView();
            this.label_bestellen = new System.Windows.Forms.Label();
            this.comboBox_voorraadSortering = new System.Windows.Forms.ComboBox();
            this.button_buyProducts = new System.Windows.Forms.Button();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.label_totalVariable = new System.Windows.Forms.Label();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.button_removeProduct = new System.Windows.Forms.Button();
            this.label_supply = new System.Windows.Forms.Label();
            this.label_sortBy = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.dataGridButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_voorraad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bestellen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_voorraad
            // 
            this.dataGridView_voorraad.AccessibleName = "voorraadGridView";
            this.dataGridView_voorraad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_voorraad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridButton});
            this.dataGridView_voorraad.Location = new System.Drawing.Point(349, 336);
            this.dataGridView_voorraad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView_voorraad.Name = "dataGridView_voorraad";
            this.dataGridView_voorraad.RowHeadersWidth = 102;
            this.dataGridView_voorraad.Size = new System.Drawing.Size(877, 906);
            this.dataGridView_voorraad.TabIndex = 0;
            // 
            // dataGridView_bestellen
            // 
            this.dataGridView_bestellen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bestellen.Location = new System.Drawing.Point(1848, 336);
            this.dataGridView_bestellen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView_bestellen.Name = "dataGridView_bestellen";
            this.dataGridView_bestellen.RowHeadersWidth = 102;
            this.dataGridView_bestellen.Size = new System.Drawing.Size(771, 446);
            this.dataGridView_bestellen.TabIndex = 1;
            // 
            // label_bestellen
            // 
            this.label_bestellen.AutoSize = true;
            this.label_bestellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_bestellen.Location = new System.Drawing.Point(1835, 100);
            this.label_bestellen.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_bestellen.Name = "label_bestellen";
            this.label_bestellen.Size = new System.Drawing.Size(183, 69);
            this.label_bestellen.TabIndex = 2;
            this.label_bestellen.Text = "Order";
            // 
            // comboBox_voorraadSortering
            // 
            this.comboBox_voorraadSortering.FormattingEnabled = true;
            this.comboBox_voorraadSortering.Items.AddRange(new object[] {
            "Amount",
            "Price",
            "Name (A-Z)",
            "Name (Z-A)",
            "Category"});
            this.comboBox_voorraadSortering.Location = new System.Drawing.Point(640, 248);
            this.comboBox_voorraadSortering.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox_voorraadSortering.Name = "comboBox_voorraadSortering";
            this.comboBox_voorraadSortering.Size = new System.Drawing.Size(580, 39);
            this.comboBox_voorraadSortering.TabIndex = 3;
            // 
            // button_buyProducts
            // 
            this.button_buyProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_buyProducts.Location = new System.Drawing.Point(2376, 796);
            this.button_buyProducts.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_buyProducts.Name = "button_buyProducts";
            this.button_buyProducts.Size = new System.Drawing.Size(243, 114);
            this.button_buyProducts.TabIndex = 4;
            this.button_buyProducts.Text = "Buy";
            this.button_buyProducts.UseVisualStyleBackColor = true;
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_totalPrice.Location = new System.Drawing.Point(1835, 818);
            this.label_totalPrice.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(163, 63);
            this.label_totalPrice.TabIndex = 5;
            this.label_totalPrice.Text = "Total:";
            // 
            // label_totalVariable
            // 
            this.label_totalVariable.AutoSize = true;
            this.label_totalVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_totalVariable.Location = new System.Drawing.Point(2051, 818);
            this.label_totalVariable.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_totalVariable.Name = "label_totalVariable";
            this.label_totalVariable.Size = new System.Drawing.Size(132, 63);
            this.label_totalVariable.TabIndex = 6;
            this.label_totalVariable.Text = "0.00";
            // 
            // button_addProduct
            // 
            this.button_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_addProduct.Location = new System.Drawing.Point(1848, 248);
            this.button_addProduct.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(243, 74);
            this.button_addProduct.TabIndex = 7;
            this.button_addProduct.Text = "Add";
            this.button_addProduct.UseVisualStyleBackColor = true;
            // 
            // button_removeProduct
            // 
            this.button_removeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_removeProduct.Location = new System.Drawing.Point(2139, 248);
            this.button_removeProduct.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_removeProduct.Name = "button_removeProduct";
            this.button_removeProduct.Size = new System.Drawing.Size(243, 74);
            this.button_removeProduct.TabIndex = 8;
            this.button_removeProduct.Text = "Remove";
            this.button_removeProduct.UseVisualStyleBackColor = true;
            // 
            // label_supply
            // 
            this.label_supply.AutoSize = true;
            this.label_supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_supply.Location = new System.Drawing.Point(336, 100);
            this.label_supply.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_supply.Name = "label_supply";
            this.label_supply.Size = new System.Drawing.Size(213, 69);
            this.label_supply.TabIndex = 9;
            this.label_supply.Text = "Supply";
            // 
            // label_sortBy
            // 
            this.label_sortBy.AutoSize = true;
            this.label_sortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_sortBy.Location = new System.Drawing.Point(339, 248);
            this.label_sortBy.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_sortBy.Name = "label_sortBy";
            this.label_sortBy.Size = new System.Drawing.Size(158, 46);
            this.label_sortBy.TabIndex = 10;
            this.label_sortBy.Text = "Sort by:";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(640, 186);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(580, 38);
            this.textBox_search.TabIndex = 11;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_search.Location = new System.Drawing.Point(339, 186);
            this.label_search.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(158, 46);
            this.label_search.TabIndex = 12;
            this.label_search.Text = "Search:";
            // 
            // dataGridButton
            // 
            this.dataGridButton.HeaderText = "button";
            this.dataGridButton.MinimumWidth = 12;
            this.dataGridButton.Name = "dataGridButton";
            this.dataGridButton.Width = 250;
            // 
            // InkopenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2949, 1433);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_sortBy);
            this.Controls.Add(this.label_supply);
            this.Controls.Add(this.button_removeProduct);
            this.Controls.Add(this.button_addProduct);
            this.Controls.Add(this.label_totalVariable);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.button_buyProducts);
            this.Controls.Add(this.comboBox_voorraadSortering);
            this.Controls.Add(this.label_bestellen);
            this.Controls.Add(this.dataGridView_bestellen);
            this.Controls.Add(this.dataGridView_voorraad);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "InkopenForm";
            this.Text = "InkopenForm";
            this.Load += new System.EventHandler(this.InkopenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_voorraad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bestellen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_voorraad;
        private System.Windows.Forms.DataGridView dataGridView_bestellen;
        private System.Windows.Forms.Label label_bestellen;
        private System.Windows.Forms.ComboBox comboBox_voorraadSortering;
        private System.Windows.Forms.Button button_buyProducts;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.Label label_totalVariable;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.Button button_removeProduct;
        private System.Windows.Forms.Label label_supply;
        private System.Windows.Forms.Label label_sortBy;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridButton;
    }
}