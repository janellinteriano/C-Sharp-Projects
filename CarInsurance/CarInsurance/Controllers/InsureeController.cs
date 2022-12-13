using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {   
                insuree.Quote = Quote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        public static decimal Quote(Insuree insuree)
        {
            int userAge = DateTime.Now.Year - insuree.DateOfBirth.Year;
            // age if statement
            insuree.Quote = 50;
            if (userAge <= 18)
            {
                insuree.Quote += 100;
            }
            else if (userAge > 19 & userAge <= 25)
            {
                insuree.Quote += 50;
            }
            else if (userAge >= 26)
            {
                insuree.Quote += 25;
            }
            // car if statements
            if (insuree.CarYear < 2000)
            {
                insuree.Quote += 25;
            }
            else if (insuree.CarYear > 2015)
            {
                insuree.Quote += 25;
            }
            else if (insuree.CarMake == "Porsche")
            {
                insuree.Quote += 25;
            }
            else if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
            {
                insuree.Quote += 25;
            }
            if (insuree.SpeedingTickets > 0)
            {
                insuree.Quote += 10 * insuree.SpeedingTickets;  
            }
            if (insuree.DUI)
            {
                insuree.Quote *= Convert.ToDecimal(1.25);
            }
            if (insuree.CoverageType)
            {
                insuree.Quote *= Convert.ToDecimal(1.50);
            }
            return insuree.Quote;
        }

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var List = new List<Insuree>();
                foreach (var i in insurees)
                {
                    var insuree = new Insuree();
                    insuree.FirstName = i.FirstName;
                    insuree.LastName = i.LastName;
                    insuree.EmailAddress = i.EmailAddress;
                    insuree.Quote = i.Quote;
                    List.Add(i);
                }
                return View(List);
            }
        }
    }
}
