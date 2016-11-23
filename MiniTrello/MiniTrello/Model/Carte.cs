using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello
{
    class Carte
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        //TO DO Retirer le commentaire lorsque la classe checklist sera créée public List<Checklist> Checklists { get; set; }
    }
}
