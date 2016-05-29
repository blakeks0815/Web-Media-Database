using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Media_Database.Functions;
using Media_Database.Models;
using System.Collections;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Media_Database.Contollers
{
    public class DB_GamesController : Controller
    {

        //global => for using in all functions
        MediaObjectsContext dbContext = new MediaObjectsContext();

        //creating the database context for interaction in the controller
        public DB_GamesController(MediaObjectsContext dbContext) {
            this.dbContext = dbContext;
        }


        // GET: /<controller>/
        public IActionResult Index() {
            
            var theList = dbContext.MediaObjects.ToList();
            return View(theList);
        }
    }
}
