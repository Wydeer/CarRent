﻿namespace Wypozyczalnia
{
    partial class DodajWypozyczenie
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
            this.dgv_DWsamochody = new System.Windows.Forms.DataGridView();
            this.dgv_DWklienci = new System.Windows.Forms.DataGridView();
            this.idklientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stalyklientDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczalniaDataSet = new Wypozyczalnia.WypozyczalniaDataSet();
            this.btn_DodajWypo = new System.Windows.Forms.Button();
            this.cbx_Ubezpiecznie = new System.Windows.Forms.CheckBox();
            this.dtp_Datawypo = new System.Windows.Forms.DateTimePicker();
            this.dtp_Datazwrotu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_koszt = new System.Windows.Forms.TextBox();
            this.samochodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samochodTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.SamochodTableAdapter();
            this.klientTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.KlientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DWsamochody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DWklienci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DWsamochody
            // 
            this.dgv_DWsamochody.AllowUserToAddRows = false;
            this.dgv_DWsamochody.AllowUserToDeleteRows = false;
            this.dgv_DWsamochody.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DWsamochody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DWsamochody.Location = new System.Drawing.Point(12, 12);
            this.dgv_DWsamochody.Name = "dgv_DWsamochody";
            this.dgv_DWsamochody.ReadOnly = true;
            this.dgv_DWsamochody.Size = new System.Drawing.Size(776, 213);
            this.dgv_DWsamochody.TabIndex = 0;
            this.dgv_DWsamochody.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DWsamochody_CellClick);
            // 
            // dgv_DWklienci
            // 
            this.dgv_DWklienci.AllowUserToAddRows = false;
            this.dgv_DWklienci.AllowUserToDeleteRows = false;
            this.dgv_DWklienci.AutoGenerateColumns = false;
            this.dgv_DWklienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DWklienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DWklienci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklientaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn,
            this.stalyklientDataGridViewCheckBoxColumn});
            this.dgv_DWklienci.DataSource = this.klientBindingSource;
            this.dgv_DWklienci.Location = new System.Drawing.Point(12, 247);
            this.dgv_DWklienci.Name = "dgv_DWklienci";
            this.dgv_DWklienci.ReadOnly = true;
            this.dgv_DWklienci.Size = new System.Drawing.Size(776, 193);
            this.dgv_DWklienci.TabIndex = 1;
            this.dgv_DWklienci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DWklienci_CellClick);
            // 
            // idklientaDataGridViewTextBoxColumn
            // 
            this.idklientaDataGridViewTextBoxColumn.DataPropertyName = "id_klienta";
            this.idklientaDataGridViewTextBoxColumn.HeaderText = "id_klienta";
            this.idklientaDataGridViewTextBoxColumn.Name = "idklientaDataGridViewTextBoxColumn";
            this.idklientaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idklientaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datawaznosciprawajazdyDataGridViewTextBoxColumn
            // 
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn.DataPropertyName = "data_waznosci_prawa_jazdy";
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn.HeaderText = "data_waznosci_prawa_jazdy";
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn.Name = "datawaznosciprawajazdyDataGridViewTextBoxColumn";
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stalyklientDataGridViewCheckBoxColumn
            // 
            this.stalyklientDataGridViewCheckBoxColumn.DataPropertyName = "staly_klient";
            this.stalyklientDataGridViewCheckBoxColumn.HeaderText = "staly_klient";
            this.stalyklientDataGridViewCheckBoxColumn.Name = "stalyklientDataGridViewCheckBoxColumn";
            this.stalyklientDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // klientBindingSource
            // 
            this.klientBindingSource.DataMember = "Klient";
            this.klientBindingSource.DataSource = this.wypozyczalniaDataSet;
            // 
            // wypozyczalniaDataSet
            // 
            this.wypozyczalniaDataSet.DataSetName = "WypozyczalniaDataSet";
            this.wypozyczalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_DodajWypo
            // 
            this.btn_DodajWypo.Location = new System.Drawing.Point(12, 479);
            this.btn_DodajWypo.Name = "btn_DodajWypo";
            this.btn_DodajWypo.Size = new System.Drawing.Size(86, 37);
            this.btn_DodajWypo.TabIndex = 2;
            this.btn_DodajWypo.Text = "Dodaj";
            this.btn_DodajWypo.UseVisualStyleBackColor = true;
            this.btn_DodajWypo.Click += new System.EventHandler(this.btn_DodajWypo_Click);
            // 
            // cbx_Ubezpiecznie
            // 
            this.cbx_Ubezpiecznie.AutoSize = true;
            this.cbx_Ubezpiecznie.Location = new System.Drawing.Point(12, 456);
            this.cbx_Ubezpiecznie.Name = "cbx_Ubezpiecznie";
            this.cbx_Ubezpiecznie.Size = new System.Drawing.Size(191, 17);
            this.cbx_Ubezpiecznie.TabIndex = 3;
            this.cbx_Ubezpiecznie.Text = "Dodatkowe ubezpieczenie: 1000zł";
            this.cbx_Ubezpiecznie.UseVisualStyleBackColor = true;
            this.cbx_Ubezpiecznie.CheckedChanged += new System.EventHandler(this.cbx_Ubezpiecznie_CheckedChanged);
            // 
            // dtp_Datawypo
            // 
            this.dtp_Datawypo.Location = new System.Drawing.Point(257, 456);
            this.dtp_Datawypo.Name = "dtp_Datawypo";
            this.dtp_Datawypo.Size = new System.Drawing.Size(200, 20);
            this.dtp_Datawypo.TabIndex = 4;
            this.dtp_Datawypo.ValueChanged += new System.EventHandler(this.dtp_Datawypo_ValueChanged);
            // 
            // dtp_Datazwrotu
            // 
            this.dtp_Datazwrotu.Location = new System.Drawing.Point(487, 456);
            this.dtp_Datazwrotu.Name = "dtp_Datazwrotu";
            this.dtp_Datazwrotu.Size = new System.Drawing.Size(200, 20);
            this.dtp_Datazwrotu.TabIndex = 5;
            this.dtp_Datazwrotu.ValueChanged += new System.EventHandler(this.dtp_Datazwrotu_ValueChanged);
            this.dtp_Datazwrotu.BindingContextChanged += new System.EventHandler(this.dtp_Datazwrotu_BindingContextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kwota:";
            // 
            // txt_koszt
            // 
            this.txt_koszt.Location = new System.Drawing.Point(307, 487);
            this.txt_koszt.Name = "txt_koszt";
            this.txt_koszt.ReadOnly = true;
            this.txt_koszt.Size = new System.Drawing.Size(100, 20);
            this.txt_koszt.TabIndex = 7;
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
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cofnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajWypozyczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_koszt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Datazwrotu);
            this.Controls.Add(this.dtp_Datawypo);
            this.Controls.Add(this.cbx_Ubezpiecznie);
            this.Controls.Add(this.btn_DodajWypo);
            this.Controls.Add(this.dgv_DWklienci);
            this.Controls.Add(this.dgv_DWsamochody);
            this.Name = "DodajWypozyczenie";
            this.Text = "DodajWyporzyczenie";
            this.Load += new System.EventHandler(this.DodajWyporzyczenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DWsamochody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DWklienci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DWsamochody;
        private System.Windows.Forms.DataGridView dgv_DWklienci;
        private System.Windows.Forms.Button btn_DodajWypo;
        private System.Windows.Forms.DateTimePicker dtp_Datawypo;
        private System.Windows.Forms.DateTimePicker dtp_Datazwrotu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_koszt;
        public System.Windows.Forms.CheckBox cbx_Ubezpiecznie;
        private WypozyczalniaDataSet wypozyczalniaDataSet;
        private System.Windows.Forms.BindingSource samochodBindingSource;
        private WypozyczalniaDataSetTableAdapters.SamochodTableAdapter samochodTableAdapter;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private WypozyczalniaDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datawaznosciprawajazdyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stalyklientDataGridViewCheckBoxColumn;
    }
}