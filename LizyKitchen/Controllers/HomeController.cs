using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using LizyKitchen.App_Start;
using MongoDB.Bson;

namespace LizyKitchen.Controllers
{
    public class HomeController : Controller
    {
        public static JalapenioContext Context = new JalapenioContext();

        public async Task<ActionResult> Index()
        {
            var buildInfoCommand = new BsonDocument("buildInfo", 1);
            var buildInfo = await Context.database.RunCommandAsync<BsonDocument>(buildInfoCommand);

            return Content(buildInfo.ToJson(), "application/json");
        }
    }
}
