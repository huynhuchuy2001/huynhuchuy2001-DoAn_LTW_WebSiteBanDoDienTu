using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DealineMVC.Models;
namespace DealineMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        QuanLyBanHangEntities3 db = new QuanLyBanHangEntities3();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            var lstSanPhamLTM = db.SanPhams.Where(n => n.MaLoaiSP == 2 && n.Moi == 1);
            ViewBag.LstSP = lstSanPhamLTM;

            var lstSanPhamDT = db.SanPhams.Where(n => n.MaLoaiSP == 1 && n.Moi == 1);
            ViewBag.LstDT = lstSanPhamDT;
            var lstSanPhamMTB = db.SanPhams.Where(n => n.MaLoaiSP == 3 && n.Moi == 1);
            ViewBag.LstMTB = lstSanPhamMTB;
            return View();
        }
        public ActionResult SanPhamPartial()
        {
            /*var lstSanPhamLTM = db.SanPhams.Where(n => n.MaLoaiSP == 2 && n.Moi == 1);*/
            return PartialView();
        }
        public ActionResult MenuPartial()
        {
            var lstSP = db.SanPhams;
            return PartialView(lstSP);
        }
        public ActionResult Index2()
        {
            // tao viewbag de lay gia tri tu csdl
            // list dt moi nhat
            var lstDTM = db.SanPhams.Where(n => n.MaLoaiSP == 1 && n.Moi == 1);
            // gan vao viewbag
            ViewBag.ListDTM = lstDTM;
            var lstLT = db.SanPhams.Where(n => n.MaLoaiSP == 2 && n.Moi == 1);
            // gan vao viewbag
            ViewBag.ListLTM = lstLT;
            var lstMTB = db.SanPhams.Where(n => n.MaLoaiSP == 3 && n.Moi == 1);
            // gan vao viewbag
            ViewBag.ListMTB = lstMTB;
            return View();
        }




    }
}