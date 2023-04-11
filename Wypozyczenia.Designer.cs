namespace Wypozyczalnia
{
    partial class Wypozyczenia
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
            this.dgv_Wypozyczenia = new System.Windows.Forms.DataGridView();
            this.btn_DodajWypo = new System.Windows.Forms.Button();
            this.btn_Zwrot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Wypozyczenia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Wypozyczenia
            // 
            this.dgv_Wypozyczenia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Wypozyczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Wypozyczenia.Location = new System.Drawing.Point(12, 12);
            this.dgv_Wypozyczenia.Name = "dgv_Wypozyczenia";
            this.dgv_Wypozyczenia.Size = new System.Drawing.Size(776, 325);
            this.dgv_Wypozyczenia.TabIndex = 0;
            // 
            // btn_DodajWypo
            // 
            this.btn_DodajWypo.Location = new System.Drawing.Point(12, 343);
            this.btn_DodajWypo.Name = "btn_DodajWypo";
            this.btn_DodajWypo.Size = new System.Drawing.Size(75, 23);
            this.btn_DodajWypo.TabIndex = 1;
            this.btn_DodajWypo.Text = "Dodaj";
            this.btn_DodajWypo.UseVisualStyleBackColor = true;
            this.btn_DodajWypo.Click += new System.EventHandler(this.btn_DodajWypo_Click);
            // 
            // btn_Zwrot
            // 
            this.btn_Zwrot.Location = new System.Drawing.Point(645, 343);
            this.btn_Zwrot.Name = "btn_Zwrot";
            this.btn_Zwrot.Size = new System.Drawing.Size(143, 23);
            this.btn_Zwrot.TabIndex = 2;
            this.btn_Zwrot.Text = "Oznacz jako zwrócone";
            this.btn_Zwrot.UseVisualStyleBackColor = true;
            this.btn_Zwrot.Click += new System.EventHandler(this.btn_Zwrot_Click);
            // 
            // Wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btn_Zwrot);
            this.Controls.Add(this.btn_DodajWypo);
            this.Controls.Add(this.dgv_Wypozyczenia);
            this.Name = "Wypozyczenia";
            this.Text = "Wyporzyczenia";
            this.Load += new System.EventHandler(this.Wypozyczenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Wypozyczenia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Wypozyczenia;
        private System.Windows.Forms.Button btn_DodajWypo;
        private System.Windows.Forms.Button btn_Zwrot;
    }
}