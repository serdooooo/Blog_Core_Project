﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceManager em = new ExperienceManager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = em.TGetList();
            return View(values);
        }
    }
}
