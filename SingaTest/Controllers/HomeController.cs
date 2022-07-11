using NLog;
using SingaTest.Data;
using SingaTest.Models;
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
        private static Logger logger = LogManager.GetLogger("myAppLoggerTarget");

        #region Methods
        /// <summary>
        /// Get the list of month data from the DB
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<DetailsView> detailList = new List<DetailsView>();

            var tableData = from m in _dbrepo.MonthData
                            join s in _dbrepo.Serieses
                            on m.SeriesesId equals s.SeriesesId
                            select new DetailsView
                            {
                                MonthId = m.Id,
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
                                December = m.December,
                                Total = m.Jan + m.Feb + m.March + m.April + m.May + m.June + m.July + m.August + m.September + m.October + m.November + m.December
                            };

            detailList = tableData.ToList();
            return View(tableData);
        }


        /// <summary>
        /// Update new records from user input
        /// </summary>
        /// <param name="monthList">A list of rows of the table with the updated data</param>

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult UpdateMonthData(IEnumerable<DetailsView> monthList)
        {
            try
            {
                foreach (var item in monthList)
                {
                    MonthData monthRecord = _dbrepo.MonthData.Where(m => m.Id == item.MonthId).FirstOrDefault();

                    if (monthRecord != null)
                    {
                        monthRecord.Jan = item.Jan;
                        monthRecord.Feb = item.Feb;
                        monthRecord.March = item.March;
                        monthRecord.April = item.April;
                        monthRecord.May = item.May;
                        monthRecord.June = item.June;
                        monthRecord.July = item.July;
                        monthRecord.August = item.August;
                        monthRecord.September = item.September;
                        monthRecord.October = item.October;
                        monthRecord.November = item.November;
                        monthRecord.December = item.December;

                        _dbrepo.SaveChanges();
                        logger.Info("Data updated successfully. Month Id" + item.MonthId.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("Error updating records" + ex.ToString());
                return Json(new { result = "ERROR" });
            }
            return Json(new { result = "OK"});
        } 
        #endregion
    }
}
