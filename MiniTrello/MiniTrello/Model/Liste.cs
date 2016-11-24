using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello.Model
{
    public class Liste
    {
        public Guid Id { get; set; }
        public string Titre { get; set; }
        public List<Carte> Cartes { get; set; }
        public Liste()
        {
            Id = Guid.NewGuid();
        }
    }
}
