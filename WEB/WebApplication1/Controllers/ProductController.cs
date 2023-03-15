using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        webbanhangEntities objwebbanhangEntities = new webbanhangEntities();

        // GET: Product
        public ActionResult Detail()
        {
            var objProduct = objwebbanhangEntities.Products.FirstOrDefault();
            return View(objProduct);
        }
    }
}