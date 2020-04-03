namespace barSysteem
{
    partial class ProductDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_naam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_aanpassen = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(361, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voorraad Aanpassen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(361, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "prijs:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label_naam
            // 
            this.label_naam.AutoSize = true;
            this.label_naam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_naam.Location = new System.Drawing.Point(468, 132);
            this.label_naam.Name = "label_naam";
            this.label_naam.Size = new System.Drawing.Size(61, 25);
            this.label_naam.TabIndex = 3;
            this.label_naam.Text = "name";
            this.label_naam.Click += new System.EventHandler(this.Label_naam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(361, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "aantal:";
            // 
            // button_aanpassen
            // 
            this.button_aanpassen.Location = new System.Drawing.Point(369, 228);
            this.button_aanpassen.Name = "button_aanpassen";
            this.button_aanpassen.Size = new System.Drawing.Size(320, 45);
            this.button_aanpassen.TabIndex = 7;
            this.button_aanpassen.Text = "Aanpassen";
            this.button_aanpassen.UseVisualStyleBackColor = true;
            this.button_aanpassen.Click += new System.EventHandler(this.Button_aanpassen_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(473, 162);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(186, 20);
            this.textBox_price.TabIndex = 9;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(473, 188);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(186, 20);
            this.textBox_amount.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(361, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "naam:";
            // 
            // ProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 636);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.button_aanpassen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_naam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductDetails";
            this.Text = "ProductDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_naam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_aanpassen;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label3;
    }
}