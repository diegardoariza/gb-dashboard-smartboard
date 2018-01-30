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

namespace GBDashboard.Controllers
{
    [Authorize]
    public class AccountingRecordController : Controller
    {
        private GBDashboardEntities db = new GBDashboardEntities();

        // GET: AccountingRecord
        [OutputCache(Duration = 1800, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult Index()
        {
            var accounting_Record = db.Accounting_Record.Include(a => a.Customer).Include(a => a.Record_Category).Include(a => a.Record_Type);
            return View(accounting_Record.ToList());
        }

        // GET: AccountingRecord/Details/5
        [OutputCache(Duration = 120, VaryByParam = "accountingRecordId, customerId")]
        public ActionResult Details(int? accountingRecordId, int? customerId)
        {
            if (accountingRecordId == null || customerId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accounting_Record accounting_Record = db.Accounting_Record.Find(accountingRecordId, customerId);
            if (accounting_Record == null)
            {
                return HttpNotFound();
            }
            return View(accounting_Record);
        }

        // GET: AccountingRecord/Create
        public ActionResult Create()
        {
            ViewBag.customer_id = new SelectList(db.Customers, "customer_id", "customer_name");
            ViewBag.record_category_id = new SelectList(db.Record_Category, "record_category_id", "record_category_name");
            ViewBag.record_type_name = new SelectList(db.Record_Type, "record_type_name", "record_type_name");
            return View();
        }

        // POST: AccountingRecord/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "accounting_record_id,customer_id,record_date,amount,record_type_name,record_category_id,description")] Accounting_Record accounting_Record)
        {
            if (ModelState.IsValid)
            {
                db.Accounting_Record.Add(accounting_Record);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.customer_id = new SelectList(db.Customers, "customer_id", "customer_name", accounting_Record.customer_id);
            ViewBag.record_category_id = new SelectList(db.Record_Category, "record_category_id", "record_category_name", accounting_Record.record_category_id);
            ViewBag.record_type_name = new SelectList(db.Record_Type, "record_type_name", "record_type_name", accounting_Record.record_type_name);
            return View(accounting_Record);
        }

        // GET: AccountingRecord/Edit/5
        [OutputCache(Duration = 120, VaryByParam = "accountingRecordId, customerId")]
        public ActionResult Edit(int? accountingRecordId, int? customerId)
        {
            if (accountingRecordId == null || customerId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accounting_Record accounting_Record = db.Accounting_Record.Find(accountingRecordId, customerId);
            if (accounting_Record == null)
            {
                return HttpNotFound();
            }
            ViewBag.customer_id = new SelectList(db.Customers, "customer_id", "customer_name", accounting_Record.customer_id);
            ViewBag.record_category_id = new SelectList(db.Record_Category, "record_category_id", "record_category_name", accounting_Record.record_category_id);
            ViewBag.record_type_name = new SelectList(db.Record_Type, "record_type_name", "record_type_name", accounting_Record.record_type_name);
            return View(accounting_Record);
        }

        // POST: AccountingRecord/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "accounting_record_id,customer_id,record_date,amount,record_type_name,record_category_id,description")] Accounting_Record accounting_Record)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accounting_Record).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.customer_id = new SelectList(db.Customers, "customer_id", "customer_name", accounting_Record.customer_id);
            ViewBag.record_category_id = new SelectList(db.Record_Category, "record_category_id", "record_category_name", accounting_Record.record_category_id);
            ViewBag.record_type_name = new SelectList(db.Record_Type, "record_type_name", "record_type_name", accounting_Record.record_type_name);
            return View(accounting_Record);
        }

        // GET: AccountingRecord/Delete/5
        [OutputCache(Duration = 120, VaryByParam = "accountingRecordId, customerId")]
        public ActionResult Delete(int? accountingRecordId, int? customerId)
        {
            if (accountingRecordId == null || customerId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accounting_Record accounting_Record = db.Accounting_Record.Find(accountingRecordId, customerId);
            if (accounting_Record == null)
            {
                return HttpNotFound();
            }
            return View(accounting_Record);
        }

        // POST: AccountingRecord/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? accountingRecordId, int? customerId)
        {
            Accounting_Record accounting_Record = db.Accounting_Record.Find(accountingRecordId, customerId);
            db.Accounting_Record.Remove(accounting_Record);
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
