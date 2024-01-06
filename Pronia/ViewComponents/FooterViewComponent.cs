using Microsoft.AspNetCore.Mvc;
using Pronia.DAL;
using Pronia.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks; 

namespace Pronia.ViewComponents
{
    public class FooterViewComponent : ViewComponent  
    {
        private readonly ProniaDbContext _context;

        public FooterViewComponent(ProniaDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return View(settings);
        }
    }
}
