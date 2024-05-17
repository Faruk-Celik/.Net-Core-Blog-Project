﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
	public class AboutController : Controller
	{
		AboutManager abm = new AboutManager(new EfAboutRepository());
		public IActionResult Index ()
		{
			var values = abm.GetList();

			return PartialView(values);
			
		}
		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}