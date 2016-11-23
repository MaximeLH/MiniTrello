using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello
{
    class Liste
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public List<Carte> Cartes { get; set; }
    }
}
