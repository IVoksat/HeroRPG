using HeroRPG.Data;
using HeroRPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace HeroRPG.Controllers
{
    public class HeroController : Controller
    {
        private readonly HeroRPG_DbContext heroRPG_Db;
        public HeroController(HeroRPG_DbContext heroRPG_Db)
        {
            this.heroRPG_Db = heroRPG_Db;
        }

        public IActionResult Index()
        {
            HashSet<Hero> heroes = heroRPG_Db.Heroes
                .ToHashSet();

            return View(heroes);
        }
    }
}
