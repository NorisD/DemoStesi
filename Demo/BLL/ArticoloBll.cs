using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Model;

namespace Demo.BLL
{
    public class ArticoloBll
    {
        // 1. declaro la variabile di connezione con il modello dei dati
        private DEMOWMNEntities _DbModelEntities;
        // 2. dichiaro costruttore
        public ArticoloBll(string @connectionString)
        {
            // 2.1. istanzo
            try
            {
                _DbModelEntities = new DEMOWMNEntities(@connectionString);
            }
            catch (Exception err)
            {
                _ = MessageBox.Show(err.Message);
            }
        }
        // 3.Metodi di servizio
        public bool NewArticolo(Articoli articolo)
        {
            var arcodart = articolo.ARCODART;
            var esiste = false;

            if (arcodart.Length != 0)
            {
                esiste = _DbModelEntities.Articoli.Any(e => e.ARCODART == arcodart);
            }
            if (esiste)
            {
                _DbModelEntities.Articoli.Add(articolo);
                _DbModelEntities.SaveChanges();
                return true;
            }
            else
            {
                if (esiste)
                {
                    _ = MessageBox.Show("Articolo esistente");
                }
                return false;
            }



        }
        public Articoli GetArticolo(string CodArt)
        {
            Articoli oArticolo = new Articoli();

            var esiste = false;
            if (CodArt.Length != 0)
            {
                oArticolo = _DbModelEntities.Articoli.FirstOrDefault(a => a.ARCODART.Equals(CodArt));
            }
            return oArticolo;
        }
        public List<Articoli> ListArticoli()
        {
            List<Articoli> articolis = _DbModelEntities.Articoli.ToList();
            return articolis;
        }


    }
}
