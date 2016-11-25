using MiniTrello.Data;
using MiniTrello.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace MiniTrello.Data
{
    public class MinitrelloInitializer : DropCreateDatabaseIfModelChanges<MinitrelloDB>
    {
        public object HttpRuntime { get; private set; }

        //private byte[] GetFileBytes(string path)
        //{
        //    FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
        //    byte[] fileBytes;
        //    using (BinaryReader br = new BinaryReader(fileOnDisk))
        //    {
        //        fileBytes = br.ReadBytes((int)fileOnDisk.Length);
        //    }
        //    return fileBytes;
        //}

        protected override void Seed(MinitrelloDB ctx)
        {
            base.Seed(ctx);
            //{
            //    Tableau t = new Tableau {Titre="Premier Tableau !"};
            //    Liste l = new Liste {Titre="Liste l"};
            //    Carte c = new Carte { Titre = "Carte c1", Description="première carte créée" };
            //    Checklist ch = new Checklist { };
            //    ElementChecklist e = new ElementChecklist { Etat=true,TextElt="element de checklist n°1" };

            //    ch.CheckL = new List<ElementChecklist>();
            //    ch.CheckL.Add(e);
            //    c.Checklists = new List<Checklist>();
            //    c.Checklists.Add(ch);
            //    l.Cartes = new List<Carte>();
            //    l.Cartes.Add(c);
            //    t.Listes = new List<Liste>();
            //    t.Listes.Add(l);
            //    ctx.Tableaux.Add(t);
            //    ctx.SaveChanges();

            }



        }
    }
}