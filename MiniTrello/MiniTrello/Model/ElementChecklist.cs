using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello.Model
{
    public class ElementChecklist
    {
        public Guid Id { get; set; }
        public string TextElt { get; set; }
        public bool Etat { get; set; }
        public ElementChecklist()
        {
            Id = Guid.NewGuid();
        }
    }
}
