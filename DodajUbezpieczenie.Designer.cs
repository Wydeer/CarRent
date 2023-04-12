namespace Wypozyczalnia
{
    partial class DodajUbezpieczenie
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
            this.dgv_Dubezpieczenie = new System.Windows.Forms.DataGridView();
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
            this.samochodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczalniaDataSet = new Wypozyczalnia.WypozyczalniaDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_DUdata_do = new System.Windows.Forms.DateTimePicker();
            this.dtp_DUdata_od = new System.Windows.Forms.DateTimePicker();
            this.cbx_typ = new System.Windows.Forms.ComboBox();
            this.samochodTableAdapter = new Wypozyczalnia.WypozyczalniaDataSetTableAdapters.SamochodTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dubezpieczenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Dubezpieczenie
            // 
            this.dgv_Dubezpieczenie.AllowUserToAddRows = false;
            this.dgv_Dubezpieczenie.AllowUserToDeleteRows = false;
            this.dgv_Dubezpieczenie.AutoGenerateColumns = false;
            this.dgv_Dubezpieczenie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Dubezpieczenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dubezpieczenie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_Dubezpieczenie.DataSource = this.samochodBindingSource;
            this.dgv_Dubezpieczenie.Location = new System.Drawing.Point(12, 12);
            this.dgv_Dubezpieczenie.Name = "dgv_Dubezpieczenie";
            this.dgv_Dubezpieczenie.ReadOnly = true;
            this.dgv_Dubezpieczenie.Size = new System.Drawing.Size(776, 277);
            this.dgv_Dubezpieczenie.TabIndex = 0;
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
            // samochodBindingSource
            // 
            this.samochodBindingSource.DataMember = "Samochod";
            this.samochodBindingSource.DataSource = this.wypozyczalniaDataSet;
            // 
            // wypozyczalniaDataSet
            // 
            this.wypozyczalniaDataSet.DataSetName = "WypozyczalniaDataSet";
            this.wypozyczalniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp_DUdata_do
            // 
            this.dtp_DUdata_do.Location = new System.Drawing.Point(523, 296);
            this.dtp_DUdata_do.Name = "dtp_DUdata_do";
            this.dtp_DUdata_do.Size = new System.Drawing.Size(200, 20);
            this.dtp_DUdata_do.TabIndex = 2;
            // 
            // dtp_DUdata_od
            // 
            this.dtp_DUdata_od.Location = new System.Drawing.Point(297, 296);
            this.dtp_DUdata_od.Name = "dtp_DUdata_od";
            this.dtp_DUdata_od.Size = new System.Drawing.Size(200, 20);
            this.dtp_DUdata_od.TabIndex = 3;
            this.dtp_DUdata_od.ValueChanged += new System.EventHandler(this.dtp_DUdata_od_ValueChanged);
            // 
            // cbx_typ
            // 
            this.cbx_typ.FormattingEnabled = true;
            this.cbx_typ.Items.AddRange(new object[] {
            "OC",
            "OC/AC"});
            this.cbx_typ.Location = new System.Drawing.Point(137, 295);
            this.cbx_typ.Name = "cbx_typ";
            this.cbx_typ.Size = new System.Drawing.Size(121, 21);
            this.cbx_typ.TabIndex = 4;
            // 
            // samochodTableAdapter
            // 
            this.samochodTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cofnij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DodajUbezpieczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbx_typ);
            this.Controls.Add(this.dtp_DUdata_od);
            this.Controls.Add(this.dtp_DUdata_do);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Dubezpieczenie);
            this.Name = "DodajUbezpieczenie";
            this.Text = "DodajUbezpieczenie";
            this.Load += new System.EventHandler(this.DodajUbezpieczenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dubezpieczenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samochodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczalniaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Dubezpieczenie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_DUdata_do;
        private System.Windows.Forms.DateTimePicker dtp_DUdata_od;
        private System.Windows.Forms.ComboBox cbx_typ;
        private WypozyczalniaDataSet wypozyczalniaDataSet;
        private System.Windows.Forms.BindingSource samochodBindingSource;
        private WypozyczalniaDataSetTableAdapters.SamochodTableAdapter samochodTableAdapter;
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
        private System.Windows.Forms.Button button2;
    }
}