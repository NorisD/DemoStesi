//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Saldiarti
    {
        public string SLCODART { get; set; }
        public string SLCODUB { get; set; }
        public Nullable<decimal> SLQTAUBI { get; set; }
        public Nullable<int> Age { get; set; }
    
        public virtual Articoli Articoli { get; set; }
    }
}
