using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TJCU.CKSP.Common;
using TJCU.CKSP.Models;

namespace TJCU.CKSP.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ShowUserInfo(string userRole, string username)
        {
            var list = new Object();
            if (userRole == "1")
            {
                list = SqlSugarHelper.Instance.Queryable<EntityTeacher>().First(it => it.TeacherName == username);//查询单条                
            }
            if (userRole == "2")
            {
                list = SqlSugarHelper.Instance.Queryable<EntityStudent>().First(it => it.StudentName == username);//查询单条
               
            }
            if (userRole == "3")
            {
                list = SqlSugarHelper.Instance.Queryable<EntityAdmin>().First(it => it.AdminName == username);//查询单条
               
            }
           
            return Ok(list);           
        }

        public IActionResult UserFilesInfo(string username)
        {
            var filesList = SqlSugarHelper.Instance.Queryable<EntityFiles>().Where(it => it.UploadName == username).ToList();
            return Ok(filesList);

        }

    }
}