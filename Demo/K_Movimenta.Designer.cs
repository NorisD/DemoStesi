namespace Demo
{
    partial class K_Movimenta
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
            this.txmCodArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txmDesArt = new System.Windows.Forms.TextBox();
            this.cbUbica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NmQtamov = new System.Windows.Forms.NumericUpDown();
            this.txTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btMovimenta = new System.Windows.Forms.Button();
            this.btEsci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NmQtamov)).BeginInit();
            this.SuspendLayout();
            // 
            // txmCodArt
            // 
            this.txmCodArt.Location = new System.Drawing.Point(74, 30);
            this.txmCodArt.MaxLength = 40;
            this.txmCodArt.Name = "txmCodArt";
            this.txmCodArt.ReadOnly = true;
            this.txmCodArt.Size = new System.Drawing.Size(120, 20);
            this.txmCodArt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Articolo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txmDesArt
            // 
            this.txmDesArt.Location = new System.Drawing.Point(197, 32);
            this.txmDesArt.MaxLength = 100;
            this.txmDesArt.Name = "txmDesArt";
            this.txmDesArt.ReadOnly = true;
            this.txmDesArt.Size = new System.Drawing.Size(315, 20);
            this.txmDesArt.TabIndex = 5;
            // 
            // cbUbica
            // 
            this.cbUbica.FormattingEnabled = true;
            this.cbUbica.Location = new System.Drawing.Point(74, 56);
            this.cbUbica.Name = "cbUbica";
            this.cbUbica.Size = new System.Drawing.Size(120, 21);
            this.cbUbica.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ubicazione";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Q.ta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // NmQtamov
            // 
            this.NmQtamov.DecimalPlaces = 2;
            this.NmQtamov.ForeColor = System.Drawing.SystemColors.WindowText;
            this.NmQtamov.Location = new System.Drawing.Point(238, 58);
            this.NmQtamov.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NmQtamov.Name = "NmQtamov";
            this.NmQtamov.Size = new System.Drawing.Size(120, 20);
            this.NmQtamov.TabIndex = 10;
            this.NmQtamov.ThousandsSeparator = true;
            this.NmQtamov.ValueChanged += new System.EventHandler(this.NmQtamov_ValueChanged);
            // 
            // txTipo
            // 
            this.txTipo.Location = new System.Drawing.Point(74, 4);
            this.txTipo.MaxLength = 40;
            this.txTipo.Name = "txTipo";
            this.txTipo.ReadOnly = true;
            this.txTipo.Size = new System.Drawing.Size(120, 20);
            this.txTipo.TabIndex = 11;
            this.txTipo.TextChanged += new System.EventHandler(this.txTipo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btMovimenta
            // 
            this.btMovimenta.Location = new System.Drawing.Point(437, 60);
            this.btMovimenta.Name = "btMovimenta";
            this.btMovimenta.Size = new System.Drawing.Size(75, 23);
            this.btMovimenta.TabIndex = 13;
            this.btMovimenta.Text = "Versa";
            this.btMovimenta.UseVisualStyleBackColor = true;
            this.btMovimenta.Click += new System.EventHandler(this.btVersa_Click);
            this.btMovimenta.Enter += new System.EventHandler(this.NmQtamov_ValueChanged);
            // 
            // btEsci
            // 
            this.btEsci.Location = new System.Drawing.Point(437, 89);
            this.btEsci.Name = "btEsci";
            this.btEsci.Size = new System.Drawing.Size(75, 23);
            this.btEsci.TabIndex = 14;
            this.btEsci.Text = "Esci";
            this.btEsci.UseVisualStyleBackColor = true;
            this.btEsci.Click += new System.EventHandler(this.btEsci_Click);
            // 
            // K_Movimenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 115);
            this.Controls.Add(this.btEsci);
            this.Controls.Add(this.btMovimenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txTipo);
            this.Controls.Add(this.NmQtamov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUbica);
            this.Controls.Add(this.txmDesArt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txmCodArt);
            this.Name = "K_Movimenta";
            this.Text = "Movimenta";
            this.Load += new System.EventHandler(this.K_Movimenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NmQtamov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUbica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NmQtamov;
        public System.Windows.Forms.TextBox txmCodArt;
        public System.Windows.Forms.TextBox txmDesArt;
        public System.Windows.Forms.TextBox txTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btEsci;
        public System.Windows.Forms.Button btMovimenta;
    }
}