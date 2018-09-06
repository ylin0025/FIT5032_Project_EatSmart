using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FIT5032_Project_EatSmart.Models;

namespace FIT5032_Project_EatSmart.Controllers
{
    public class FoodNutritionsController : Controller
    {
        private FoodNutritionModdels db = new FoodNutritionModdels();

        // GET: FoodNutritions
        public ActionResult Index()
        {
            return View(db.FoodNutritions.ToList());
        }

        // GET: FoodNutritions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodNutrition foodNutrition = db.FoodNutritions.Find(id);
            if (foodNutrition == null)
            {
                return HttpNotFound();
            }
            return View(foodNutrition);
        }

        // GET: FoodNutritions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodNutritions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FoodName,Energy,Protein,TotalFat,Carbohydrates,TotalSugars,Calcium,Sodium,SaturatedFat")] FoodNutrition foodNutrition)
        {
            if (ModelState.IsValid)
            {
                db.FoodNutritions.Add(foodNutrition);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(foodNutrition);
        }

        // GET: FoodNutritions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodNutrition foodNutrition = db.FoodNutritions.Find(id);
            if (foodNutrition == null)
            {
                return HttpNotFound();
            }
            return View(foodNutrition);
        }

        // POST: FoodNutritions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FoodName,Energy,Protein,TotalFat,Carbohydrates,TotalSugars,Calcium,Sodium,SaturatedFat")] FoodNutrition foodNutrition)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodNutrition).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(foodNutrition);
        }

        // GET: FoodNutritions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodNutrition foodNutrition = db.FoodNutritions.Find(id);
            if (foodNutrition == null)
            {
                return HttpNotFound();
            }
            return View(foodNutrition);
        }

        // POST: FoodNutritions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodNutrition foodNutrition = db.FoodNutritions.Find(id);
            db.FoodNutritions.Remove(foodNutrition);
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
