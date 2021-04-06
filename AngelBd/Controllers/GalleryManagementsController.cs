using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AngelBd.Models;


namespace AngelBd.Controllers
{
    public class GalleryManagementsController : Controller
    {
        private GalleryManagementDBContext db = new GalleryManagementDBContext();

        public ActionResult Index()
        {
            if (User.IsInRole("admin"))
            {
                return View(db.GalleryManagements.ToList());

            }
            else
                return View();
        }

        // GET: GalleryManagements/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    GalleryManagement galleryManagement = db.GalleryManagements.Find(id);
        //    if (galleryManagement == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(galleryManagement);
        //}

        // GET: GalleryManagements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GalleryManagements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GalleryManagement imageModel)
        {
            string fileName = Path.GetFileNameWithoutExtension(imageModel.ImageFile.FileName);
            string extension = Path.GetExtension(imageModel.ImageFile.FileName);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            imageModel.Photo = "~/Uploads/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Uploads/"), fileName);
            imageModel.ImageFile.SaveAs(fileName);


            //using (GalleryManagementDBContext db = new GalleryManagementDBContext())
            //{
            if (ModelState.IsValid)
            {
                db.GalleryManagements.Add(imageModel); 
                db.SaveChanges();
                ModelState.Clear();

                //}
            }
            return RedirectToAction("Index");


        }

            
        [HttpGet]
        public ActionResult View(int Id)  
        {
            GalleryManagement galleryModel = new GalleryManagement();

            galleryModel = db.GalleryManagements.Where(x=>x.ID==Id).FirstOrDefault();
            return View(galleryModel); 
        }
        // POST: GalleryManagements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Photo")] GalleryManagement galleryManagement)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(galleryManagement).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(galleryManagement);
        //}

        // GET: GalleryManagements/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    GalleryManagement galleryManagement = db.GalleryManagements.Find(id);
        //    if (galleryManagement == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(galleryManagement);
        //}

        //// POST: GalleryManagements/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    GalleryManagement galleryManagement = db.GalleryManagements.Find(id);
        //    db.GalleryManagements.Remove(galleryManagement);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
