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
        private readonly HeroRpgDbContext heroRPG_Db;
        private readonly IMapper mapper;

        public HeroesController(HeroRpgDbContext heroRPG_Db, IMapper mapper)
        {
            this.heroRPG_Db = heroRPG_Db;
            this.mapper = mapper;
        }

        [HttpGet]

        public IActionResult AllHeroes()
        {
            IEnumerable<HeroViewModel> heroes = this.mapper.ProjectTo<HeroViewModel>(heroRPG_Db
                .Heroes
                .Include(h => h.Race));

            return View(heroes);
        }
        [HttpGet]
        public IActionResult Create()
        {        
            CreateNewHeroForm newHeroForm = new()
            {
                RaceName = GetAllRaces()
            };
            return View(newHeroForm);
        }

        private IEnumerable<SelectRaceViewModel> GetAllRaces()
        {
            return mapper.ProjectTo<SelectRaceViewModel>(heroRPG_Db.Races);
        }
    }
}