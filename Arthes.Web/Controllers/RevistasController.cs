using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

using Arthes.Data.Context;
using Arthes.Domain.DTO;
using Arthes.Domain.Entities;
using Arthes.Domain.Mappers;
using Arthes.Web.Validators;

using FluentValidation.Results;

namespace Arthes.Web.Controllers
{
    public class RevistasController : Controller
    {
        private readonly Arthes2023Context db = new Arthes2023Context();

        public ActionResult Index()
        {
            IEnumerable<RevistaDTO> listaRevistaDTO = RevistaMapper.EntidadeParaDTO(db.Revistas.ToList());
            return View("Index", listaRevistaDTO);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revista revista = db.Revistas.Find(id);
            return revista == null ? HttpNotFound() : (ActionResult)View(revista);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tema,NumEdicao,MesEdicao,AnoEdicao,DataCadastro")] RevistaDTO revistaDTO)
        {
            RevistaValidator rv = new RevistaValidator();
            ValidationResult result = rv.Validate(revistaDTO);

            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in result.Errors)
                {
                    ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
                }
            }

            Revista revista = RevistaMapper.UmDTOParaUmaEntidade(revistaDTO);

            if (ModelState.IsValid)
            {
                _ = db.Revistas.Add(revista);
                _ = db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(revistaDTO);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revista revista = db.Revistas.Find(id);
            return revista == null ? HttpNotFound() : (ActionResult)View(revista);
        }

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

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revista revista = db.Revistas.Find(id);
            return revista == null ? HttpNotFound() : (ActionResult)View(revista);
        }

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
