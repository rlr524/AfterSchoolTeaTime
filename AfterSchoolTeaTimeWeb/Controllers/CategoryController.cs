﻿using AfterSchoolTeaTimeWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace AfterSchoolTeaTimeWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBContext _db;

        public CategoryController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objCategoryList = _db.Categories.ToList();
            return View();
        }
    }
}
