using MiniTrello.Data;
using MiniTrello.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTrello.Business {
   public class MainController {

        public MinitrelloDB ctx;

        #region "Singleton"
        /// <summary>
        /// https://fr.wikipedia.org/wiki/Singleton_(patron_de_conception)
        /// </summary>
        private static MainController _instance;
        public static MainController instance {
            get {
                if (_instance == null) {
                    _instance = new MainController();
                }

                return _instance;
            }
        }

        public DbQuery<Liste> Listes { get {
                return ctx.Listes.Include("Cartes");
            }
        }
        #endregion


        private MainController() {
            ctx = new MinitrelloDB();
        }

        public void AjouterCarteALaListe(Carte c, Liste l) {

            //ctx.Cartes.Add(c);
            //Liste l2 = ctx.Listes.Include("Cartes").Single(x => x.Id == l.Id);
            l.Cartes.Add(c);

            ctx.SaveChanges();
        }

        public void MettreAjourCarte() {
            ctx.SaveChanges();
        }

        public void ResetDB() {

            foreach (var item in ctx.Tableaux) {
                ctx.Tableaux.Remove(item);
            }
            foreach (var item in ctx.Listes) {
                ctx.Listes.Remove(item);
            }
            foreach (var item in ctx.Cartes) {
                ctx.Cartes.Remove(item);
            }
            foreach (var item in ctx.Checklists) {
                ctx.Checklists.Remove(item);
            }
            foreach (var item in ctx.EltChecklists) {
                ctx.EltChecklists.Remove(item);
            }

            ctx.SaveChanges();

            Tableau t = new Tableau { Titre = "Tableau de test " };

            Liste l = new Liste { Titre = "Liste n°1" };
            Liste m = new Liste { Titre = "Liste n°2" };

            Carte c = new Carte { Titre = "Carte a", Description = "première carte créée" };
            Carte d = new Carte { Titre = "Carte b", Description = "deuxième carte créée" };

            Checklist ch = new Checklist { };
            Checklist ci = new Checklist { };

            ElementChecklist v = new ElementChecklist { Etat = true, TextElt = "Element de checklist n°1" };
            ElementChecklist g = new ElementChecklist { Etat = false, TextElt = "Element de checklist n°2" };

            ch.CheckL = new List<ElementChecklist>();
            ch.CheckL.Add(v);
            ci.CheckL = new List<ElementChecklist>();
            ci.CheckL.Add(g);

            c.Checklists = new List<Checklist>();
            c.Checklists.Add(ch);

            d.Checklists = new List<Checklist>();
            d.Checklists.Add(ci);


            l.Cartes = new List<Carte>();
            l.Cartes.Add(c);
            m.Cartes = new List<Carte>();
            m.Cartes.Add(d);

            t.Listes = new List<Liste>();
            t.Listes.Add(l);
            t.Listes.Add(m);

            ctx.Tableaux.Add(t);

            ctx.SaveChanges();
        }
    }
}
