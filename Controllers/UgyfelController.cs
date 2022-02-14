using ASP220211V3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP220211V3.Controllers
{
    public class UgyfelController : Controller
    {
        #region _context shit
        private ApplicationDbContext _context;
        public UgyfelController() =>
            _context = new ApplicationDbContext();
        protected override void Dispose(bool disposing) =>
            _context.Dispose();
        #endregion

        // GET: Ugyfel
        public ActionResult Index()
        {
            var ugyfelek = _context.Ugyfelek.ToList();
            return View(ugyfelek);
        }

        public ActionResult Reszletek(int id)
        {
            var ugyfel = _context.Ugyfelek.FirstOrDefault(x => x.Id == id);
            if (ugyfel != null) return View(ugyfel);
            else return Content("HIBA");
        }
    }
}