using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    public class CatagoryController : Controller
    {
        webbanhangEntities objwebbanhangEntities = new webbanhangEntities();

        // GET: Catagory
        public ActionResult Catagory()
        {
            var lstCategory = objwebbanhangEntities.Categories.ToList();
            return View(lstCategory);
        }
        public ActionResult ProductCatagory()
        {
            var lstProduct = objwebbanhangEntities.Products.ToList();

            return View(lstProduct);
        }
    }
}