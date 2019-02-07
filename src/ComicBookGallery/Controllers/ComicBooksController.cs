using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    { 
        //Action method Detail()
        public ContentResult Detail()
        {
            //ContentResult() is an MVC action result type
            return new ContentResult()
            {
                if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return new RedirectResult("/");
            }
                Content = "Hello from the comic book controller!"
            };
           
        }
    }
}