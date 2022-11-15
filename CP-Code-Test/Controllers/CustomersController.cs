using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CP_Code_Test.Models;

namespace CP_Code_Test.Controllers
{
    public class CustomersController : Controller
    {
        private CPTestDBEntities db = new CPTestDBEntities();

        // GET: Customers
        public async Task<ActionResult> Index()
        {
            return View(await db.Customers.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerInfo customerInfo = await db.Customers.FindAsync(id);
            if (customerInfo == null)
            {
                return HttpNotFound();
            }
            return View(customerInfo);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CustomerId,ConsultantId,FirstName,LastName,Address,Gender,DOB,MobileNo,EmailAddress")] CustomerInfo customerInfo)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customerInfo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(customerInfo);
        }

        // GET: Customers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerInfo customerInfo = await db.Customers.FindAsync(id);
            if (customerInfo == null)
            {
                return HttpNotFound();
            }
            return View(customerInfo);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CustomerId,ConsultantId,FirstName,LastName,Address,Gender,DOB,MobileNo,EmailAddress")] CustomerInfo customerInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerInfo).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(customerInfo);
        }

        // GET: Customers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerInfo customerInfo = await db.Customers.FindAsync(id);
            if (customerInfo == null)
            {
                return HttpNotFound();
            }
            return View(customerInfo);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CustomerInfo customerInfo = await db.Customers.FindAsync(id);
            db.Customers.Remove(customerInfo);
            await db.SaveChangesAsync();
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
