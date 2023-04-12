namespace Wypozyczalnia
{
    partial class Ubezpieczenia
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
            this.btn_UModyfikuj = new System.Windows.Forms.Button();
            this.btn_UUsun = new System.Windows.Forms.Button();
            this.btn_UDodaj = new System.Windows.Forms.Button();
            this.dgv_ubezpieczenia = new System.Windows.Forms.DataGridView();
            this.cbx_EUtyp = new System.Windows.Forms.ComboBox();
            this.dtp_EUdata_od = new System.Windows.Forms.DateTimePicker();
            this.dtp_EUdata_do = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.wypozyczalniaDataSet = new Wypozyczalnia.WypozyczalniaDataSet();
            this.ubezpieczenieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubezpieczenieTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.UbezpieczenieTableAdapter();
            this.samochodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.samochodTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.SamochodTableAdapter();
            this.samochodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ubezpieczenieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ubezpieczenieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczeniaTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.WypozyczeniaTableAdapter();
            this.ubezpieczenieBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczalniaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubezpieczenieBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubezpieczenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_UModyfikuj
            // 
            this.btn_UModyfikuj.Location = new System.Drawing.Point(697, 468);
            this.btn_UModyfikuj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UModyfikuj.Name = "btn_UModyfikuj";
            this.btn_UModyfikuj.Size = new System.Drawing.Size(79, 32);
            this.btn_UModyfikuj.TabIndex = 11;
            this.btn_UModyfikuj.Text = "Modyfikuj";
            this.btn_UModyfikuj.UseVisualStyleBackColor = true;
            this.btn_UModyfikuj.Click += new System.EventHandler(this.btn_UModyfikuj_Click);
            // 
            // btn_UUsun
            // 
            this.btn_UUsun.Location = new System.Drawing.Point(110, 380);
            this.btn_UUsun.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UUsun.Name = "btn_UUsun";
            this.btn_UUsun.Size = new System.Drawing.Size(89, 35);
            this.btn_UUsun.TabIndex = 10;
            this.btn_UUsun.Text = "Usuń";
            this.btn_UUsun.UseVisualStyleBackColor = true;
            this.btn_UUsun.Click += new System.EventHandler(this.btn_UUsun_Click);
            // 
            // btn_UDodaj
            // 
            this.btn_UDodaj.Location = new System.Drawing.Point(17, 379);
            this.btn_UDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UDodaj.Name = "btn_UDodaj";
            this.btn_UDodaj.Size = new System.Drawing.Size(89, 36);
            this.btn_UDodaj.TabIndex = 9;
            this.btn_UDodaj.Text = "Dodaj";
            this.btn_UDodaj.UseVisualStyleBackColor = true;
            this.btn_UDodaj.Click += new System.EventHandler(this.btn_UDodaj_Click);
            // 
            // dgv_ubezpieczenia
            // 
            this.dgv_ubezpieczenia.AllowUserToAddRows = false;
            this.dgv_ubezpieczenia.AllowUserToDeleteRows = false;
            this.dgv_ubezpieczenia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ubezpieczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ubezpieczenia.Location = new System.Drawing.Point(17, 40);
            this.dgv_ubezpieczenia.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ubezpieczenia.Name = "dgv_ubezpieczenia";
            this.dgv_ubezpieczenia.ReadOnly = true;
            this.dgv_ubezpieczenia.RowHeadersWidth = 51;
            this.dgv_ubezpieczenia.RowTemplate.Height = 24;
            this.dgv_ubezpieczenia.Size = new System.Drawing.Size(759, 335);
            this.dgv_ubezpieczenia.TabIndex = 8;
            this.dgv_ubezpieczenia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ubezpieczenia_CellClick);
            this.dgv_ubezpieczenia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ubezpieczenia_CellContentClick);
            // 
            // cbx_EUtyp
            // 
            this.cbx_EUtyp.AutoCompleteCustomSource.AddRange(new string[] {
            "OC",
            "OC/AC"});
            this.cbx_EUtyp.FormattingEnabled = true;
            this.cbx_EUtyp.Items.AddRange(new object[] {
            "OC",
            "OC/AC"});
            this.cbx_EUtyp.Location = new System.Drawing.Point(655, 442);
            this.cbx_EUtyp.Name = "cbx_EUtyp";
            this.cbx_EUtyp.Size = new System.Drawing.Size(121, 21);
            this.cbx_EUtyp.TabIndex = 12;
            // 
            // dtp_EUdata_od
            // 
            this.dtp_EUdata_od.Location = new System.Drawing.Point(576, 390);
            this.dtp_EUdata_od.Name = "dtp_EUdata_od";
            this.dtp_EUdata_od.Size = new System.Drawing.Size(200, 20);
            this.dtp_EUdata_od.TabIndex = 13;
            // 
            // dtp_EUdata_do
            // 
            this.dtp_EUdata_do.Location = new System.Drawing.Point(576, 416);
            this.dtp_EUdata_do.Name = "dtp_EUdata_do";
            this.dtp_EUdata_do.Size = new System.Drawing.Size(200, 20);
            this.dtp_EUdata_do.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cofnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wypozyczalniaDataSet
            // 
            this.wypozyczalniaDataSet.DataSetName = "WypozyczalniaDataSet";
            this.wypozyczalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ubezpieczenieBindingSource
            // 
            this.ubezpieczenieBindingSource.DataMember = "Ubezpieczenie";
            this.ubezpieczenieBindingSource.DataSource = this.wypozyczalniaDataSet;
            // 
            // ubezpieczenieTableAdapter
            // 
            this.ubezpieczenieTableAdapter.ClearBeforeFill = true;
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
            // samochodBindingSource1
            // 
            this.samochodBindingSource1.DataMember = "Samochod";
            this.samochodBindingSource1.DataSource = this.wypozyczalniaDataSet;
            // 
            // ubezpieczenieBindingSource1
            // 
            this.ubezpieczenieBindingSource1.DataMember = "Ubezpieczenie";
            this.ubezpieczenieBindingSource1.DataSource = this.wypozyczalniaDataSet;
            // 
            // ubezpieczenieBindingSource2
            // 
            this.ubezpieczenieBindingSource2.DataMember = "Ubezpieczenie";
            this.ubezpieczenieBindingSource2.DataSource = this.wypozyczalniaDataSet;
            // 
            // wypozyczeniaBindingSource
            // 
            this.wypozyczeniaBindingSource.DataMember = "Wypozyczenia";
            this.wypozyczeniaBindingSource.DataSource = this.wypozyczalniaDataSet;
            // 
            // wypozyczeniaTableAdapter
            // 
            this.wypozyczeniaTableAdapter.ClearBeforeFill = true;
            // 
            // ubezpieczenieBindingSource3
            // 
            this.ubezpieczenieBindingSource3.DataMember = "Ubezpieczenie";
            this.ubezpieczenieBindingSource3.DataSource = this.wypozyczalniaDataSet;
            // 
            // wypozyczalniaDataSetBindingSource
            // 
            this.wypozyczalniaDataSetBindingSource.DataSource = this.wypozyczalniaDataSet;
            this.wypozyczalniaDataSetBindingSource.Position = 0;
            // 
            // ubezpieczenieBindingSource4
            // 
            this.ubezpieczenieBindingSource4.DataMember = "Ubezpieczenie";
            this.ubezpieczenieBindingSource4.DataSource = this.wypozyczalniaDataSet;
            // 
            // Ubezpieczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_EUdata_do);
            this.Controls.Add(this.dtp_EUdata_od);
            this.Controls.Add(this.cbx_EUtyp);
            this.Controls.Add(this.btn_UModyfikuj);
            this.Controls.Add(this.btn_UUsun);
            this.Controls.Add(this.btn_UDodaj);
            this.Controls.Add(this.dgv_ubezpieczenia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ubezpieczenia";
            this.Text = "Ubezpieczenia";
            this.Load += new System.EventHandler(this.Ubezpieczenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubezpieczenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_UModyfikuj;
        private System.Windows.Forms.Button btn_UUsun;
        private System.Windows.Forms.Button btn_UDodaj;
        public System.Windows.Forms.DataGridView dgv_ubezpieczenia;
        private System.Windows.Forms.ComboBox cbx_EUtyp;
        private System.Windows.Forms.DateTimePicker dtp_EUdata_od;
        private System.Windows.Forms.DateTimePicker dtp_EUdata_do;
        private WypozyczalniaDataSet wypozyczalniaDataSet;
        private System.Windows.Forms.BindingSource ubezpieczenieBindingSource;
        private WypozyczalniaDataSetTableAdapters.UbezpieczenieTableAdapter ubezpieczenieTableAdapter;
        private System.Windows.Forms.BindingSource samochodBindingSource;
        private WypozyczalniaDataSetTableAdapters.SamochodTableAdapter samochodTableAdapter;
        private System.Windows.Forms.BindingSource samochodBindingSource1;
        private System.Windows.Forms.BindingSource ubezpieczenieBindingSource1;
        private System.Windows.Forms.BindingSource ubezpieczenieBindingSource2;
        private System.Windows.Forms.BindingSource wypozyczeniaBindingSource;
        private WypozyczalniaDataSetTableAdapters.WypozyczeniaTableAdapter wypozyczeniaTableAdapter;
        private System.Windows.Forms.BindingSource ubezpieczenieBindingSource4;
        private System.Windows.Forms.BindingSource ubezpieczenieBindingSource3;
        private System.Windows.Forms.BindingSource wypozyczalniaDataSetBindingSource;
        private System.Windows.Forms.Button button1;
    }
}