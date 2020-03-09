namespace usersDatabase
{
    partial class frmAddEditUser
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
            this.components = new System.ComponentModel.Container();
            this.pnlheader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlError = new System.Windows.Forms.Panel();
            this.lbError = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.txtFreeDrink = new System.Windows.Forms.TextBox();
            this.lbDrank = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.lbRol = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrError = new System.Windows.Forms.Timer(this.components);
            this.btn2 = new System.Windows.Forms.Button();
            this.pnlheader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(151)))), ((int)(((byte)(77)))));
            this.pnlheader.Controls.Add(this.lbTitle);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(539, 70);
            this.pnlheader.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Location = new System.Drawing.Point(26, 16);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(84, 38);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "{title}";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlError);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.lbBalance);
            this.panel1.Controls.Add(this.txtFreeDrink);
            this.panel1.Controls.Add(this.lbDrank);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.txtRol);
            this.panel1.Controls.Add(this.lbRol);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 453);
            this.panel1.TabIndex = 2;
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.White;
            this.pnlError.Controls.Add(this.lbError);
            this.pnlError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlError.Location = new System.Drawing.Point(0, 0);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(468, 35);
            this.pnlError.TabIndex = 12;
            // 
            // lbError
            // 
            this.lbError.BackColor = System.Drawing.Color.Tomato;
            this.lbError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Black;
            this.lbError.Location = new System.Drawing.Point(0, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(468, 35);
            this.lbError.TabIndex = 13;
            this.lbError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbError.Visible = false;
            this.lbError.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(151)))), ((int)(((byte)(77)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(26, 407);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(125, 32);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Save";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(26, 364);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(407, 22);
            this.txtBalance.TabIndex = 9;
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(26, 340);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(59, 17);
            this.lbBalance.TabIndex = 8;
            this.lbBalance.Text = "Balance";
            // 
            // txtFreeDrink
            // 
            this.txtFreeDrink.Location = new System.Drawing.Point(26, 291);
            this.txtFreeDrink.Name = "txtFreeDrink";
            this.txtFreeDrink.Size = new System.Drawing.Size(407, 22);
            this.txtFreeDrink.TabIndex = 7;
            // 
            // lbDrank
            // 
            this.lbDrank.AutoSize = true;
            this.lbDrank.Location = new System.Drawing.Point(26, 267);
            this.lbDrank.Name = "lbDrank";
            this.lbDrank.Size = new System.Drawing.Size(81, 17);
            this.lbDrank.TabIndex = 6;
            this.lbDrank.Text = "Free Drinks";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(407, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(26, 194);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(26, 145);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(407, 22);
            this.txtRol.TabIndex = 3;
            // 
            // lbRol
            // 
            this.lbRol.AutoSize = true;
            this.lbRol.Location = new System.Drawing.Point(26, 121);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(37, 17);
            this.lbRol.TabIndex = 2;
            this.lbRol.Text = "Role";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(26, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(407, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tmrError
            // 
            this.tmrError.Interval = 2000;
            this.tmrError.Tick += new System.EventHandler(this.tmrError_Tick);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Tomato;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(157, 407);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(125, 32);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "Delete";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(539, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User";
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlError.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.TextBox txtFreeDrink;
        private System.Windows.Forms.Label lbDrank;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Timer tmrError;
        private System.Windows.Forms.Button btn2;
    }
}