using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo.Model;


namespace Demo.BLL
{
    public class MovimentiBll
    {
        // 1. declaro la variabile di connezione con il modello dei dati
        private DEMOWMNEntities _DbModelEntities;

        // 2. dichiaro costruttore
        public MovimentiBll(string @connectionString)
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
       public bool Movimenta(oMovimenta movimenta)
        {

            log_Operazioni operazione = new log_Operazioni()
            {
                MVCODART = movimenta.CodArt,
                MVCODUBI = movimenta.Ubica,
                MVCODUTE = movimenta.CodUte,
                MVTIPMOV = movimenta.Tipo,
                MVQTAMOV = (decimal)movimenta.QtaMov,
                MVDATMOV = DateTime.Now,
                MVCODCOM = movimenta.commessa


            };
            try
            {
                _DbModelEntities.log_Operazioni.Add(operazione);
                _DbModelEntities.SaveChanges();
                return true;
            }
            catch (Exception err)
            {
                _ = MessageBox.Show(err.Message);
                return false;
            }
        }


    }
    public class oMovimenta
    {
        public string Tipo { get; set; }
        public string Ubica { get; set; }
        public string CodArt { get; set; }
        public int CodUte { get; set; }
        public decimal? QtaMov { get; set; }
        public string commessa { get; set; }
    }
}
