using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

using Arthes.Data.Context;
using Arthes.Domain.Entities;

namespace Arthes.Web.Controllers
{
    public class RevistasController : Controller
    {
        private readonly Arthes2023Context db = new Arthes2023Context();

        // GET: Revistas
        public ActionResult Index()
        {
            return View(db.Revistas.ToList());
        }

        // GET: Revistas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revista revista = db.Revistas.Find(id);
            return revista == null ? HttpNotFound() : (ActionResult)View(revista);
        }

        // GET: Revistas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Revistas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tema,NumEdicao,MesEdicao,AnoEdicao")] Revista revista)
        {
            if (ModelState.IsValid)
            {
                _ = db.Revistas.Add(revista);
                _ = db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(revista);
        }

        // GET: Revistas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revista revista = db.Revistas.Find(id);
            return revista == null ? HttpNotFound() : (ActionResult)View(revista);
        }

        // POST: Revistas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tema,NumEdicao,MesEdicao,AnoEdicao")] Revista revista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(revista).State = EntityState.Modified;
                _ = db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(revista);
        }

        // GET: Revistas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revista revista = db.Revistas.Find(id);
            return revista == null ? HttpNotFound() : (ActionResult)View(revista);
        }

        // POST: Revistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Revista revista = db.Revistas.Find(id);
            _ = db.Revistas.Remove(revista);
            _ = db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
