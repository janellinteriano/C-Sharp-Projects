﻿using System;
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
                insuree.Quote = Quote(insuree.DateOfBirth, insuree.CarYear, insuree.CarMake, insuree.CarModel, insuree.DUI, insuree.SpeedingTickets, insuree.CoverageType, insuree.Quote);
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

        public static decimal Quote(DateTime DateOfBirth, int CarYear, string CarMake, string CarModel, bool DUI, int SpeedingTickets, bool CoverageType, decimal Quote)
        {
            int userAge = DateTime.Now.Year - DateOfBirth.Year;
            DUI = false;
            CoverageType = false;

            // age if statement
            Quote = 50;
            if (userAge <= 18)
            {
                Quote += 100;
            }
            else if (userAge > 19 & userAge <= 25)
            {
                Quote += 50;
            }
            else if (userAge >= 26)
            {
                Quote += 25;
            }
            // car if statements
            if (CarYear < 2000)
            {
                Quote += 25;
            }
            else if (CarYear > 2015)
            {
                Quote += 25;
            }
            else if (CarMake == "Porsche")
            {
                Quote += 25;
            }
            else if (CarMake == "Porsche" & CarModel == "911 Carrera")
            {
                Quote += 25;
            }
            if (SpeedingTickets > 0)
            {
                Quote = 10 * SpeedingTickets;  
            }
            if (DUI == true)
            {
                Quote = Quote * Convert.ToDecimal(1.25);
            }
            if (CoverageType == true)
            {
                Quote = Quote * Convert.ToDecimal(1.50);
            }
            return Quote;
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
