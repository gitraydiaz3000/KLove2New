using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KLoveEmployeeManagement.Models;
using KLoveEmployeeManagement;


namespace KLoveEmployeeManagement.Controllers
{
    public class EmployeeMusicController : Controller
    {
        private KLoveDBEntities db = new KLoveDBEntities();

        // GET: EmployeeMusic
        public ActionResult Index()
        {
            List<Music> musicList = db.Musics.ToList();
            Music song = new Music();

            musicList = musicList.Select(x => new Music { songID = x.songID, songTitle = x.songTitle, songArtist = x.songArtist, songAlbum = x.songAlbum }).ToList();
            return View(musicList);
            // return View(db.Employees.ToList());
        }

        // GET: EmployeeMusic/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
             Employee employee = db.Employees.Find(id);
             if (employee == null)
             {
                 return HttpNotFound();
             }
             return View(employee);

           // string query = "select concat(a.firstName, a.lastName) As Name, b.songTitle As Song, b.songArtist As Artist, b.songAlbum As Album from Employee a inner join Music b on a.employeeID = b.songID";
           // IEnumerable<string> data = db.Database.SqlQuery<string>(query);
           // return View(data.ToList());
        }

        // GET: EmployeeMusic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeMusic/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "employeeID,firstName,lastName,login,active,hireDate,departmentId,addressLine1,addressLine2,city,state,zipcode,cellPhone,officePhone,email,salary,favoriteSongId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        // GET: EmployeeMusic/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: EmployeeMusic/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "employeeID,firstName,lastName,login,active,hireDate,departmentId,addressLine1,addressLine2,city,state,zipcode,cellPhone,officePhone,email,salary,favoriteSongId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: EmployeeMusic/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: EmployeeMusic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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
