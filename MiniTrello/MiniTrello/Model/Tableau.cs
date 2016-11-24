using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello.Model
{
    public class Tableau
    {
        public Guid Id { get; set; }
        public string Titre { get; set; }
        public List<Liste> Listes { get; set; }
        public Tableau() {
            Id = Guid.NewGuid();
        }

    }
}
