using KOPPEE.DAL;
using KOPPEE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KOPPEE.ViewComponents
{
    public class FeedbackViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;

        public FeedbackViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<FeedBack> feedbacks = await _db.FeedBacks.Where(x=>!x.IsDeactive).OrderByDescending(x=>x.Id).Take(5).ToListAsync();

            return View(feedbacks);
        }
    }
}
