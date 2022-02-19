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
                txCodArt.Text = "";
                ZoomArt.DataSource = articolibill.ListArticoli()
                    .Select(a => new
                    {
                        Codice = a.ARCODART,
                        Descrizione = a.ARDESART
                    }).ToList(); ;
            }

        }

        private void ZoomArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
