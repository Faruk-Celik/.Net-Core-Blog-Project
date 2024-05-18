using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace CoreProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index ()
        {
            var values = bm.TGetListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll ( int id )
        {
            ViewBag.i = id;
            var values = bm.TGetBlogById(id);
            return View(values);
        }
        public IActionResult BlogListByWriter ()
        {

            var values = bm.TGetListWithCategoryByWriter(3);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd ()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());   
            List<SelectListItem> valueCategory = (from x in cm.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      //Disabled = false,
                                                      //Group = null,
                                                      //Selected = false,
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valueCategory;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd ( Blog p )
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);

            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 3;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }


            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }

    }
}
