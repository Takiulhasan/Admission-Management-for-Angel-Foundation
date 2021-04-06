using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AngelBd.Models;

namespace AngelBd.Controllers
{
    public class PostManagerModelsController : Controller
    {
        private PostManagerDBContext db = new PostManagerDBContext();

        // GET: PostManagerModels
        public ActionResult Index()
        {
            return View(db.PostManagers.ToList());
        }

        // GET: PostManagerModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostManagerModel postManagerModel = db.PostManagers.Find(id);
            if (postManagerModel == null)
            {
                return HttpNotFound();
            }
            return View(postManagerModel);
        }

        // GET: PostManagerModels/Create
        [Authorize(Roles = "admin")]

        public ActionResult Create()
        {
            return View();
        }

        // POST: PostManagerModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PostTitle,PostContent")] PostManagerModel postManagerModel)
        {
            if (ModelState.IsValid)
            {
                db.PostManagers.Add(postManagerModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(postManagerModel);
        }

        // GET: PostManagerModels/Edit/5
        [Authorize(Roles = "admin")]

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostManagerModel postManagerModel = db.PostManagers.Find(id);
            if (postManagerModel == null)
            {
                return HttpNotFound();
            }
            return View(postManagerModel);
        }

        // POST: PostManagerModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PostTitle,PostContent")] PostManagerModel postManagerModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postManagerModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postManagerModel);
        }

        // GET: PostManagerModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostManagerModel postManagerModel = db.PostManagers.Find(id);
            if (postManagerModel == null)
            {
                return HttpNotFound();
            }
            return View(postManagerModel);
        }

        // POST: PostManagerModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostManagerModel postManagerModel = db.PostManagers.Find(id);
            db.PostManagers.Remove(postManagerModel);
            db.SaveChanges();
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
