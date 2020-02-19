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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_voorraad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bestellen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_voorraad
            // 
            this.dataGridView_voorraad.AccessibleName = "voorraadGridView";
            this.dataGridView_voorraad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_voorraad.Location = new System.Drawing.Point(131, 141);
            this.dataGridView_voorraad.Name = "dataGridView_voorraad";
            this.dataGridView_voorraad.Size = new System.Drawing.Size(329, 380);
            this.dataGridView_voorraad.TabIndex = 0;
            // 
            // dataGridView_bestellen
            // 
            this.dataGridView_bestellen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bestellen.Location = new System.Drawing.Point(693, 141);
            this.dataGridView_bestellen.Name = "dataGridView_bestellen";
            this.dataGridView_bestellen.Size = new System.Drawing.Size(289, 187);
            this.dataGridView_bestellen.TabIndex = 1;
            // 
            // label_bestellen
            // 
            this.label_bestellen.AutoSize = true;
            this.label_bestellen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_bestellen.Location = new System.Drawing.Point(688, 42);
            this.label_bestellen.Name = "label_bestellen";
            this.label_bestellen.Size = new System.Drawing.Size(76, 29);
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
            this.comboBox_voorraadSortering.Location = new System.Drawing.Point(240, 104);
            this.comboBox_voorraadSortering.Name = "comboBox_voorraadSortering";
            this.comboBox_voorraadSortering.Size = new System.Drawing.Size(220, 21);
            this.comboBox_voorraadSortering.TabIndex = 3;
            // 
            // button_buyProducts
            // 
            this.button_buyProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_buyProducts.Location = new System.Drawing.Point(891, 334);
            this.button_buyProducts.Name = "button_buyProducts";
            this.button_buyProducts.Size = new System.Drawing.Size(91, 48);
            this.button_buyProducts.TabIndex = 4;
            this.button_buyProducts.Text = "Buy";
            this.button_buyProducts.UseVisualStyleBackColor = true;
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_totalPrice.Location = new System.Drawing.Point(688, 343);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(65, 26);
            this.label_totalPrice.TabIndex = 5;
            this.label_totalPrice.Text = "Total:";
            // 
            // label_totalVariable
            // 
            this.label_totalVariable.AutoSize = true;
            this.label_totalVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_totalVariable.Location = new System.Drawing.Point(769, 343);
            this.label_totalVariable.Name = "label_totalVariable";
            this.label_totalVariable.Size = new System.Drawing.Size(54, 26);
            this.label_totalVariable.TabIndex = 6;
            this.label_totalVariable.Text = "0.00";
            // 
            // button_addProduct
            // 
            this.button_addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_addProduct.Location = new System.Drawing.Point(693, 104);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(91, 31);
            this.button_addProduct.TabIndex = 7;
            this.button_addProduct.Text = "Add";
            this.button_addProduct.UseVisualStyleBackColor = true;
            // 
            // button_removeProduct
            // 
            this.button_removeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_removeProduct.Location = new System.Drawing.Point(802, 104);
            this.button_removeProduct.Name = "button_removeProduct";
            this.button_removeProduct.Size = new System.Drawing.Size(91, 31);
            this.button_removeProduct.TabIndex = 8;
            this.button_removeProduct.Text = "Remove";
            this.button_removeProduct.UseVisualStyleBackColor = true;
            // 
            // label_supply
            // 
            this.label_supply.AutoSize = true;
            this.label_supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_supply.Location = new System.Drawing.Point(126, 42);
            this.label_supply.Name = "label_supply";
            this.label_supply.Size = new System.Drawing.Size(87, 29);
            this.label_supply.TabIndex = 9;
            this.label_supply.Text = "Supply";
            // 
            // label_sortBy
            // 
            this.label_sortBy.AutoSize = true;
            this.label_sortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_sortBy.Location = new System.Drawing.Point(127, 104);
            this.label_sortBy.Name = "label_sortBy";
            this.label_sortBy.Size = new System.Drawing.Size(63, 20);
            this.label_sortBy.TabIndex = 10;
            this.label_sortBy.Text = "Sort by:";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(240, 78);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(220, 20);
            this.textBox_search.TabIndex = 11;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_search.Location = new System.Drawing.Point(127, 78);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(64, 20);
            this.label_search.TabIndex = 12;
            this.label_search.Text = "Search:";
            // 
            // InkopenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 601);
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
            this.Name = "InkopenForm";
            this.Text = "InkopenForm";
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
    }
}