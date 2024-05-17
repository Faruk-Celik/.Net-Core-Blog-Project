﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreProject.WebUI.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index ()
		{
			return View();
		}
		[AllowAnonymous]
		[HttpPost]
		public async Task<IActionResult> Index ( Writer p )
		{
			Context c = new Context();
			var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
			if (dataValue != null)
			{
                var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,p.WriterMail)
				};
				var userIdentity = new ClaimsIdentity(claims, "login");
				ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "Blog");
			}
			else
			{
				return View();
			}
		}
			
	}
}








	//public IActionResult Index ( Writer p)
	//{
	//	Context c = new Context();
	//	var dataValue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
	//	if (dataValue != null)
	//	{
	//		HttpContext.Session.SetString("username", p.WriterMail);
	//		return RedirectToAction("Index", "Writer");
	//	}
	//	else
	//	{
	//		return View();
	//	}

	//}

