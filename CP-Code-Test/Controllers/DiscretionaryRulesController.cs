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
    public class DiscretionaryRulesController : Controller
    {
        private CPTestDBEntities db = new CPTestDBEntities();

        // GET: DiscretionaryRules
        public async Task<ActionResult> Index()
        {
            return View(await db.DiscretionaryRules.ToListAsync());
        }

        // GET: DiscretionaryRules/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiscretionaryRule discretionaryRule = await db.DiscretionaryRules.FindAsync(id);
            if (discretionaryRule == null)
            {
                return HttpNotFound();
            }
            return View(discretionaryRule);
        }

        // GET: DiscretionaryRules/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiscretionaryRules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DiscretionaryRuleID,ConsultantID,CustomerID,Rules,CustomerBuy,CustomerSell,ConsultantBuy,ConsultantSell")] DiscretionaryRule discretionaryRule)
        {
            if (ModelState.IsValid)
            {
                db.DiscretionaryRules.Add(discretionaryRule);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(discretionaryRule);
        }

        // GET: DiscretionaryRules/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiscretionaryRule discretionaryRule = await db.DiscretionaryRules.FindAsync(id);
            if (discretionaryRule == null)
            {
                return HttpNotFound();
            }
            return View(discretionaryRule);
        }

        // POST: DiscretionaryRules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DiscretionaryRuleID,ConsultantID,CustomerID,Rules,CustomerBuy,CustomerSell,ConsultantBuy,ConsultantSell")] DiscretionaryRule discretionaryRule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(discretionaryRule).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(discretionaryRule);
        }

        // GET: DiscretionaryRules/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiscretionaryRule discretionaryRule = await db.DiscretionaryRules.FindAsync(id);
            if (discretionaryRule == null)
            {
                return HttpNotFound();
            }
            return View(discretionaryRule);
        }

        // POST: DiscretionaryRules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DiscretionaryRule discretionaryRule = await db.DiscretionaryRules.FindAsync(id);
            db.DiscretionaryRules.Remove(discretionaryRule);
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
