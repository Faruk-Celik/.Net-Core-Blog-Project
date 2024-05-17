using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.ViewComponents.Blog
{
	public class Last3BlogPost : ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		public IViewComponentResult Invoke ()
		{
			var values = bm.TLast3BlogPost();
			return View(values);
		}
	}
}
