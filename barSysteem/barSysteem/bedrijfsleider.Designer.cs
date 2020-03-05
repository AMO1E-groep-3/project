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
            this.inkoperButton = new System.Windows.Forms.Button();
            this.usersSettingsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PenningmeesterButton = new System.Windows.Forms.Button();
            this.productSettingsButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inkoperButton
            // 
            this.inkoperButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(151)))), ((int)(((byte)(77)))));
            this.inkoperButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inkoperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inkoperButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inkoperButton.Location = new System.Drawing.Point(236, 153);
            this.inkoperButton.Margin = new System.Windows.Forms.Padding(4);
            this.inkoperButton.Name = "inkoperButton";
            this.inkoperButton.Size = new System.Drawing.Size(179, 52);
            this.inkoperButton.TabIndex = 20;
            this.inkoperButton.Text = "Inkoper";
            this.inkoperButton.UseVisualStyleBackColor = false;
            this.inkoperButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // usersSettingsButton
            // 
            this.usersSettingsButton.BackColor = System.Drawing.Color.Tomato;
            this.usersSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersSettingsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usersSettingsButton.Location = new System.Drawing.Point(25, 49);
            this.usersSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.usersSettingsButton.Name = "usersSettingsButton";
            this.usersSettingsButton.Size = new System.Drawing.Size(179, 52);
            this.usersSettingsButton.TabIndex = 19;
            this.usersSettingsButton.Text = "Users Settings";
            this.usersSettingsButton.UseVisualStyleBackColor = false;
            this.usersSettingsButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.productSettingsButton);
            this.groupBox2.Controls.Add(this.PenningmeesterButton);
            this.groupBox2.Controls.Add(this.usersSettingsButton);
            this.groupBox2.Controls.Add(this.inkoperButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(96, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 256);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Screens";
            // 
            // PenningmeesterButton
            // 
            this.PenningmeesterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(151)))), ((int)(((byte)(77)))));
            this.PenningmeesterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PenningmeesterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenningmeesterButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PenningmeesterButton.Location = new System.Drawing.Point(25, 153);
            this.PenningmeesterButton.Name = "PenningmeesterButton";
            this.PenningmeesterButton.Size = new System.Drawing.Size(179, 52);
            this.PenningmeesterButton.TabIndex = 21;
            this.PenningmeesterButton.Text = "Penningmeester";
            this.PenningmeesterButton.UseVisualStyleBackColor = false;
            this.PenningmeesterButton.Click += new System.EventHandler(this.PenningmeesterButton_Click);
            // 
            // productSettingsButton
            // 
            this.productSettingsButton.BackColor = System.Drawing.Color.Tomato;
            this.productSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productSettingsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.productSettingsButton.Location = new System.Drawing.Point(236, 49);
            this.productSettingsButton.Name = "productSettingsButton";
            this.productSettingsButton.Size = new System.Drawing.Size(179, 52);
            this.productSettingsButton.TabIndex = 22;
            this.productSettingsButton.Text = "Products Settings";
            this.productSettingsButton.UseVisualStyleBackColor = false;
            this.productSettingsButton.Click += new System.EventHandler(this.productSettingsButton_Click);
            // 
            // bedrijfsleider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(151)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(646, 444);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bedrijfsleider";
            this.Text = "bedrijfsleider";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button inkoperButton;
        private System.Windows.Forms.Button usersSettingsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PenningmeesterButton;
        private System.Windows.Forms.Button productSettingsButton;
    }
}