namespace MiniTrello.Data
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MinitrelloDB : DbContext
    {
       
        public MinitrelloDB(): base("name=MinitrelloDB") { }

        public DbSet<Tableau> Tableaux { get; set; }
        public DbSet<Liste> Listes { get; set; }
        public DbSet<Carte> Cartes { get; set; }
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<ElementChecklist> EltChecklists { get; set; }

    }


}