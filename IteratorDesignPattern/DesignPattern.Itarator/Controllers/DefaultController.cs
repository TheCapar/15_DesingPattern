using DesignPattern.Iterator.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Iterator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "Almanya",
                CityName ="Berlin",
                VisitPlaceName = "Berlin Kapısı"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "Fransa",
                CityName = "Paris",
                VisitPlaceName = "Eyfel Kulesi"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "İtalya",
                CityName = "Venedik",
                VisitPlaceName = "Gondol"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "İtalya",
                CityName = "Roma",
                VisitPlaceName = "Colesyum"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                Country = "Çek Cumhuriyeti",
                CityName = "Prag",
                VisitPlaceName = "Meydan"
            });

            var iterator = visitRouteMover.CreateIterator();

            while (iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.Country+" "+iterator.CurrentItem.CityName+" "+iterator.CurrentItem.VisitPlaceName);
            }
            ViewBag.v = strings;
            return View();
        }
    }
}
