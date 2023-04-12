namespace Wypozyczalnia
{
    partial class EdytujSamochod
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ESCofnij = new System.Windows.Forms.Button();
            this.btn_ESEdytuj = new System.Windows.Forms.Button();
            this.num_ESkaucja = new System.Windows.Forms.NumericUpDown();
            this.cbx_ESrodzaj_skrzyni = new System.Windows.Forms.ComboBox();
            this.num_EScena_za_dzien = new System.Windows.Forms.NumericUpDown();
            this.txt_ESkolor = new System.Windows.Forms.TextBox();
            this.cbx_ESrodzaj_paliwa = new System.Windows.Forms.ComboBox();
            this.num_ESrok_produkcji = new System.Windows.Forms.NumericUpDown();
            this.txt_ESmodel = new System.Windows.Forms.TextBox();
            this.txt_ESmarka = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ESnumer_rej = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_ESkaucja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EScena_za_dzien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ESrok_produkcji)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Kaucja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Rodzaj skrzyni:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cena za dzien:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Kolor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Rodzaj paliwa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Rok produkcji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Marka:";
            // 
            // btn_ESCofnij
            // 
            this.btn_ESCofnij.Location = new System.Drawing.Point(205, 305);
            this.btn_ESCofnij.Name = "btn_ESCofnij";
            this.btn_ESCofnij.Size = new System.Drawing.Size(75, 23);
            this.btn_ESCofnij.TabIndex = 30;
            this.btn_ESCofnij.Text = "Cofnij";
            this.btn_ESCofnij.UseVisualStyleBackColor = true;
            this.btn_ESCofnij.Click += new System.EventHandler(this.btn_ESCofnij_Click);
            // 
            // btn_ESEdytuj
            // 
            this.btn_ESEdytuj.Location = new System.Drawing.Point(83, 305);
            this.btn_ESEdytuj.Name = "btn_ESEdytuj";
            this.btn_ESEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btn_ESEdytuj.TabIndex = 29;
            this.btn_ESEdytuj.Text = "Dodaj";
            this.btn_ESEdytuj.UseVisualStyleBackColor = true;
            this.btn_ESEdytuj.Click += new System.EventHandler(this.btn_ESEdytuj_Click);
            // 
            // num_ESkaucja
            // 
            this.num_ESkaucja.Location = new System.Drawing.Point(194, 262);
            this.num_ESkaucja.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.num_ESkaucja.Name = "num_ESkaucja";
            this.num_ESkaucja.Size = new System.Drawing.Size(120, 20);
            this.num_ESkaucja.TabIndex = 27;
            // 
            // cbx_ESrodzaj_skrzyni
            // 
            this.cbx_ESrodzaj_skrzyni.FormattingEnabled = true;
            this.cbx_ESrodzaj_skrzyni.Items.AddRange(new object[] {
            "Automatyczna ",
            "Manualna"});
            this.cbx_ESrodzaj_skrzyni.Location = new System.Drawing.Point(194, 235);
            this.cbx_ESrodzaj_skrzyni.Name = "cbx_ESrodzaj_skrzyni";
            this.cbx_ESrodzaj_skrzyni.Size = new System.Drawing.Size(121, 21);
            this.cbx_ESrodzaj_skrzyni.TabIndex = 26;
            // 
            // num_EScena_za_dzien
            // 
            this.num_EScena_za_dzien.Location = new System.Drawing.Point(194, 209);
            this.num_EScena_za_dzien.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.num_EScena_za_dzien.Name = "num_EScena_za_dzien";
            this.num_EScena_za_dzien.Size = new System.Drawing.Size(120, 20);
            this.num_EScena_za_dzien.TabIndex = 25;
            // 
            // txt_ESkolor
            // 
            this.txt_ESkolor.Location = new System.Drawing.Point(131, 174);
            this.txt_ESkolor.Name = "txt_ESkolor";
            this.txt_ESkolor.Size = new System.Drawing.Size(183, 20);
            this.txt_ESkolor.TabIndex = 24;
            // 
            // cbx_ESrodzaj_paliwa
            // 
            this.cbx_ESrodzaj_paliwa.FormattingEnabled = true;
            this.cbx_ESrodzaj_paliwa.Items.AddRange(new object[] {
            "Benzyna",
            "Diesel",
            "Benzyna + LPG",
            "Hybryda",
            "Elektryczne"});
            this.cbx_ESrodzaj_paliwa.Location = new System.Drawing.Point(193, 136);
            this.cbx_ESrodzaj_paliwa.Name = "cbx_ESrodzaj_paliwa";
            this.cbx_ESrodzaj_paliwa.Size = new System.Drawing.Size(121, 21);
            this.cbx_ESrodzaj_paliwa.TabIndex = 23;
            // 
            // num_ESrok_produkcji
            // 
            this.num_ESrok_produkcji.Location = new System.Drawing.Point(194, 110);
            this.num_ESrok_produkcji.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.num_ESrok_produkcji.Name = "num_ESrok_produkcji";
            this.num_ESrok_produkcji.Size = new System.Drawing.Size(120, 20);
            this.num_ESrok_produkcji.TabIndex = 22;
            // 
            // txt_ESmodel
            // 
            this.txt_ESmodel.Location = new System.Drawing.Point(131, 61);
            this.txt_ESmodel.Name = "txt_ESmodel";
            this.txt_ESmodel.Size = new System.Drawing.Size(183, 20);
            this.txt_ESmodel.TabIndex = 21;
            // 
            // txt_ESmarka
            // 
            this.txt_ESmarka.Location = new System.Drawing.Point(131, 35);
            this.txt_ESmarka.Name = "txt_ESmarka";
            this.txt_ESmarka.Size = new System.Drawing.Size(183, 20);
            this.txt_ESmarka.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Numer rej:";
            // 
            // txt_ESnumer_rej
            // 
            this.txt_ESnumer_rej.Location = new System.Drawing.Point(131, 87);
            this.txt_ESnumer_rej.Name = "txt_ESnumer_rej";
            this.txt_ESnumer_rej.Size = new System.Drawing.Size(183, 20);
            this.txt_ESnumer_rej.TabIndex = 41;
            // 
            // EdytujSamochod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 385);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_ESnumer_rej);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ESCofnij);
            this.Controls.Add(this.btn_ESEdytuj);
            this.Controls.Add(this.num_ESkaucja);
            this.Controls.Add(this.cbx_ESrodzaj_skrzyni);
            this.Controls.Add(this.num_EScena_za_dzien);
            this.Controls.Add(this.txt_ESkolor);
            this.Controls.Add(this.cbx_ESrodzaj_paliwa);
            this.Controls.Add(this.num_ESrok_produkcji);
            this.Controls.Add(this.txt_ESmodel);
            this.Controls.Add(this.txt_ESmarka);
            this.Name = "EdytujSamochod";
            this.Text = "EdytujSamochod";
            this.Load += new System.EventHandler(this.EdytujSamochod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_ESkaucja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EScena_za_dzien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ESrok_produkcji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ESCofnij;
        private System.Windows.Forms.Button btn_ESEdytuj;
        public System.Windows.Forms.TextBox txt_ESmarka;
        public System.Windows.Forms.NumericUpDown num_ESkaucja;
        public System.Windows.Forms.ComboBox cbx_ESrodzaj_skrzyni;
        public System.Windows.Forms.NumericUpDown num_EScena_za_dzien;
        public System.Windows.Forms.TextBox txt_ESkolor;
        public System.Windows.Forms.ComboBox cbx_ESrodzaj_paliwa;
        public System.Windows.Forms.NumericUpDown num_ESrok_produkcji;
        public System.Windows.Forms.TextBox txt_ESmodel;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_ESnumer_rej;
    }
}