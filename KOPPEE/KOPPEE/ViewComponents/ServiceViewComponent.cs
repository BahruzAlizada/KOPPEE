﻿using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOPPEE.ViewComponents
{
	public class ServiceViewComponent : ViewComponent
	{
		private readonly AppDbContext _db;

        public ServiceViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Service> services = new List<Service>();
            if (take == 0)
            {
                services = await _db.Services.Where(x=>!x.IsDeactive).OrderByDescending(x=>x.Id).ToListAsync();
            }
            else
            {
                services = await _db.Services.Where(x => !x.IsDeactive).OrderByDescending(x => x.Id).Take(take).ToListAsync();
            }
           

            return View(services);

        }
    }
}
