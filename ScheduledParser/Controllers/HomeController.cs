using System.Web.Mvc;
using ScheduledParser.Utils;

namespace ScheduledParser.Controllers
{
    public class HomeController : Controller
    {
        const string VringeNews = "http://vringe.com/news/";

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(string Url)
        {
            var parser = new Parser();
            parser.ParceUrlToHtml(VringeNews);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}