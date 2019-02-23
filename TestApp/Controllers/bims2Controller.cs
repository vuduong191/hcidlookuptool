using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class bims2Controller : Controller
    {
        private hcid_lookupEntities db = new hcid_lookupEntities();

        // GET: bims2
        public ActionResult Index(string StreetAddress, string CityState)
        {
            return View(db.bims2.Where(x => x.Property_Address == StreetAddress).ToList());
        }

        // GET: bims2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bims2 bims2 = db.bims2.Find(id);
            if (bims2 == null)
            {
                return HttpNotFound();
            }
            return View(bims2);
        }

        // GET: bims2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: bims2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,StatementNum,StatementDate,APN,Property_Address,Property_City_State_Zip,RSO_Exemptions,SCEP_Exmpetions,IS_RSO,IS_SCEP,RSO_Invoice_Num,SCEP_Invoice_Num,Total_Units,RSO_Units_Billed,SCEP_Units_Billed,is_active,AddressMasterId")] bims2 bims2)
        {
            if (ModelState.IsValid)
            {
                db.bims2.Add(bims2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bims2);
        }

        // GET: bims2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bims2 bims2 = db.bims2.Find(id);
            if (bims2 == null)
            {
                return HttpNotFound();
            }
            return View(bims2);
        }

        // POST: bims2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,StatementNum,StatementDate,APN,Property_Address,Property_City_State_Zip,RSO_Exemptions,SCEP_Exmpetions,IS_RSO,IS_SCEP,RSO_Invoice_Num,SCEP_Invoice_Num,Total_Units,RSO_Units_Billed,SCEP_Units_Billed,is_active,AddressMasterId")] bims2 bims2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bims2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bims2);
        }

        // GET: bims2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bims2 bims2 = db.bims2.Find(id);
            if (bims2 == null)
            {
                return HttpNotFound();
            }
            return View(bims2);
        }

        // POST: bims2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bims2 bims2 = db.bims2.Find(id);
            db.bims2.Remove(bims2);
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
