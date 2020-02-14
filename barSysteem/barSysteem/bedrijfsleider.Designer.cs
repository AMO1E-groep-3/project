namespace barSysteem
{
    partial class bedrijfsleider
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bestelButton = new System.Windows.Forms.Button();
            this.unknownButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voorraad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bananen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.prijs,
            this.voorraad});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // bestelButton
            // 
            this.bestelButton.Location = new System.Drawing.Point(195, 526);
            this.bestelButton.Name = "bestelButton";
            this.bestelButton.Size = new System.Drawing.Size(144, 42);
            this.bestelButton.TabIndex = 10;
            this.bestelButton.Text = "Add Product";
            this.bestelButton.UseVisualStyleBackColor = true;
            // 
            // unknownButton
            // 
            this.unknownButton.Location = new System.Drawing.Point(28, 526);
            this.unknownButton.Name = "unknownButton";
            this.unknownButton.Size = new System.Drawing.Size(144, 42);
            this.unknownButton.TabIndex = 11;
            this.unknownButton.Text = "Delete Product";
            this.unknownButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bananen,
            this.email,
            this.saldo,
            this.rol});
            this.dataGridView2.Location = new System.Drawing.Point(534, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 440);
            this.dataGridView2.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(833, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add User";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 42);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete User";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "naam product";
            this.Column1.Name = "Column1";
            // 
            // prijs
            // 
            this.prijs.HeaderText = "prijs";
            this.prijs.Name = "prijs";
            // 
            // voorraad
            // 
            this.voorraad.HeaderText = "voorraad";
            this.voorraad.Name = "voorraad";
            // 
            // bananen
            // 
            this.bananen.HeaderText = "Name User";
            this.bananen.Name = "bananen";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // saldo
            // 
            this.saldo.HeaderText = "saldo";
            this.saldo.Name = "saldo";
            // 
            // rol
            // 
            this.rol.HeaderText = "rol";
            this.rol.Name = "rol";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Penningmeester";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(800, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 42);
            this.button4.TabIndex = 20;
            this.button4.Text = "Inkopen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bedrijfsleider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 582);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.unknownButton);
            this.Controls.Add(this.bestelButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "bedrijfsleider";
            this.Text = "bedrijfsleider";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bestelButton;
        private System.Windows.Forms.Button unknownButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prijs;
        private System.Windows.Forms.DataGridViewTextBoxColumn voorraad;
        private System.Windows.Forms.DataGridViewTextBoxColumn bananen;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}