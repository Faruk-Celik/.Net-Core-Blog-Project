﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
	public class NewsLetterController : Controller
	{
		NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());	
		[HttpGet]
		public IActionResult SubscribeMail ()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult SubscribeMail (NewsLetter p)
		{
			p.MailStatus = true;
			nm.AddNewsLetter(p);
			Response.Redirect("/Blog/Index");			
			return PartialView();
		}
	}
}