using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager ab = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = ab.TGetList();
            return View(values);
        }
    }
}
