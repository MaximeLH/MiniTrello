using MiniTrello.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello.Model
{
    /// <summary>
    /// Une superbe carte
    /// Trop la classe
    /// </summary>
    public class Carte
    {
        /// <summary>
        /// Id auto generee de la carte
        /// </summary>
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
