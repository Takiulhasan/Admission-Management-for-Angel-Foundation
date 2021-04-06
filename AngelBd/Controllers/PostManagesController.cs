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
    public class PostManagesController : Controller
    {
        private PostManageDBContext db = new PostManageDBContext();

        // GET: PostManages
        public ActionResult Index()
        {
            return View(db.PostManages.ToList());
        }

        // GET: PostManages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostManage postManage = db.PostManages.Find(id);
            if (postManage == null)
            {
                return HttpNotFound();
            }
            return View(postManage);
        }

        // GET: PostManages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostManages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [ValidateInput(false)]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create( PostManage postManage)
        {
            if (ModelState.IsValid)
            {
                PostManage obj = new PostManage
                {
                    PostTitle = postManage.PostTitle,
                    PostContent = postManage.PostContent
                };
                db.PostManages.Add(postManage);
                db.SaveChanges();

                //return RedirectToAction("Index");
            }

            return View();
        }

        // GET: PostManages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostManage postManage = db.PostManages.Find(id);
            if (postManage == null)
            {
                return HttpNotFound();
            }
            return View(postManage);
        }

        // POST: PostManages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PostTitle,PostContent")] PostManage postManage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postManage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postManage);
        }

        // GET: PostManages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostManage postManage = db.PostManages.Find(id);
            if (postManage == null)
            {
                return HttpNotFound();
            }
            return View(postManage);
        }

        // POST: PostManages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostManage postManage = db.PostManages.Find(id);
            db.PostManages.Remove(postManage);
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
