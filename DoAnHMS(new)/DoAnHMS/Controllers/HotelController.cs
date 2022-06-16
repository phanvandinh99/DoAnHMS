using DoAnHMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnHMS.Controllers
{
    public class HotelController : Controller
    {
        private readonly DoAnHMSEntities db = new DoAnHMSEntities();
        // GET: Hotel
        public ActionResult Index()
        {
            return View(db.LoaiPhongs.ToList());
        }

        public ActionResult DatPhong(string maphong)
        {

            return View(db.LoaiPhongs.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "hoTen,sdt,email")] LienHe lienHe)
        {
            if (ModelState.IsValid)
            {
                lienHe.ngayGui = DateTime.Now;
                lienHe.tinhTrang = false;
                db.LienHes.Add(lienHe);
                db.SaveChanges();
                return RedirectToAction("Announce");
            }
            return RedirectToAction("Index");
        }

        public ActionResult Announce()
        {
            return View();
        }

        public ActionResult PhanHoi()
        {
            return View();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PhanHoi([Bind(Include = "hoTen,sdt,email,noiDung")] PhanHoi phanHoi)
        {
            if (ModelState.IsValid)
            {
                phanHoi.ngayGui = DateTime.UtcNow;
                phanHoi.TinhTrang = false;
                db.PhanHois.Add(phanHoi);
                db.SaveChanges();
                return RedirectToAction("ThankYou");
            }
            return View(phanHoi);
        }

        public ActionResult ThankYou()
        {
            return View();
        }

        public ActionResult PhanHoi()
        {
            return View();
        }
    }
}