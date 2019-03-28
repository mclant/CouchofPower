using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _4onACouch.DAL;
using _4onACouch.Models;
using System.Data.Entity;

namespace _4onACouch.Controllers
{
    public class HomeController : Controller
    {
        private _4onACouchContext db = new _4onACouchContext();
        Random rnd = new Random();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateGame()
        {
            int id = rnd.Next(1000, 9999);

            db.Database.ExecuteSqlCommand(
                "INSERT INTO [dbo].[Game] (GameID)" +
                "VALUES ('" + id + "')");

            

            IEnumerable<Game> newgame =
                db.Database.SqlQuery<Game>(
                    "Select GameID" +
                    "from Game");

            return View(newgame);
        }

        public ActionResult JoinGame()
        {
            return View();
        }
    }
}