using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevConSignalR.Models;
using Vote.BAL.Services.Interfaces;

namespace DevConSignalR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandidateServices _candidateServices;

        public HomeController(ICandidateServices candidateServices)
        {
            _candidateServices = candidateServices;
        }

        public IActionResult Index()
        {
            var candidateinfo = _candidateServices.GetCandidateVotes();

            return View(candidateinfo);
        }
    }
}
