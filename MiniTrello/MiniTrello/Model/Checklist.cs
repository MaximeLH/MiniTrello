using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello.Model
{
    class Checklist
    {
        public int Id { get; set; }
        public List<ElementChecklist> CheckL { get; set; }


    }
}
