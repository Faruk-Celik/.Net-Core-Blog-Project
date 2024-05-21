using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
	
	public class WriterController : Controller
	{
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [AllowAnonymous]

        public IActionResult Index ()
		{
			
			return View();
		}
        [AllowAnonymous]

        public IActionResult WriterProfile ()
		{
			return View();
		}
        [AllowAnonymous]

        public IActionResult WriterMail ()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Test ()
		{
			return View();
		}
        [AllowAnonymous]
        public IActionResult WriterNavbarPartial ()
		{
			return PartialView();
		}
        [AllowAnonymous]
        public IActionResult WriterFooterPartial ()
		{
			return PartialView();
		}
		[AllowAnonymous]
		[HttpGet]
        public IActionResult WriterEditProfile ()
        {
			var writervalues = wm.TGetById(6);
            return View(writervalues);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile (Writer p )
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult results = wv.Validate(p);
            if (results.IsValid)
            {
                wm.TUpdate(p);
                return RedirectToAction("Index","Dashboard");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }


    }
	
}
