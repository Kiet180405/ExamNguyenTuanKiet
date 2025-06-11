using ExamNguyenTuanKiet.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamNguyenTuanKiet.Controllers
{
    public class PhimController : Controller
    {
        private readonly AppDbContext _db;
        public PhimController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var phims = _db.Phims.ToList();
            return View(phims); // Truyền danh sách phim cho View
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Phim phim)
        {
            if (ModelState.IsValid)
            {
                _db.Phims.Add(phim);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phim);
        }
        public IActionResult Update(int id)
        {
            var phim = _db.Phims.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            return View(phim);
        }
        [HttpPost]
        public IActionResult Update(Phim phim)
        {
            if (ModelState.IsValid)
            {

                var existingPhim = _db.Phims.Find(phim.Id);
                if (existingPhim == null)
                {
                    return NotFound();
                }
                existingPhim.TuaDe = phim.TuaDe;
                existingPhim.DienVien = phim.DienVien;
                existingPhim.TrongNuoc = phim.TrongNuoc;
                existingPhim.GiaVe = phim.GiaVe;
                existingPhim.ThoiLuong = phim.ThoiLuong;
                //_db.Phims.Update(phim);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phim);
        }
        public IActionResult Delete(int id)
        {
            var phim = _db.Phims.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            //_db.SaveChanges();
            //return RedirectToAction("Index");
            return View(phim);
        }
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var phim = _db.Phims.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            _db.Phims.Remove(phim);
            _db.SaveChanges();
            TempData["Message"] = "Phim đã được xóa thành công.";
            return RedirectToAction("Index");
        }
    }
}
