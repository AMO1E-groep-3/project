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
            this.productenDataGridView = new System.Windows.Forms.DataGridView();
            this.bestelButton = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bananen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productenDataGridView
            // 
            this.productenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productenDataGridView.Location = new System.Drawing.Point(12, 12);
            this.productenDataGridView.Name = "productenDataGridView";
            this.productenDataGridView.RowHeadersWidth = 102;
            this.productenDataGridView.Size = new System.Drawing.Size(345, 499);
            this.productenDataGridView.TabIndex = 0;
            // 
            // bestelButton
            // 
            this.bestelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bestelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bestelButton.Location = new System.Drawing.Point(195, 526);
            this.bestelButton.Name = "bestelButton";
            this.bestelButton.Size = new System.Drawing.Size(144, 42);
            this.bestelButton.TabIndex = 10;
            this.bestelButton.Text = "Add Product";
            this.bestelButton.UseVisualStyleBackColor = true;
            this.bestelButton.Click += new System.EventHandler(this.bestelButton_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProduct.Location = new System.Drawing.Point(28, 526);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(144, 42);
            this.deleteProduct.TabIndex = 11;
            this.deleteProduct.Text = "Delete Product";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.unknownButton_Click);
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
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.Size = new System.Drawing.Size(442, 440);
            this.dataGridView2.TabIndex = 16;
            // 
            // bananen
            // 
            this.bananen.HeaderText = "Name User";
            this.bananen.MinimumWidth = 12;
            this.bananen.Name = "bananen";
            this.bananen.Width = 250;
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 12;
            this.email.Name = "email";
            this.email.Width = 250;
            // 
            // saldo
            // 
            this.saldo.HeaderText = "saldo";
            this.saldo.MinimumWidth = 12;
            this.saldo.Name = "saldo";
            this.saldo.Width = 250;
            // 
            // rol
            // 
            this.rol.HeaderText = "rol";
            this.rol.MinimumWidth = 12;
            this.rol.Name = "rol";
            this.rol.Width = 250;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(833, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add User";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(545, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 42);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete User";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Penningmeester";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(14, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 42);
            this.button4.TabIndex = 20;
            this.button4.Text = "Inkopen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(363, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 160);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Schermen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bedrijfsleider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.bestelButton);
            this.Controls.Add(this.productenDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "bedrijfsleider";
            this.Text = "bedrijfsleider";
            ((System.ComponentModel.ISupportInitialize)(this.productenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productenDataGridView;
        private System.Windows.Forms.Button bestelButton;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bananen;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}