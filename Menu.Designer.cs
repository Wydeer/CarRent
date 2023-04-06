namespace Wypozyczalnia
{
    partial class Menu
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
            this.btn_Samochody = new System.Windows.Forms.Button();
            this.btn_Klienci = new System.Windows.Forms.Button();
            this.btn_Ubezpieczenie = new System.Windows.Forms.Button();
            this.btn_Wypożyczenie = new System.Windows.Forms.Button();
            this.btn_Rezerwacje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Samochody
            // 
            this.btn_Samochody.Location = new System.Drawing.Point(140, 84);
            this.btn_Samochody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Samochody.Name = "btn_Samochody";
            this.btn_Samochody.Size = new System.Drawing.Size(80, 19);
            this.btn_Samochody.TabIndex = 0;
            this.btn_Samochody.Text = "Samochody";
            this.btn_Samochody.UseVisualStyleBackColor = true;
            this.btn_Samochody.Click += new System.EventHandler(this.btn_Samochody_Click);
            // 
            // btn_Klienci
            // 
            this.btn_Klienci.Location = new System.Drawing.Point(308, 83);
            this.btn_Klienci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Klienci.Name = "btn_Klienci";
            this.btn_Klienci.Size = new System.Drawing.Size(56, 19);
            this.btn_Klienci.TabIndex = 1;
            this.btn_Klienci.Text = "Klienci";
            this.btn_Klienci.UseVisualStyleBackColor = true;
            this.btn_Klienci.Click += new System.EventHandler(this.btn_Klienci_Click);
            // 
            // btn_Ubezpieczenie
            // 
            this.btn_Ubezpieczenie.Location = new System.Drawing.Point(158, 167);
            this.btn_Ubezpieczenie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ubezpieczenie.Name = "btn_Ubezpieczenie";
            this.btn_Ubezpieczenie.Size = new System.Drawing.Size(106, 19);
            this.btn_Ubezpieczenie.TabIndex = 2;
            this.btn_Ubezpieczenie.Text = "Ubezpieczenie";
            this.btn_Ubezpieczenie.UseVisualStyleBackColor = true;
            this.btn_Ubezpieczenie.Click += new System.EventHandler(this.btn_Ubezpieczenie_Click);
            // 
            // btn_Wypożyczenie
            // 
            this.btn_Wypożyczenie.Location = new System.Drawing.Point(320, 167);
            this.btn_Wypożyczenie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Wypożyczenie.Name = "btn_Wypożyczenie";
            this.btn_Wypożyczenie.Size = new System.Drawing.Size(89, 19);
            this.btn_Wypożyczenie.TabIndex = 3;
            this.btn_Wypożyczenie.Text = "Wypożyczenia";
            this.btn_Wypożyczenie.UseVisualStyleBackColor = true;
            // 
            // btn_Rezerwacje
            // 
            this.btn_Rezerwacje.Location = new System.Drawing.Point(228, 227);
            this.btn_Rezerwacje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Rezerwacje.Name = "btn_Rezerwacje";
            this.btn_Rezerwacje.Size = new System.Drawing.Size(86, 19);
            this.btn_Rezerwacje.TabIndex = 4;
            this.btn_Rezerwacje.Text = "Rezerwacje";
            this.btn_Rezerwacje.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Rezerwacje);
            this.Controls.Add(this.btn_Wypożyczenie);
            this.Controls.Add(this.btn_Ubezpieczenie);
            this.Controls.Add(this.btn_Klienci);
            this.Controls.Add(this.btn_Samochody);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Samochody;
        private System.Windows.Forms.Button btn_Klienci;
        private System.Windows.Forms.Button btn_Ubezpieczenie;
        private System.Windows.Forms.Button btn_Wypożyczenie;
        private System.Windows.Forms.Button btn_Rezerwacje;
    }
}