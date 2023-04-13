namespace Wypozyczalnia
{
    partial class Logowanie
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
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_haslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_zaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(101, 94);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(221, 20);
            this.txt_login.TabIndex = 0;
            // 
            // txt_haslo
            // 
            this.txt_haslo.Location = new System.Drawing.Point(101, 133);
            this.txt_haslo.Name = "txt_haslo";
            this.txt_haslo.PasswordChar = '*';
            this.txt_haslo.Size = new System.Drawing.Size(221, 20);
            this.txt_haslo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGOWANIE";
            // 
            // btn_zaloguj
            // 
            this.btn_zaloguj.Location = new System.Drawing.Point(247, 168);
            this.btn_zaloguj.Name = "btn_zaloguj";
            this.btn_zaloguj.Size = new System.Drawing.Size(75, 23);
            this.btn_zaloguj.TabIndex = 5;
            this.btn_zaloguj.Text = "Zaloguj";
            this.btn_zaloguj.UseVisualStyleBackColor = true;
            this.btn_zaloguj.Click += new System.EventHandler(this.btn_zaloguj_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 219);
            this.Controls.Add(this.btn_zaloguj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_haslo);
            this.Controls.Add(this.txt_login);
            this.Name = "Logowanie";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_haslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_zaloguj;
    }
}