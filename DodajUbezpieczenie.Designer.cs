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
            this.dgv_Dubezpieczenie = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_DUdata_do = new System.Windows.Forms.DateTimePicker();
            this.dtp_DUdata_od = new System.Windows.Forms.DateTimePicker();
            this.cbx_typ = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dubezpieczenie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Dubezpieczenie
            // 
            this.dgv_Dubezpieczenie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Dubezpieczenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dubezpieczenie.Location = new System.Drawing.Point(12, 12);
            this.dgv_Dubezpieczenie.Name = "dgv_Dubezpieczenie";
            this.dgv_Dubezpieczenie.Size = new System.Drawing.Size(776, 277);
            this.dgv_Dubezpieczenie.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
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
            // DodajUbezpieczenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_typ);
            this.Controls.Add(this.dtp_DUdata_od);
            this.Controls.Add(this.dtp_DUdata_do);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_Dubezpieczenie);
            this.Name = "DodajUbezpieczenie";
            this.Text = "DodajUbezpieczenie";
            this.Load += new System.EventHandler(this.DodajUbezpieczenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dubezpieczenie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Dubezpieczenie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_DUdata_do;
        private System.Windows.Forms.DateTimePicker dtp_DUdata_od;
        private System.Windows.Forms.ComboBox cbx_typ;
    }
}