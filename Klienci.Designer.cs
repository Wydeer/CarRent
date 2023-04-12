namespace Wypozyczalnia
{
    partial class Klienci
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
            this.btn_KModyfikuj = new System.Windows.Forms.Button();
            this.btn_KUsun = new System.Windows.Forms.Button();
            this.btn_KDodaj = new System.Windows.Forms.Button();
            this.dgv_klienci = new System.Windows.Forms.DataGridView();
            this.idklientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stalyklientDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerdowoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczalniaDataSet = new Wypozyczalnia.WypozyczalniaDataSet();
            this.klientTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.KlientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klienci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_KModyfikuj
            // 
            this.btn_KModyfikuj.Location = new System.Drawing.Point(200, 349);
            this.btn_KModyfikuj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KModyfikuj.Name = "btn_KModyfikuj";
            this.btn_KModyfikuj.Size = new System.Drawing.Size(73, 33);
            this.btn_KModyfikuj.TabIndex = 7;
            this.btn_KModyfikuj.Text = "Modyfikuj";
            this.btn_KModyfikuj.UseVisualStyleBackColor = true;
            this.btn_KModyfikuj.Click += new System.EventHandler(this.btn_KModyfikuj_Click);
            // 
            // btn_KUsun
            // 
            this.btn_KUsun.Location = new System.Drawing.Point(103, 349);
            this.btn_KUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KUsun.Name = "btn_KUsun";
            this.btn_KUsun.Size = new System.Drawing.Size(73, 33);
            this.btn_KUsun.TabIndex = 6;
            this.btn_KUsun.Text = "Usuń";
            this.btn_KUsun.UseVisualStyleBackColor = true;
            this.btn_KUsun.Click += new System.EventHandler(this.btn_KUsun_Click);
            // 
            // btn_KDodaj
            // 
            this.btn_KDodaj.Location = new System.Drawing.Point(11, 349);
            this.btn_KDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_KDodaj.Name = "btn_KDodaj";
            this.btn_KDodaj.Size = new System.Drawing.Size(73, 33);
            this.btn_KDodaj.TabIndex = 5;
            this.btn_KDodaj.Text = "Dodaj";
            this.btn_KDodaj.UseVisualStyleBackColor = true;
            this.btn_KDodaj.Click += new System.EventHandler(this.btn_KDodaj_Click);
            // 
            // dgv_klienci
            // 
            this.dgv_klienci.AllowUserToAddRows = false;
            this.dgv_klienci.AllowUserToDeleteRows = false;
            this.dgv_klienci.AutoGenerateColumns = false;
            this.dgv_klienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_klienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klienci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklientaDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.dataurDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.stalyklientDataGridViewCheckBoxColumn,
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn,
            this.numerdowoduDataGridViewTextBoxColumn});
            this.dgv_klienci.DataSource = this.klientBindingSource;
            this.dgv_klienci.Location = new System.Drawing.Point(9, 10);
            this.dgv_klienci.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_klienci.Name = "dgv_klienci";
            this.dgv_klienci.ReadOnly = true;
            this.dgv_klienci.RowHeadersWidth = 51;
            this.dgv_klienci.RowTemplate.Height = 24;
            this.dgv_klienci.Size = new System.Drawing.Size(759, 335);
            this.dgv_klienci.TabIndex = 4;
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
            // dataurDataGridViewTextBoxColumn
            // 
            this.dataurDataGridViewTextBoxColumn.DataPropertyName = "data_ur";
            this.dataurDataGridViewTextBoxColumn.HeaderText = "data_ur";
            this.dataurDataGridViewTextBoxColumn.Name = "dataurDataGridViewTextBoxColumn";
            this.dataurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stalyklientDataGridViewCheckBoxColumn
            // 
            this.stalyklientDataGridViewCheckBoxColumn.DataPropertyName = "staly_klient";
            this.stalyklientDataGridViewCheckBoxColumn.HeaderText = "staly_klient";
            this.stalyklientDataGridViewCheckBoxColumn.Name = "stalyklientDataGridViewCheckBoxColumn";
            this.stalyklientDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // datawaznosciprawajazdyDataGridViewTextBoxColumn
            // 
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn.DataPropertyName = "data_waznosci_prawa_jazdy";
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn.HeaderText = "data_waznosci_prawa_jazdy";
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn.Name = "datawaznosciprawajazdyDataGridViewTextBoxColumn";
            this.datawaznosciprawajazdyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerdowoduDataGridViewTextBoxColumn
            // 
            this.numerdowoduDataGridViewTextBoxColumn.DataPropertyName = "numer_dowodu";
            this.numerdowoduDataGridViewTextBoxColumn.HeaderText = "numer_dowodu";
            this.numerdowoduDataGridViewTextBoxColumn.Name = "numerdowoduDataGridViewTextBoxColumn";
            this.numerdowoduDataGridViewTextBoxColumn.ReadOnly = true;
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
            // klientTableAdapter
            // 
            this.klientTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cofnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Klienci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_KModyfikuj);
            this.Controls.Add(this.btn_KUsun);
            this.Controls.Add(this.btn_KDodaj);
            this.Controls.Add(this.dgv_klienci);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Klienci";
            this.Text = "Klienci";
            this.Load += new System.EventHandler(this.Klienci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klienci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_KModyfikuj;
        private System.Windows.Forms.Button btn_KUsun;
        private System.Windows.Forms.Button btn_KDodaj;
        public System.Windows.Forms.DataGridView dgv_klienci;
        private WypozyczalniaDataSet wypozyczalniaDataSet;
        private System.Windows.Forms.BindingSource klientBindingSource;
        private WypozyczalniaDataSetTableAdapters.KlientTableAdapter klientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stalyklientDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datawaznosciprawajazdyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerdowoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}