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
    public class ConsultantsController : Controller
    {
        private CPTestDBEntities db = new CPTestDBEntities();

        // GET: Consultants
        public async Task<ActionResult> Index()
        {
            return View(await db.Consultants.ToListAsync());
        }

        // GET: Consultants/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultantInfo consultantInfo = await db.Consultants.FindAsync(id);
            if (consultantInfo == null)
            {
                return HttpNotFound();
            }
            return View(consultantInfo);
        }

        // GET: Consultants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consultants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ConsultantInfoId,FirstName,LastName,EmailAddress,MobileNo")] ConsultantInfo consultantInfo)
        {
            if (ModelState.IsValid)
            {
                db.Consultants.Add(consultantInfo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(consultantInfo);
        }

        // GET: Consultants/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultantInfo consultantInfo = await db.Consultants.FindAsync(id);
            if (consultantInfo == null)
            {
                return HttpNotFound();
            }
            return View(consultantInfo);
        }

        // POST: Consultants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ConsultantInfoId,FirstName,LastName,EmailAddress,MobileNo")] ConsultantInfo consultantInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultantInfo).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(consultantInfo);
        }

        // GET: Consultants/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultantInfo consultantInfo = await db.Consultants.FindAsync(id);
            if (consultantInfo == null)
            {
                return HttpNotFound();
            }
            return View(consultantInfo);
        }

        // POST: Consultants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ConsultantInfo consultantInfo = await db.Consultants.FindAsync(id);
            db.Consultants.Remove(consultantInfo);
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
