using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PCRegistSystem.Models;

namespace PCRegistSystem.Controllers
{
    public class PCManageInfoesController : Controller
    {
        private PCManageInfoDBContext db = new PCManageInfoDBContext();

        // GET: PCManageInfoes
        public ActionResult Index()
        {
            return View(db.PCManageInfos.ToList());
        }

        // GET: PCManageInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PCManageInfo pCManageInfo = db.PCManageInfos.Find(id);
            if (pCManageInfo == null)
            {
                return HttpNotFound();
            }
            return View(pCManageInfo);
        }

        // GET: PCManageInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PCManageInfoes/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IPAdress,UserCategory,MachineType,ModelNumber,UserName,PCName,Remarks1,Remarks2")] PCManageInfo pCManageInfo)
        {
            if (ModelState.IsValid)
            {
                db.PCManageInfos.Add(pCManageInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pCManageInfo);
        }

        // GET: PCManageInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PCManageInfo pCManageInfo = db.PCManageInfos.Find(id);
            if (pCManageInfo == null)
            {
                return HttpNotFound();
            }
            return View(pCManageInfo);
        }

        // POST: PCManageInfoes/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IPAdress,UserCategory,MachineType,ModelNumber,UserName,PCName,Remarks1,Remarks2")] PCManageInfo pCManageInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pCManageInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pCManageInfo);
        }

        // GET: PCManageInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PCManageInfo pCManageInfo = db.PCManageInfos.Find(id);
            if (pCManageInfo == null)
            {
                return HttpNotFound();
            }
            return View(pCManageInfo);
        }

        // POST: PCManageInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PCManageInfo pCManageInfo = db.PCManageInfos.Find(id);
            db.PCManageInfos.Remove(pCManageInfo);
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
