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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.usersSettingsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productSettingsButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "Penningmeester";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(230, 152);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 52);
            this.button4.TabIndex = 20;
            this.button4.Text = "Inkoper";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // usersSettingsButton
            // 
            this.usersSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersSettingsButton.Location = new System.Drawing.Point(25, 49);
            this.usersSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.usersSettingsButton.Name = "usersSettingsButton";
            this.usersSettingsButton.Size = new System.Drawing.Size(179, 52);
            this.usersSettingsButton.TabIndex = 19;
            this.usersSettingsButton.Text = "Users Settings";
            this.usersSettingsButton.UseVisualStyleBackColor = true;
            this.usersSettingsButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usersSettingsButton);
            this.groupBox2.Controls.Add(this.productSettingsButton);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(98, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 267);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Screens";
            // 
            // productSettingsButton
            // 
            this.productSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productSettingsButton.Location = new System.Drawing.Point(230, 49);
            this.productSettingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.productSettingsButton.Name = "productSettingsButton";
            this.productSettingsButton.Size = new System.Drawing.Size(179, 52);
            this.productSettingsButton.TabIndex = 20;
            this.productSettingsButton.Text = "Products Settings";
            this.productSettingsButton.UseVisualStyleBackColor = true;
            this.productSettingsButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // bedrijfsleider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 480);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "bedrijfsleider";
            this.Text = "bedrijfsleider";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button usersSettingsButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button productSettingsButton;
    }
}