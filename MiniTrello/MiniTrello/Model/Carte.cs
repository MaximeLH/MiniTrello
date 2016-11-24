using MiniTrello.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello
{
    class Carte
    {
        public Guid Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        List<Checklist> Checklists { get; set; }
        public void AjouterChecklist(Checklist c)
        {
            Checklists.Add(c);
        }
        public void SupprimerChecklist(Checklist c)
        {
            Checklists.Remove(c);
        }
    }
}
