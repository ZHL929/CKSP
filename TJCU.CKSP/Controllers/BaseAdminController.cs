using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TJCU.CKSP.Controllers
{
    public class BaseAdminController : Controller
    {
        /// <summary>
        /// 实现统一登录验证检查
        /// </summary>
        /// <param name="filterContext"></param>
        //public override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    base.OnActionExecuting(filterContext);
        //    var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

        //    var userName = Session["UserName"] as String;
        //    if (String.IsNullOrEmpty(userName))
        //    {
        //        //重定向至登录页面
        //        filterContext.Result = RedirectToAction("Index", "Login", new { url = Request.RawUrl });
        //        return;
        //    }

        //}


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}