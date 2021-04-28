using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TJCU.CKSP.Common;
using TJCU.CKSP.Models;

namespace TJCU.CKSP.Controllers
{
    public class HomeController : Controller
    {
        #region Initialize
        //private readonly ILogger _logger;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        //{
        //     _logger = logger;
        //     _httpContextAccessor = httpContextAccessor;
        //     CurrentUser.Configure(_httpContextAccessor);
        //}
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index_v1()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FindInstituteList()
        {
            var instituteList = SqlSugarHelper.Instance.Queryable<EntityInstitute>().ToList();
            //string data = JsonConvert.SerializeObject(courseList);
            return Ok(instituteList);
        }

        public IActionResult FindMajorList(int instituteId)
        {
            var majorList = SqlSugarHelper.Instance.Queryable<EntityMajor>().Where(it => it.InstituteId == instituteId).ToList();
            return Ok(majorList);
        }

        [HttpGet]
        public IActionResult GetInstitute()
        {
            var instituteList = SqlSugarHelper.Instance.Queryable<EntityInstitute>().ToList();
            return Ok(instituteList);
        }

        [HttpPost]
        public IActionResult AddMajor(EntityMajor major)
        {
            var list = SqlSugarHelper.Instance.Insertable<EntityMajor>(major).ExecuteCommand();
            //var row = m_DBContenxt.Insert(book).ExecuteAffrows();
            if (list > 0)
            {
                return Ok(new { code = 200, msg = "新增专业成功！" });
            }
            return Ok(new { code = 400, msg = "新增专业失败！" });
        }

        [HttpPost]
        public IActionResult AddInstitute(EntityInstitute institute)
        {
            var list = SqlSugarHelper.Instance.Insertable<EntityInstitute>(institute).ExecuteCommand();
            //var row = m_DBContenxt.Insert(book).ExecuteAffrows();
            if (list > 0)
            {
                return Ok(new { code = 200, msg = "新增学院成功！" });
            }
            return Ok(new { code = 400, msg = "新增学院失败！" });
        }


        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
