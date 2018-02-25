using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LizyKitchen.App_Start;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LizyKitchen.Controllers
{
    public class RecipeController : Controller
    {
        public readonly JalapenioContext Context = new JalapenioContext();

        public ActionResult Index()
        {
            var recipies = Context.Recipes.Find(new BsonDocument()).ToEnumerable();

            return View(recipies);
        }
    }
}
