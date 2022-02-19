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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NmQtamov_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
