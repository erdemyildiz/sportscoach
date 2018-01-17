using BLL;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static BLL.Repository;

namespace SportsCoach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Courses()
        {
            BaseRepository<Courses> rep = new BaseRepository<Courses>();
            
            return View(rep.GetAll());
        }

        public ActionResult Pricing()
        {
            BaseRepository<Pricing> rep = new BaseRepository<Pricing>();
            return View(rep.GetAll());
        }

        public ActionResult Testimonials()
        {
            BaseRepository<Testimonials> rep = new BaseRepository<Testimonials>();
            return View(rep.GetAll());
        }

        public ActionResult Contact()
        {
            BaseRepository<Contact> rep = new BaseRepository<Contact>();
            return View(rep.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //Create...


        [HttpGet]
        public ActionResult CreateAboutUs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAboutUs(AboutUs aboutus, HttpPostedFileBase resim)
        {
            var klasor = Server.MapPath("/Content/");
            if (resim != null && resim.ContentLength != 0)
            {
                if (resim.ContentLength > 2 * 1024 * 1024)
                    ModelState.AddModelError(null, "Resim boyutu max 'MB olabilir.");
                else
                {
                    try
                    {
                        FileInfo fi = new FileInfo(resim.FileName);
                        var rastgele = Guid.NewGuid().ToString().Substring(0, 5);
                        var dosyaAdi = fi.Name + rastgele + fi.Extension;

                        resim.SaveAs(klasor + dosyaAdi);
                        aboutus.ProjectImage = dosyaAdi;
                    }
                    catch { }
                }
                if (ModelState.IsValid)
                {
                    BaseRepository<AboutUs> rep = new BaseRepository<AboutUs>();
                    rep.Insert(aboutus);

                }


            }

            return View();
            //BaseRepository<General> rep = new BaseRepository<General>();
            //rep.Insert(general);

            //return View();
        }


        public ActionResult CreateCourses()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCourses(Courses courses, HttpPostedFileBase resim)
        {
            var klasor = Server.MapPath("/Content/img/");
            if (resim != null && resim.ContentLength != 0)
            {
                if (resim.ContentLength > 2 * 1024 * 1024)
                    ModelState.AddModelError(null, "Resim boyutu max 'MB olabilir.");
                else
                {
                    try
                    {
                        FileInfo fi = new FileInfo(resim.FileName);
                        var rastgele = Guid.NewGuid().ToString().Substring(0, 5);
                        var dosyaAdi = fi.Name + rastgele + fi.Extension;

                        resim.SaveAs(klasor + dosyaAdi);
                        courses.CoursesImage = dosyaAdi;
                    }
                    catch { }
                }
                if (ModelState.IsValid)
                {
                    BaseRepository<Courses> rep = new BaseRepository<Courses>();
                    rep.Insert(courses);

                }


            }

            return View();
            //BaseRepository<General> rep = new BaseRepository<General>();
            //rep.Insert(general);

            //return View();
        }


        public ActionResult CreatePricing()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePricing(Pricing pricing)
        {
            BaseRepository<Pricing> rep = new BaseRepository<Pricing>();
            rep.Insert(pricing);

            return View();
        }


        public ActionResult CreateTestimonials()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonials(Testimonials testimonials, HttpPostedFileBase resim)
        {
            var klasor = Server.MapPath("/Content/");
            if (resim != null && resim.ContentLength != 0)
            {
                if (resim.ContentLength > 2 * 1024 * 1024)
                    ModelState.AddModelError(null, "Resim boyutu max 'MB olabilir.");
                else
                {
                    try
                    {
                        FileInfo fi = new FileInfo(resim.FileName);
                        var rastgele = Guid.NewGuid().ToString().Substring(0, 5);
                        var dosyaAdi = fi.Name + rastgele + fi.Extension;

                        resim.SaveAs(klasor + dosyaAdi);
                        testimonials.ProfilResmi = dosyaAdi;
                    }
                    catch { }
                }
                if (ModelState.IsValid)
                {
                    BaseRepository<Testimonials> rep = new BaseRepository<Testimonials>();
                    rep.Insert(testimonials);

                }


            }

            return View();
            //BaseRepository<General> rep = new BaseRepository<General>();
            //rep.Insert(general);

            //return View();
        }


        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(Contact contact)
        {
            BaseRepository<Contact> rep = new BaseRepository<Contact>();
            rep.Insert(contact);

            return View();
        }
        //[Authorize(Roles = "Admin,Author")]
        public ActionResult Admin()
        {
            return View();
        }


        //Create...

    }
}