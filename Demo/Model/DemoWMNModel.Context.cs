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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DEMOWMNEntities : DbContext
    {
        public DEMOWMNEntities()
            : base("name=DEMOWMNEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Articoli> Articoli { get; set; }
        public virtual DbSet<Com_essa> Com_essa { get; set; }
        public virtual DbSet<Saldiarti> Saldiarti { get; set; }
        public virtual DbSet<Utenti> Utenti { get; set; }
        public virtual DbSet<log_Operazioni> log_Operazioni { get; set; }
    }
}
