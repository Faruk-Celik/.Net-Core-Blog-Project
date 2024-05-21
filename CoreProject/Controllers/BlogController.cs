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
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

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
                return RedirectToAction("BlogListByWriter");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
        public IActionResult BlogDelete ( int id )
        {
            var blogValue = bm.TGetById(id);
            bm.TDelete(blogValue);
            return RedirectToAction("BlogListByWriter","Blog");
        }
        [HttpGet]
        public IActionResult EditBlog ( int id )
        {
            var blogValue = bm.TGetById(id);
            List<SelectListItem> valueCategory = (from x in cm.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      //Disabled = false,
                                                      //Group = null,
                                                      //Selected = false,
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vc = valueCategory;
            return View(blogValue);
        }
        [HttpPost]
        public IActionResult EditBlog ( Blog p )
        {

            p.WriterID = 3;   
            p.BlogStatus = true;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            bm.TUpdate(p);
            return RedirectToAction("BlogListByWriter","Blog");

        }

    }
}
