using MiniTrello.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello.Model
{
    public class Carte
    {
        public Guid Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public List<Checklist> Checklists { get; set; }
        public Carte()
        {
            Id = Guid.NewGuid();
        }

    }
}
