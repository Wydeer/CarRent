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
            this.dgv_samochody = new System.Windows.Forms.DataGridView();
            this.btn_SDodaj = new System.Windows.Forms.Button();
            this.btn_SUsun = new System.Windows.Forms.Button();
            this.btn_SModyfikuj = new System.Windows.Forms.Button();
            this.btn_specyfikacja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_samochody)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_samochody
            // 
            this.dgv_samochody.AllowUserToAddRows = false;
            this.dgv_samochody.AllowUserToDeleteRows = false;
            this.dgv_samochody.AllowUserToResizeColumns = false;
            this.dgv_samochody.AllowUserToResizeRows = false;
            this.dgv_samochody.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_samochody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_samochody.Location = new System.Drawing.Point(12, 12);
            this.dgv_samochody.Name = "dgv_samochody";
            this.dgv_samochody.Size = new System.Drawing.Size(776, 426);
            this.dgv_samochody.TabIndex = 0;
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
            // Samochody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btn_specyfikacja);
            this.Controls.Add(this.btn_SModyfikuj);
            this.Controls.Add(this.btn_SUsun);
            this.Controls.Add(this.btn_SDodaj);
            this.Controls.Add(this.dgv_samochody);
            this.Name = "Samochody";
            this.Text = "Samochody";
            this.Load += new System.EventHandler(this.Samochody_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_samochody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_SDodaj;
        private System.Windows.Forms.Button btn_SUsun;
        private System.Windows.Forms.Button btn_SModyfikuj;
        public System.Windows.Forms.DataGridView dgv_samochody;
        private System.Windows.Forms.Button btn_specyfikacja;
    }
}