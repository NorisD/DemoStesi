﻿namespace Demo
{
    partial class A_articoli
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNewArt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txCodArt = new System.Windows.Forms.TextBox();
            this.txDesArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ZoomArt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomArt)).BeginInit();
            this.SuspendLayout();
            // 
            // btNewArt
            // 
            this.btNewArt.Location = new System.Drawing.Point(607, 40);
            this.btNewArt.Name = "btNewArt";
            this.btNewArt.Size = new System.Drawing.Size(75, 23);
            this.btNewArt.TabIndex = 0;
            this.btNewArt.Text = "Salva";
            this.btNewArt.UseVisualStyleBackColor = true;
            this.btNewArt.Click += new System.EventHandler(this.btNewArt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codice";
            // 
            // txCodArt
            // 
            this.txCodArt.Location = new System.Drawing.Point(28, 43);
            this.txCodArt.MaxLength = 40;
            this.txCodArt.Name = "txCodArt";
            this.txCodArt.Size = new System.Drawing.Size(119, 20);
            this.txCodArt.TabIndex = 2;
            // 
            // txDesArt
            // 
            this.txDesArt.Location = new System.Drawing.Point(177, 43);
            this.txDesArt.MaxLength = 100;
            this.txDesArt.Name = "txDesArt";
            this.txDesArt.Size = new System.Drawing.Size(406, 20);
            this.txDesArt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrizione";
            // 
            // ZoomArt
            // 
            this.ZoomArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZoomArt.Location = new System.Drawing.Point(28, 86);
            this.ZoomArt.Name = "ZoomArt";
            this.ZoomArt.Size = new System.Drawing.Size(555, 318);
            this.ZoomArt.TabIndex = 5;
            this.ZoomArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ZoomArt_CellContentClick);
            // 
            // A_articoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 432);
            this.Controls.Add(this.ZoomArt);
            this.Controls.Add(this.txDesArt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txCodArt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNewArt);
            this.Name = "A_articoli";
            this.Text = "Anagrafica articoli";
            this.Load += new System.EventHandler(this.A_articoli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZoomArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txCodArt;
        private System.Windows.Forms.TextBox txDesArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ZoomArt;
    }
}

