﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Media_Database.Models;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Media_Database.Controllers
{
    public class GamesController : Controller
    {
        //global => for using in all functions
        MediaObjectContext dbContext = new MediaObjectContext();

        public GamesController (MediaObjectContext dbContext) {
            this.dbContext = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            GamesViewModel viewModel = new GamesViewModel();
            viewModel.Games = dbContext.Games.ToList();
            return View(viewModel);
        }
    }
}
