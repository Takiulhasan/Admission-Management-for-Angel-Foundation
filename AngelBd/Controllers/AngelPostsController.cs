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
    public class AngelPostsController : Controller
    {
        private AngelPostDBContext db = new AngelPostDBContext();

        // GET: AngelPosts
        public ActionResult Index()
        {
            return View(db.AngelPosts.ToList());
        }

        // GET: AngelPosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AngelPost angelPost = db.AngelPosts.Find(id);
            if (angelPost == null)
            {
                return HttpNotFound();
            }
            return View(angelPost);
        }

        // GET: AngelPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AngelPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Image,Post")] AngelPost angelPost)
        {
            if (ModelState.IsValid)
            {
                db.AngelPosts.Add(angelPost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(angelPost);
        }

        // GET: AngelPosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AngelPost angelPost = db.AngelPosts.Find(id);
            if (angelPost == null)
            {
                return HttpNotFound();
            }
            return View(angelPost);
        }

        // POST: AngelPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Image,Post")] AngelPost angelPost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(angelPost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(angelPost);
        }

        // GET: AngelPosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AngelPost angelPost = db.AngelPosts.Find(id);
            if (angelPost == null)
            {
                return HttpNotFound();
            }
            return View(angelPost);
        }

        // POST: AngelPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AngelPost angelPost = db.AngelPosts.Find(id);
            db.AngelPosts.Remove(angelPost);
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
