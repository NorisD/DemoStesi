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
            if (arcodart.Length != 0 && !esiste)
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

        public List<Articoli> ListArticoli()
        {
            List<Articoli> articolis = _DbModelEntities.Articoli.ToList();
            return articolis;
        }
        public Articoli GetArticoli(string codart)
        {
            var esiste = false;
            if (codart.Length != 0)
            {
                esiste = _DbModelEntities.Articoli.Any(e => e.ARCODART == codart);
            }
            if (esiste) { 
                var articolo = _DbModelEntities.Articoli.Where(e => e.ARCODART.Equals(codart))
                    .FirstOrDefault();
                return articolo;
            }
            else { 
                _ = MessageBox.Show("Articolo non esiste");
                return null;
            }
        }

    }
}
