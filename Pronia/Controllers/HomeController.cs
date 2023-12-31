﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DAL;
using Pronia.Entities;
using Pronia.ViewModels;

namespace P140_Pronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaDbContext _context;

        public HomeController(ProniaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM model = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Plants = _context.Plants.Include(p => p.PlantImages).ToList()
            };

            if (model.Sliders is null || model.Plants is null) return NotFound();

            return View(model);
        }
    }
}