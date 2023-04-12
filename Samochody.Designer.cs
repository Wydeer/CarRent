namespace Wypozyczalnia
{
    partial class Samochody
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
            this.dgv_samochody = new System.Windows.Forms.DataGridView();
            this.idsamochoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerrejDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokprodukcjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajpaliwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenazadzienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajskrzyniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaucjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.samochodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczalniaDataSet = new Wypozyczalnia.WypozyczalniaDataSet();
            this.btn_SDodaj = new System.Windows.Forms.Button();
            this.btn_SUsun = new System.Windows.Forms.Button();
            this.btn_SModyfikuj = new System.Windows.Forms.Button();
            this.btn_specyfikacja = new System.Windows.Forms.Button();
            this.samochodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samochodTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.SamochodTableAdapter();
            this.fKSpecyfikaidsa52593CB8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specyfikacjeSamochodowTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.SpecyfikacjeSamochodowTableAdapter();
            this.wypozyczalniaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_samochody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSpecyfikaidsa52593CB8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_samochody
            // 
            this.dgv_samochody.AllowUserToAddRows = false;
            this.dgv_samochody.AllowUserToDeleteRows = false;
            this.dgv_samochody.AllowUserToResizeColumns = false;
            this.dgv_samochody.AllowUserToResizeRows = false;
            this.dgv_samochody.AutoGenerateColumns = false;
            this.dgv_samochody.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_samochody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_samochody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsamochoduDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.numerrejDataGridViewTextBoxColumn,
            this.rokprodukcjiDataGridViewTextBoxColumn,
            this.rodzajpaliwaDataGridViewTextBoxColumn,
            this.kolorDataGridViewTextBoxColumn,
            this.cenazadzienDataGridViewTextBoxColumn,
            this.rodzajskrzyniDataGridViewTextBoxColumn,
            this.kaucjaDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgv_samochody.DataSource = this.samochodBindingSource1;
            this.dgv_samochody.Location = new System.Drawing.Point(12, 12);
            this.dgv_samochody.Name = "dgv_samochody";
            this.dgv_samochody.ReadOnly = true;
            this.dgv_samochody.Size = new System.Drawing.Size(776, 426);
            this.dgv_samochody.TabIndex = 0;
            // 
            // idsamochoduDataGridViewTextBoxColumn
            // 
            this.idsamochoduDataGridViewTextBoxColumn.DataPropertyName = "id_samochodu";
            this.idsamochoduDataGridViewTextBoxColumn.HeaderText = "id_samochodu";
            this.idsamochoduDataGridViewTextBoxColumn.Name = "idsamochoduDataGridViewTextBoxColumn";
            this.idsamochoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsamochoduDataGridViewTextBoxColumn.Visible = false;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerrejDataGridViewTextBoxColumn
            // 
            this.numerrejDataGridViewTextBoxColumn.DataPropertyName = "numer_rej";
            this.numerrejDataGridViewTextBoxColumn.HeaderText = "numer_rej";
            this.numerrejDataGridViewTextBoxColumn.Name = "numerrejDataGridViewTextBoxColumn";
            this.numerrejDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rokprodukcjiDataGridViewTextBoxColumn
            // 
            this.rokprodukcjiDataGridViewTextBoxColumn.DataPropertyName = "rok_produkcji";
            this.rokprodukcjiDataGridViewTextBoxColumn.HeaderText = "rok_produkcji";
            this.rokprodukcjiDataGridViewTextBoxColumn.Name = "rokprodukcjiDataGridViewTextBoxColumn";
            this.rokprodukcjiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodzajpaliwaDataGridViewTextBoxColumn
            // 
            this.rodzajpaliwaDataGridViewTextBoxColumn.DataPropertyName = "rodzaj_paliwa";
            this.rodzajpaliwaDataGridViewTextBoxColumn.HeaderText = "rodzaj_paliwa";
            this.rodzajpaliwaDataGridViewTextBoxColumn.Name = "rodzajpaliwaDataGridViewTextBoxColumn";
            this.rodzajpaliwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolorDataGridViewTextBoxColumn
            // 
            this.kolorDataGridViewTextBoxColumn.DataPropertyName = "kolor";
            this.kolorDataGridViewTextBoxColumn.HeaderText = "kolor";
            this.kolorDataGridViewTextBoxColumn.Name = "kolorDataGridViewTextBoxColumn";
            this.kolorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cenazadzienDataGridViewTextBoxColumn
            // 
            this.cenazadzienDataGridViewTextBoxColumn.DataPropertyName = "cena_za_dzien";
            this.cenazadzienDataGridViewTextBoxColumn.HeaderText = "cena_za_dzien";
            this.cenazadzienDataGridViewTextBoxColumn.Name = "cenazadzienDataGridViewTextBoxColumn";
            this.cenazadzienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rodzajskrzyniDataGridViewTextBoxColumn
            // 
            this.rodzajskrzyniDataGridViewTextBoxColumn.DataPropertyName = "rodzaj_skrzyni";
            this.rodzajskrzyniDataGridViewTextBoxColumn.HeaderText = "rodzaj_skrzyni";
            this.rodzajskrzyniDataGridViewTextBoxColumn.Name = "rodzajskrzyniDataGridViewTextBoxColumn";
            this.rodzajskrzyniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kaucjaDataGridViewTextBoxColumn
            // 
            this.kaucjaDataGridViewTextBoxColumn.DataPropertyName = "kaucja";
            this.kaucjaDataGridViewTextBoxColumn.HeaderText = "kaucja";
            this.kaucjaDataGridViewTextBoxColumn.Name = "kaucjaDataGridViewTextBoxColumn";
            this.kaucjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // samochodBindingSource1
            // 
            this.samochodBindingSource1.DataMember = "Samochod";
            this.samochodBindingSource1.DataSource = this.wypozyczalniaDataSet;
            // 
            // wypozyczalniaDataSet
            // 
            this.wypozyczalniaDataSet.DataSetName = "WypozyczalniaDataSet";
            this.wypozyczalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_SDodaj
            // 
            this.btn_SDodaj.Location = new System.Drawing.Point(12, 444);
            this.btn_SDodaj.Name = "btn_SDodaj";
            this.btn_SDodaj.Size = new System.Drawing.Size(105, 23);
            this.btn_SDodaj.TabIndex = 1;
            this.btn_SDodaj.Text = "Dodaj";
            this.btn_SDodaj.UseVisualStyleBackColor = true;
            this.btn_SDodaj.Click += new System.EventHandler(this.btn_SDodaj_Click);
            // 
            // btn_SUsun
            // 
            this.btn_SUsun.Location = new System.Drawing.Point(123, 444);
            this.btn_SUsun.Name = "btn_SUsun";
            this.btn_SUsun.Size = new System.Drawing.Size(84, 23);
            this.btn_SUsun.TabIndex = 2;
            this.btn_SUsun.Text = "Usun";
            this.btn_SUsun.UseVisualStyleBackColor = true;
            this.btn_SUsun.Click += new System.EventHandler(this.btn_SUsun_Click);
            // 
            // btn_SModyfikuj
            // 
            this.btn_SModyfikuj.Location = new System.Drawing.Point(213, 444);
            this.btn_SModyfikuj.Name = "btn_SModyfikuj";
            this.btn_SModyfikuj.Size = new System.Drawing.Size(84, 23);
            this.btn_SModyfikuj.TabIndex = 3;
            this.btn_SModyfikuj.Text = "Modyfikuj";
            this.btn_SModyfikuj.UseVisualStyleBackColor = true;
            this.btn_SModyfikuj.Click += new System.EventHandler(this.btn_SModyfikuj_Click);
            // 
            // btn_specyfikacja
            // 
            this.btn_specyfikacja.Location = new System.Drawing.Point(688, 444);
            this.btn_specyfikacja.Name = "btn_specyfikacja";
            this.btn_specyfikacja.Size = new System.Drawing.Size(100, 23);
            this.btn_specyfikacja.TabIndex = 4;
            this.btn_specyfikacja.Text = "Specyfikacja";
            this.btn_specyfikacja.UseVisualStyleBackColor = true;
            this.btn_specyfikacja.Click += new System.EventHandler(this.btn_specyfikacja_Click);
            // 
            // samochodBindingSource
            // 
            this.samochodBindingSource.DataMember = "Samochod";
            this.samochodBindingSource.DataSource = this.wypozyczalniaDataSet;
            // 
            // samochodTableAdapter
            // 
            this.samochodTableAdapter.ClearBeforeFill = true;
            // 
            // fKSpecyfikaidsa52593CB8BindingSource
            // 
            this.fKSpecyfikaidsa52593CB8BindingSource.DataMember = "FK__Specyfika__id_sa__52593CB8";
            this.fKSpecyfikaidsa52593CB8BindingSource.DataSource = this.samochodBindingSource;
            // 
            // specyfikacjeSamochodowTableAdapter
            // 
            this.specyfikacjeSamochodowTableAdapter.ClearBeforeFill = true;
            // 
            // wypozyczalniaDataSetBindingSource
            // 
            this.wypozyczalniaDataSetBindingSource.DataSource = this.wypozyczalniaDataSet;
            this.wypozyczalniaDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cofnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Samochody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_specyfikacja);
            this.Controls.Add(this.btn_SModyfikuj);
            this.Controls.Add(this.btn_SUsun);
            this.Controls.Add(this.btn_SDodaj);
            this.Controls.Add(this.dgv_samochody);
            this.Name = "Samochody";
            this.Text = "Samochody";
            this.Load += new System.EventHandler(this.Samochody_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_samochody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSpecyfikaidsa52593CB8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_SDodaj;
        private System.Windows.Forms.Button btn_SUsun;
        private System.Windows.Forms.Button btn_SModyfikuj;
        public System.Windows.Forms.DataGridView dgv_samochody;
        private System.Windows.Forms.Button btn_specyfikacja;
        private WypozyczalniaDataSet wypozyczalniaDataSet;
        private System.Windows.Forms.BindingSource samochodBindingSource;
        private WypozyczalniaDataSetTableAdapters.SamochodTableAdapter samochodTableAdapter;
        private System.Windows.Forms.BindingSource fKSpecyfikaidsa52593CB8BindingSource;
        private WypozyczalniaDataSetTableAdapters.SpecyfikacjeSamochodowTableAdapter specyfikacjeSamochodowTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsamochoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerrejDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokprodukcjiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajpaliwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenazadzienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajskrzyniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaucjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource samochodBindingSource1;
        private System.Windows.Forms.BindingSource wypozyczalniaDataSetBindingSource;
        private System.Windows.Forms.Button button1;
    }
}