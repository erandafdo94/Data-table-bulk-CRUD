using SingaTest.Data;
using SingaTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingaTest.Controllers
{
    public class HomeController : Controller
    {
        private BmwDbContext _dbrepo = new BmwDbContext();
        public ActionResult Index()
        {
            List<DetailsView> detailList = new List<DetailsView>();


            var tableData = from m in _dbrepo.MonthData
                            join s in _dbrepo.Serieses
                            on m.SeriesesId equals s.SeriesesId
                            select new DetailsView
                            {
                                Ecs = s.Ecs,
                                Bcat = s.Bcat,
                                Series = s.Series,
                                Jan = m.Jan,
                                Feb = m.Feb,
                                March = m.March,
                                April = m.April,
                                May = m.May,
                                June = m.June,
                                July = m.July,
                                August = m.August,
                                September = m.September,
                                October = m.October,
                                November = m.November,
                                December = m.December
                            };
            detailList = tableData.ToList();

            return View(tableData);
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