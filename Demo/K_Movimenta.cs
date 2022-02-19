using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Model;
using Demo.BLL;
using System.Configuration;

namespace Demo
{
    public partial class K_Movimenta : Form
    {
        public K_Movimenta()
        {
            InitializeComponent();
        }

        private void K_Movimenta_Load(object sender, EventArgs e)
        {
            cbUbica.DataSource = Enum.GetValues(typeof(Ubica));
            btMovimenta.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NmQtamov_ValueChanged(object sender, EventArgs e)
        {
            btMovimenta.Enabled = NmQtamov.Value > 0;
        }
        private void NmQtamov_ValueChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btVersa_Click(object sender, EventArgs e)
        {
            string encConnection = ConfigurationManager.ConnectionStrings["DEMOWMNEntities"].ConnectionString;
            MovimentiBll movimentiBll = new MovimentiBll(encConnection);

            oMovimenta oMovimenta = new oMovimenta()
            {
                Tipo = txTipo.Text.Substring(0, 1),
                Ubica = cbUbica.Text,
                CodArt = txmCodArt.Text,
                QtaMov = NmQtamov.Value,
                CodUte = 1,
                commessa = "TEST"
            };
            var resp = movimentiBll.Movimenta(oMovimenta);
            if (resp )
            {
                _ = MessageBox.Show("Movimento registrato");
                this.Close();
            }


        }
    }
}
