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
            this.btn_UModyfikuj = new System.Windows.Forms.Button();
            this.btn_UUsun = new System.Windows.Forms.Button();
            this.btn_UDodaj = new System.Windows.Forms.Button();
            this.dgv_ubezpieczenia = new System.Windows.Forms.DataGridView();
            this.cbx_EUtyp = new System.Windows.Forms.ComboBox();
            this.dtp_EUdata_od = new System.Windows.Forms.DateTimePicker();
            this.dtp_EUdata_do = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubezpieczenia)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_UModyfikuj
            // 
            this.btn_UModyfikuj.Location = new System.Drawing.Point(697, 468);
            this.btn_UModyfikuj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_UModyfikuj.Name = "btn_UModyfikuj";
            this.btn_UModyfikuj.Size = new System.Drawing.Size(79, 32);
            this.btn_UModyfikuj.TabIndex = 11;
            this.btn_UModyfikuj.Text = "Modyfikuj";
            this.btn_UModyfikuj.UseVisualStyleBackColor = true;
            this.btn_UModyfikuj.Click += new System.EventHandler(this.btn_UModyfikuj_Click);
            // 
            // btn_UUsun
            // 
            this.btn_UUsun.Location = new System.Drawing.Point(94, 393);
            this.btn_UUsun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_UUsun.Name = "btn_UUsun";
            this.btn_UUsun.Size = new System.Drawing.Size(56, 19);
            this.btn_UUsun.TabIndex = 10;
            this.btn_UUsun.Text = "Usuń";
            this.btn_UUsun.UseVisualStyleBackColor = true;
            this.btn_UUsun.Click += new System.EventHandler(this.btn_UUsun_Click);
            // 
            // btn_UDodaj
            // 
            this.btn_UDodaj.Location = new System.Drawing.Point(17, 393);
            this.btn_UDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_UDodaj.Name = "btn_UDodaj";
            this.btn_UDodaj.Size = new System.Drawing.Size(56, 19);
            this.btn_UDodaj.TabIndex = 9;
            this.btn_UDodaj.Text = "Dodaj";
            this.btn_UDodaj.UseVisualStyleBackColor = true;
            this.btn_UDodaj.Click += new System.EventHandler(this.btn_UDodaj_Click);
            // 
            // dgv_ubezpieczenia
            // 
            this.dgv_ubezpieczenia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ubezpieczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ubezpieczenia.Location = new System.Drawing.Point(17, 40);
            this.dgv_ubezpieczenia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // Ubezpieczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 523);
            this.Controls.Add(this.dtp_EUdata_do);
            this.Controls.Add(this.dtp_EUdata_od);
            this.Controls.Add(this.cbx_EUtyp);
            this.Controls.Add(this.btn_UModyfikuj);
            this.Controls.Add(this.btn_UUsun);
            this.Controls.Add(this.btn_UDodaj);
            this.Controls.Add(this.dgv_ubezpieczenia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ubezpieczenia";
            this.Text = "Ubezpieczenia";
            this.Load += new System.EventHandler(this.Ubezpieczenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ubezpieczenia)).EndInit();
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
    }
}