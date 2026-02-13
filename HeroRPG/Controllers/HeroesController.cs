using AutoMapper;
using HeroRPG.Data;
using HeroRPG.Models;
using HeroRPG.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HeroRPG.Controllers
{
    public class HeroesController : Controller
    {
        private readonly HeroRPG_DbContext heroRPG_Db;
        private readonly IMapper mapper;

        public HeroesController(HeroRPG_DbContext heroRPG_Db, IMapper mapper)
        {
            this.heroRPG_Db = heroRPG_Db;
            this.mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> AllHeroes()
        {
            IEnumerable<HeroViewModel> heroes = this.mapper.ProjectTo<HeroViewModel> (heroRPG_Db
                .Heroes
                .Include(h => h.Race));

            return View(heroes);
        }
    }
}
//Select(h => new HeroViewModel
                //{
                //    Id = h.Id,
                //    Name = h.Name,
                //    RaceName = h.Race.Name,
                //    Strength = h.Strength,
                //    Constitution = h.Constitution,
                //    Dexterity = h.Dexterity,
                //    Description = h.Description ?? string.Empty
                //})
