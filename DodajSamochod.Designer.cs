namespace Wypozyczalnia
{
    partial class DodajSamochod
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
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.num_rok_produkcji = new System.Windows.Forms.NumericUpDown();
            this.cbx_rodzaj_paliwa = new System.Windows.Forms.ComboBox();
            this.txt_kolor = new System.Windows.Forms.TextBox();
            this.num_cena_za_dzien = new System.Windows.Forms.NumericUpDown();
            this.cbx_rodzaj_skrzyni = new System.Windows.Forms.ComboBox();
            this.num_kaucja = new System.Windows.Forms.NumericUpDown();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.btn_DSDodaj = new System.Windows.Forms.Button();
            this.btn_DSCofnij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Numer = new System.Windows.Forms.Label();
            this.txt_numer_rej = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_rok_produkcji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cena_za_dzien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_kaucja)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(146, 45);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(183, 20);
            this.txt_marka.TabIndex = 0;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(146, 71);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(183, 20);
            this.txt_model.TabIndex = 1;
            // 
            // num_rok_produkcji
            // 
            this.num_rok_produkcji.Location = new System.Drawing.Point(209, 131);
            this.num_rok_produkcji.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.num_rok_produkcji.Name = "num_rok_produkcji";
            this.num_rok_produkcji.Size = new System.Drawing.Size(120, 20);
            this.num_rok_produkcji.TabIndex = 2;
            // 
            // cbx_rodzaj_paliwa
            // 
            this.cbx_rodzaj_paliwa.FormattingEnabled = true;
            this.cbx_rodzaj_paliwa.Items.AddRange(new object[] {
            "Benzyna",
            "Diesel",
            "Benzyna + LPG",
            "Hybryda",
            "Elektryczne"});
            this.cbx_rodzaj_paliwa.Location = new System.Drawing.Point(208, 157);
            this.cbx_rodzaj_paliwa.Name = "cbx_rodzaj_paliwa";
            this.cbx_rodzaj_paliwa.Size = new System.Drawing.Size(121, 21);
            this.cbx_rodzaj_paliwa.TabIndex = 3;
            // 
            // txt_kolor
            // 
            this.txt_kolor.Location = new System.Drawing.Point(146, 195);
            this.txt_kolor.Name = "txt_kolor";
            this.txt_kolor.Size = new System.Drawing.Size(183, 20);
            this.txt_kolor.TabIndex = 4;
            // 
            // num_cena_za_dzien
            // 
            this.num_cena_za_dzien.Location = new System.Drawing.Point(209, 230);
            this.num_cena_za_dzien.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.num_cena_za_dzien.Name = "num_cena_za_dzien";
            this.num_cena_za_dzien.Size = new System.Drawing.Size(120, 20);
            this.num_cena_za_dzien.TabIndex = 5;
            // 
            // cbx_rodzaj_skrzyni
            // 
            this.cbx_rodzaj_skrzyni.FormattingEnabled = true;
            this.cbx_rodzaj_skrzyni.Items.AddRange(new object[] {
            "Automatyczna ",
            "Manualna"});
            this.cbx_rodzaj_skrzyni.Location = new System.Drawing.Point(209, 256);
            this.cbx_rodzaj_skrzyni.Name = "cbx_rodzaj_skrzyni";
            this.cbx_rodzaj_skrzyni.Size = new System.Drawing.Size(121, 21);
            this.cbx_rodzaj_skrzyni.TabIndex = 6;
            // 
            // num_kaucja
            // 
            this.num_kaucja.Location = new System.Drawing.Point(209, 283);
            this.num_kaucja.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.num_kaucja.Name = "num_kaucja";
            this.num_kaucja.Size = new System.Drawing.Size(120, 20);
            this.num_kaucja.TabIndex = 7;
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "Dostępny",
            "Niedostępny"});
            this.cbx_status.Location = new System.Drawing.Point(209, 309);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(121, 21);
            this.cbx_status.TabIndex = 8;
            // 
            // btn_DSDodaj
            // 
            this.btn_DSDodaj.Location = new System.Drawing.Point(146, 372);
            this.btn_DSDodaj.Name = "btn_DSDodaj";
            this.btn_DSDodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_DSDodaj.TabIndex = 9;
            this.btn_DSDodaj.Text = "Dodaj";
            this.btn_DSDodaj.UseVisualStyleBackColor = true;
            this.btn_DSDodaj.Click += new System.EventHandler(this.btn_DSDodaj_Click);
            // 
            // btn_DSCofnij
            // 
            this.btn_DSCofnij.Location = new System.Drawing.Point(255, 372);
            this.btn_DSCofnij.Name = "btn_DSCofnij";
            this.btn_DSCofnij.Size = new System.Drawing.Size(75, 23);
            this.btn_DSCofnij.TabIndex = 10;
            this.btn_DSCofnij.Text = "Cofnij";
            this.btn_DSCofnij.UseVisualStyleBackColor = true;
            this.btn_DSCofnij.Click += new System.EventHandler(this.btn_DSCofnij_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rok produkcji:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rodzaj paliwa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kolor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cena za dzien:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rodzaj skrzyni:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Kaucja:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Status:";
            // 
            // Numer
            // 
            this.Numer.AutoSize = true;
            this.Numer.Location = new System.Drawing.Point(79, 100);
            this.Numer.Name = "Numer";
            this.Numer.Size = new System.Drawing.Size(55, 13);
            this.Numer.TabIndex = 21;
            this.Numer.Text = "Numer rej:";
            // 
            // txt_numer_rej
            // 
            this.txt_numer_rej.Location = new System.Drawing.Point(146, 97);
            this.txt_numer_rej.Name = "txt_numer_rej";
            this.txt_numer_rej.Size = new System.Drawing.Size(183, 20);
            this.txt_numer_rej.TabIndex = 20;
            // 
            // DodajSamochod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.Numer);
            this.Controls.Add(this.txt_numer_rej);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DSCofnij);
            this.Controls.Add(this.btn_DSDodaj);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.num_kaucja);
            this.Controls.Add(this.cbx_rodzaj_skrzyni);
            this.Controls.Add(this.num_cena_za_dzien);
            this.Controls.Add(this.txt_kolor);
            this.Controls.Add(this.cbx_rodzaj_paliwa);
            this.Controls.Add(this.num_rok_produkcji);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_marka);
            this.Name = "DodajSamochod";
            this.Text = "DodajSamochod";
            ((System.ComponentModel.ISupportInitialize)(this.num_rok_produkcji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cena_za_dzien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_kaucja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.NumericUpDown num_rok_produkcji;
        private System.Windows.Forms.ComboBox cbx_rodzaj_paliwa;
        private System.Windows.Forms.TextBox txt_kolor;
        private System.Windows.Forms.NumericUpDown num_cena_za_dzien;
        private System.Windows.Forms.ComboBox cbx_rodzaj_skrzyni;
        private System.Windows.Forms.NumericUpDown num_kaucja;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.Button btn_DSDodaj;
        private System.Windows.Forms.Button btn_DSCofnij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Numer;
        private System.Windows.Forms.TextBox txt_numer_rej;
    }
}