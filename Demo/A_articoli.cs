using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using Demo.BLL;
using Demo.Model;


namespace Demo
{
    public partial class A_articoli : Form
    {
        public A_articoli()
        {
            InitializeComponent();
        }

        private void A_articoli_Load(object sender, EventArgs e)
        {
            string encConnection = ConfigurationManager.ConnectionStrings["DEMOWMNEntities"].ConnectionString;
            ArticoloBll articolibill = new ArticoloBll(encConnection);
            ZoomArt.DataSource = articolibill.ListArticoli()
                .Select(a => new
                {
                    Codice = a.ARCODART,
                    Descrizione = a.ARDESART
                }).ToList();

        }

        private void btNewArt_Click(object sender, EventArgs e)
        {
            string encConnection = ConfigurationManager.ConnectionStrings["DEMOWMNEntities"].ConnectionString;
            ArticoloBll articolibill = new ArticoloBll(encConnection);

            Articoli articolo = new Articoli()
            {
                ARCODART = txCodArt.Text,
                ARDESART = txDesArt.Text,
            };
            var resp = articolibill.NewArticolo(articolo);
            if (resp)
            {
                txDesArt.Text = "";
                txCodArt2.Text = txCodArt.Text;
                txCodArt.Text = "";
                ZoomArt.DataSource = articolibill.ListArticoli()
                    .Select(a => new
                    {
                        Codice = a.ARCODART,
                        Descrizione = a.ARDESART
                    }).ToList(); 
            }

        }

        private void ZoomArt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = ZoomArt.SelectedCells[0].RowIndex;
            txCodArt2.Text = ZoomArt.Rows[irow].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string encConnection = ConfigurationManager.ConnectionStrings["DEMOWMNEntities"].ConnectionString;
            ArticoloBll articolibill = new ArticoloBll(encConnection);

            K_Movimenta fmovimenta = new K_Movimenta();
            fmovimenta.txmCodArt.Text = txCodArt2.Text;
            fmovimenta.txTipo.Text = "Versamento";
            fmovimenta.txmDesArt.Text = articolibill.GetArticolo(txCodArt2.Text).ARDESART;
            fmovimenta.btMovimenta.Text = "Versa";
            fmovimenta.Text = "Versamento";
            fmovimenta.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ZoomArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string encConnection = ConfigurationManager.ConnectionStrings["DEMOWMNEntities"].ConnectionString;
            ArticoloBll articolibill = new ArticoloBll(encConnection);

            K_Movimenta fmovimenta = new K_Movimenta();
            fmovimenta.txmCodArt.Text = txCodArt2.Text;
            fmovimenta.txTipo.Text = "Preleva";
            fmovimenta.txmDesArt.Text = articolibill.GetArticolo(txCodArt2.Text).ARDESART;
            fmovimenta.btMovimenta.Text = "Preleva";
            fmovimenta.Text = "Preleva";
            fmovimenta.Show();
        }
    }
}
