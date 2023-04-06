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
            this.btn_KModyfikuj = new System.Windows.Forms.Button();
            this.btn_KUsun = new System.Windows.Forms.Button();
            this.btn_KDodaj = new System.Windows.Forms.Button();
            this.dgv_klienci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klienci)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_KModyfikuj
            // 
            this.btn_KModyfikuj.Location = new System.Drawing.Point(305, 363);
            this.btn_KModyfikuj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_KModyfikuj.Name = "btn_KModyfikuj";
            this.btn_KModyfikuj.Size = new System.Drawing.Size(56, 19);
            this.btn_KModyfikuj.TabIndex = 7;
            this.btn_KModyfikuj.Text = "Modyfikuj";
            this.btn_KModyfikuj.UseVisualStyleBackColor = true;
            this.btn_KModyfikuj.Click += new System.EventHandler(this.btn_KModyfikuj_Click);
            // 
            // btn_KUsun
            // 
            this.btn_KUsun.Location = new System.Drawing.Point(179, 363);
            this.btn_KUsun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_KUsun.Name = "btn_KUsun";
            this.btn_KUsun.Size = new System.Drawing.Size(56, 19);
            this.btn_KUsun.TabIndex = 6;
            this.btn_KUsun.Text = "Usuń";
            this.btn_KUsun.UseVisualStyleBackColor = true;
            this.btn_KUsun.Click += new System.EventHandler(this.btn_KUsun_Click);
            // 
            // btn_KDodaj
            // 
            this.btn_KDodaj.Location = new System.Drawing.Point(51, 364);
            this.btn_KDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_KDodaj.Name = "btn_KDodaj";
            this.btn_KDodaj.Size = new System.Drawing.Size(56, 19);
            this.btn_KDodaj.TabIndex = 5;
            this.btn_KDodaj.Text = "Dodaj";
            this.btn_KDodaj.UseVisualStyleBackColor = true;
            this.btn_KDodaj.Click += new System.EventHandler(this.btn_KDodaj_Click);
            // 
            // dgv_klienci
            // 
            this.dgv_klienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_klienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klienci.Location = new System.Drawing.Point(9, 10);
            this.dgv_klienci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_klienci.Name = "dgv_klienci";
            this.dgv_klienci.RowHeadersWidth = 51;
            this.dgv_klienci.RowTemplate.Height = 24;
            this.dgv_klienci.Size = new System.Drawing.Size(759, 335);
            this.dgv_klienci.TabIndex = 4;
            // 
            // Klienci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 412);
            this.Controls.Add(this.btn_KModyfikuj);
            this.Controls.Add(this.btn_KUsun);
            this.Controls.Add(this.btn_KDodaj);
            this.Controls.Add(this.dgv_klienci);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Klienci";
            this.Text = "Klienci";
            this.Load += new System.EventHandler(this.Klienci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klienci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_KModyfikuj;
        private System.Windows.Forms.Button btn_KUsun;
        private System.Windows.Forms.Button btn_KDodaj;
        public System.Windows.Forms.DataGridView dgv_klienci;
    }
}