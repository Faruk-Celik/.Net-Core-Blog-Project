﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject.WebUI.Controllers
{
	
	public class WriterController : Controller
	{
		
		public IActionResult Index ()
		{
			
			return View();
		}
		public IActionResult WriterProfile ()
		{
			return View();
		}
		
		public IActionResult WriterMail ()
		{
			return View();
		}
	}
}