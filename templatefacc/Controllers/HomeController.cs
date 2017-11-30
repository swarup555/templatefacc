using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace templatefacc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ArrayList data = new ArrayList();
            ////List <siteobservationreportdata> data1=new List<siteobservationreportdata>();
            ////var data3 = dbs.epmc_survey_data.Select(l => new 
            ////{
            ////    month=l.mobile_date,
            ////    pass=l.pass

            ////} ).ToList();
            ////foreach (var item in data3)
            ////{
            ////    siteobservationreportdata obj=new siteobservationreportdata();
            ////    //obj.survey_date = DateTime.ParseExact(item.month,
            ////    //                    "MM/dd/yyyy HH:mm",
            ////    //                    CultureInfo.InvariantCulture);
            ////    obj.survey_date = Convert.ToDateTime(item.month,
            ////                      System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat); 

            ////    obj.pass=item.pass;
            ////    data1.Add(obj);
            ////}

            ////var data2 = data1.ToList().GroupBy(x => new { x.survey_date.Value.Month, x.survey_date.Value.Year, x.pass }).Select(op =>
            ////                           new siteobservationreportdata
            ////                           {
            ////                               Month = op.Key.Month,
            ////                               pass = op.Key.pass,
            ////                               Year = op.Key.Year,
            ////                               Total = op.Count()
            ////                           }
            ////                       ).ToList().Where(z => z.pass == "1");
            //var siteobservationdata =
            //   dbs.epmc_survey_data
            //                   .Select(lg =>
            //                       new
            //                       {
            //                           Month = lg.added_date,
            //                           passed = lg.pass

            //                       }).ToList().GroupBy(x => new { x.Month.Month, x.Month.Year, x.passed }).Select(op =>
            //                           new siteobservationreportdata
            //                           {
            //                               Month = op.Key.Month,
            //                               pass = op.Key.passed,
            //                               Year = op.Key.Year,
            //                               Total = op.Count()
            //                           }
            //                       ).ToList().Where(z => z.pass == "1").OrderBy(x => x.Month);
            //var siteobservationdata1 =
            //  dbs.epmc_survey_data
            //                  .Select(lg =>
            //                      new
            //                      {
            //                          Month = lg.added_date,
            //                          passed = lg.pass

            //                      }).ToList().GroupBy(x => new { x.Month.Month, x.Month.Year, x.passed }).Select(op =>
            //                          new siteobservationreportdata
            //                          {
            //                              Month = op.Key.Month,
            //                              pass = op.Key.passed,
            //                              Year = op.Key.Year,
            //                              Total = op.Count()
            //                          }
            //                      ).ToList().Where(z => z.pass == "2").OrderBy(x => x.Month);
            //data.Add(siteobservationdata);
            //data.Add(siteobservationdata1);
            //return Json(data, JsonRequestBehavior.AllowGet);
            return View();
        }
    }
}