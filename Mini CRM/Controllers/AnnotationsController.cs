using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Mini_CRM.DAL;
using Mini_CRM.Models;

namespace Mini_CRM.Controllers
{
    public class AnnotationsController : Controller
    {
        private CRMContext db = new CRMContext();

        // GET: Annotations
        public ActionResult Index()
        {
            return View(db.Annotations.ToList());
        }

        // GET: Annotations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annotation annotation = db.Annotations.Find(id);
            if (annotation == null)
            {
                return HttpNotFound();
            }
            return View(annotation);
        }

        // GET: Annotations/Create
        public ActionResult Create(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            Annotation a = new Annotation();
            a.Date = new DateTime(2017,04,04);
            a.ContactId = (int)id;
            return View(a);
        }

        // POST: Annotations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,Description,ContactId")] Annotation annotation)
        {
            if (ModelState.IsValid)
            {
                db.Annotations.Add(annotation);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return RedirectToAction("Index", "Contacts");
            }

            return View(annotation);
        }

        // GET: Annotations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annotation annotation = db.Annotations.Find(id);
            if (annotation == null)
            {
                return HttpNotFound();
            }
            return View(annotation);
        }

        // POST: Annotations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,Description,ContactId")] Annotation annotation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(annotation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index","Contacts");
            }
            return View(annotation);
        }

        // GET: Annotations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Annotation annotation = db.Annotations.Find(id);
            if (annotation == null)
            {
                return HttpNotFound();
            }
            return View(annotation);
        }

        // POST: Annotations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Annotation annotation = db.Annotations.Find(id);
            db.Annotations.Remove(annotation);
            db.SaveChanges();
            return RedirectToAction("Index","Contacts");
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
