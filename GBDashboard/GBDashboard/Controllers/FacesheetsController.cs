using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GBDashboard;
using System.Web.UI;
using GBDashboard.Utils;
//using Amazon.S3;
//using Amazon.S3.Model;

namespace GBDashboard.Controllers
{
    [Authorize]
    public class FacesheetsController : Controller
    {
        private GBDashboardEntities db = new GBDashboardEntities();

        // GET: Facesheets
        [OutputCache(Duration = 1800, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult Index()
        {
            var facesheets = db.Facesheets.Include(f => f.Facesheet_Source1).Include(f => f.Facesheet_Status).Include(f => f.Insurance).Include(f => f.Location).Include(f => f.Payment_Type1).Include(f => f.Customer);
            return View(facesheets.ToList());
        }

        // GET: Facesheets/Details/5
        [OutputCache(Duration = 120, VaryByParam = "facesheetId, customerId")]
        public ActionResult Details(int? facesheetId, int? customerId)
        {
            if (facesheetId == null || customerId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facesheet facesheet = db.Facesheets.Find(facesheetId, customerId);
            if (facesheet == null)
            {
                return HttpNotFound();
            }
            return View(facesheet);
        }

        // GET: Facesheets/Create
        public ActionResult Create()
        {
            ViewBag.facesheet_source = new SelectList(db.Facesheet_Source, "facesheet_source1", "facesheet_source1");
            ViewBag.facesheet_status_name = new SelectList(db.Facesheet_Status, "facesheet_status_name", "facesheet_status_name");
            ViewBag.insurance_name = new SelectList(db.Insurances, "insurance_name", "insurance_name");
            ViewBag.location_name = new SelectList(db.Locations, "location_name", "location_name");
            ViewBag.payment_type = new SelectList(db.Payment_Type, "payment_type1", "payment_type1");
            ViewBag.customer_id = new SelectList(db.Customers, "customer_id", "customer_name");
            return View();
        }

        // POST: Facesheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "facesheet_id,customer_id,date_of_service,location_name,description,time_in,time_out,notes,patient,insurance_name,facesheet_status_name,payment_type,facesheet_source")] Facesheet facesheet)
        {
            if (ModelState.IsValid)
            {
                db.Facesheets.Add(facesheet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.facesheet_source = new SelectList(db.Facesheet_Source, "facesheet_source1", "facesheet_source1", facesheet.facesheet_source);
            ViewBag.facesheet_status_name = new SelectList(db.Facesheet_Status, "facesheet_status_name", "facesheet_status_name", facesheet.facesheet_status_name);
            ViewBag.insurance_name = new SelectList(db.Insurances, "insurance_name", "insurance_name", facesheet.insurance_name);
            ViewBag.location_name = new SelectList(db.Locations, "location_name", "location_name", facesheet.location_name);
            ViewBag.payment_type = new SelectList(db.Payment_Type, "payment_type1", "payment_type1", facesheet.payment_type);
            ViewBag.customer_id = new SelectList(db.Customers, "customer_id", "customer_name", facesheet.customer_id);
            return View(facesheet);
        }

        // GET: Facesheets/Edit/5
        public ActionResult Edit(int? facesheetId, int? customerId)
        {
            if (facesheetId == null || customerId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facesheet facesheet = db.Facesheets.Find(facesheetId, customerId);
            if (facesheet == null)
            {
                return HttpNotFound();
            }
            ViewBag.facesheet_source = new SelectList(db.Facesheet_Source, "facesheet_source1", "facesheet_source1", facesheet.facesheet_source);
            ViewBag.facesheet_status_name = new SelectList(db.Facesheet_Status, "facesheet_status_name", "facesheet_status_name", facesheet.facesheet_status_name);
            ViewBag.insurance_name = new SelectList(db.Insurances, "insurance_name", "insurance_name", facesheet.insurance_name);
            ViewBag.location_name = new SelectList(db.Locations, "location_name", "location_name", facesheet.location_name);
            ViewBag.payment_type = new SelectList(db.Payment_Type, "payment_type1", "payment_type1", facesheet.payment_type);
            ViewBag.customer_id = new SelectList(db.Customers, "customer_id", "customer_name", facesheet.customer_id);
            return View(facesheet);
        }

        // POST: Facesheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "facesheet_id,customer_id,date_of_service,location_name,description,time_in,time_out,notes,patient,insurance_name,facesheet_status_name,payment_type,facesheet_source")] Facesheet facesheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(facesheet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.facesheet_source = new SelectList(db.Facesheet_Source, "facesheet_source1", "facesheet_source1", facesheet.facesheet_source);
            ViewBag.facesheet_status_name = new SelectList(db.Facesheet_Status, "facesheet_status_name", "facesheet_status_name", facesheet.facesheet_status_name);
            ViewBag.insurance_name = new SelectList(db.Insurances, "insurance_name", "insurance_name", facesheet.insurance_name);
            ViewBag.location_name = new SelectList(db.Locations, "location_name", "location_name", facesheet.location_name);
            ViewBag.payment_type = new SelectList(db.Payment_Type, "payment_type1", "payment_type1", facesheet.payment_type);
            ViewBag.customer_id = new SelectList(db.Customers, "customer_id", "customer_name", facesheet.customer_id);
            return View(facesheet);
        }

        // GET: Facesheets/Delete/5
        [OutputCache(Duration = 120, VaryByParam = "facesheetId, customerId")]
        public ActionResult Delete(int? facesheetId, int? customerId)
        {
            if (facesheetId == null || customerId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Facesheet facesheet = db.Facesheets.Find(facesheetId, customerId);
            if (facesheet == null)
            {
                return HttpNotFound();
            }
            return View(facesheet);
        }

        // POST: Facesheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? facesheetId, int? customerId)
        {
            Facesheet facesheet = db.Facesheets.Find(facesheetId, customerId);
            db.Facesheets.Remove(facesheet);
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

        public ActionResult DownloadSupportImage(String path)
        {
            AmazonAWSS3Manager.DownloadFile(path, @"C:\\Temp");
            return Index();
        }
    }
}
