using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Flowerpower.Models;

namespace Flowerpower.Controllers
{
    public class KlantBestellingenController : Controller
    {
        private FlowerpowerEntities db = new FlowerpowerEntities();

        // GET: KlantBestellingen
        public ActionResult Index()
        {
            var klantid = from i in db.klant where i.email == User.Identity.Name select i.klantid;
            var bestelling = db.bestelling.Include(b => b.klant).Include(b => b.medewerkers).Include(b => b.winkel).Where(x => x.klant_klantid == klantid.FirstOrDefault());
            return View(bestelling.ToList());
        }


    }
}