using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Repositories;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProfileRepository _profileRepository;
        public HomeController(ILogger<HomeController> logger, IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
            _logger = logger;
        }
        /// <summary>
        /// routes to the home page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var HomeViewModel = new HomeViewModel();
            HomeViewModel.Name =
                $"{_profileRepository.GetProfile().LastName} {_profileRepository.GetProfile().FirstName}";
            HomeViewModel.Professions = _profileRepository.GetProfile().Professions;
            return View(HomeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// routes to the about page
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            var AboutViewModel = new AboutViewModel();
            AboutViewModel.AboutDescriptor = _profileRepository.GetProfile().AboutMeDescription;
            AboutViewModel.Contacts = _profileRepository.GetProfile().Contact;
            return View(AboutViewModel);
        }
        /// <summary>
        /// routes to the technical skill page
        /// </summary>
        /// <returns></returns>
        public IActionResult Skills()
        {
            var SkillsViewModel = new SKillsViewModel();
            SkillsViewModel.SkillDescriptor = _profileRepository.GetProfile().SkillDescription;
            SkillsViewModel.Skills = _profileRepository.GetProfile().Skills;
            return View(SkillsViewModel);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
