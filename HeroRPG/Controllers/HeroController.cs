using HeroRPG.Data;
using HeroRPG.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeroRPG.Controllers
{
    public class HeroController : Controller
    {
        private readonly HeroRPG_DbContext heroRPG_Db;
        public HeroController(HeroRPG_DbContext heroRPG_Db)
        {
            this.heroRPG_Db = heroRPG_Db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await heroRPG_Db
                .Heroes
                .Include(h => h.Race)
                .ToListAsync());
        }
    }
}
