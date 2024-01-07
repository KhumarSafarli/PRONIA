﻿using Microsoft.AspNetCore.Mvc;
using Pronia.ViewModels;

namespace Pronia.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM account)
        {
            if (!ModelState.IsValid) return View();
            if (!account.IsTermsAccepted)
            {
                ModelState.AddModelError("IsTermsAccepted", "You must accept our terms");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
