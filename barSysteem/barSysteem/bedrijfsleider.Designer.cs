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
            this.productSettingsButton = new System.Windows.Forms.Button();
            this.PenningmeesterButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inkoperButton
            // 
            this.inkoperButton.Location = new System.Drawing.Point(0, 0);
            this.inkoperButton.Name = "inkoperButton";
            this.inkoperButton.Size = new System.Drawing.Size(75, 23);
            this.inkoperButton.TabIndex = 0;
            // 
            // usersSettingsButton
            // 
            this.usersSettingsButton.BackColor = System.Drawing.Color.Tomato;
            this.usersSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersSettingsButton.Location = new System.Drawing.Point(19, 40);
            this.usersSettingsButton.Name = "usersSettingsButton";
            this.usersSettingsButton.Size = new System.Drawing.Size(134, 42);
            this.usersSettingsButton.TabIndex = 19;
            this.usersSettingsButton.Text = "Users Settings";
            this.usersSettingsButton.UseVisualStyleBackColor = false;
            this.usersSettingsButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.PenningmeesterButton);
            this.groupBox2.Controls.Add(this.usersSettingsButton);
            this.groupBox2.Controls.Add(this.productSettingsButton);
            this.groupBox2.Location = new System.Drawing.Point(74, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(328, 217);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Screens";
            // 
            // productSettingsButton
            // 
            this.productSettingsButton.BackColor = System.Drawing.Color.Tomato;
            this.productSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productSettingsButton.Location = new System.Drawing.Point(172, 40);
            this.productSettingsButton.Name = "productSettingsButton";
            this.productSettingsButton.Size = new System.Drawing.Size(134, 42);
            this.productSettingsButton.TabIndex = 20;
            this.productSettingsButton.Text = "Products Settings";
            this.productSettingsButton.UseVisualStyleBackColor = false;
            this.productSettingsButton.Click += new System.EventHandler(this.productSettingsButton_Click);
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
            // 
            // bedrijfsleider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 390);
            this.Controls.Add(this.groupBox2);
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