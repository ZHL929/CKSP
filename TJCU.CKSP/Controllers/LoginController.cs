using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TJCU.CKSP.Common;
using TJCU.CKSP.Models;

namespace TJCU.CKSP.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Forget()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string userName, string pwd,string value)
        {
            HttpContext.Session.SetString("UserName", userName);
            HttpContext.Session.SetString("UserRole", value);

            int i = 0;
            if (value == "1")
            {                
                var list = SqlSugarHelper.Instance.Queryable<EntityTeacher>().First(it => it.TeacherName == userName && it.TeacherPassword == pwd);//查询单条
                if(list != null)
                {
                    i += 1;
                }
            }
            if (value == "2")
            {
                var list = SqlSugarHelper.Instance.Queryable<EntityStudent>().First(it => it.StudentName == userName && it.StudentPassword == pwd);//查询单条
                if (list != null)
                {
                    i += 1;
                }
            }
            if (value == "3")
            {
                var list = SqlSugarHelper.Instance.Queryable<EntityAdmin>().First(it => it.AdminName == userName && it.AdminPassword == pwd);//查询单条
                if (list != null)
                {
                    i += 1;
                }
            }
            if (i != 0 )
            {
                //byte[] loginName;
                //var nname = HttpContext.Session.TryGetValue("UserName", out loginName);
                //string myname = System.Text.Encoding.UTF8.GetString(loginName);
                string loginName =  HttpContext.Session.GetString("UserName");
                string userRole =  HttpContext.Session.GetString("UserRole");
                CurrentUser.UserName = loginName;
                CurrentUser.UserRole = userRole;

                return Ok(new { Message = "登陆成功", Code = 1 });
            }
            else
            {
                return Ok(new { Message = "登陆失败", Code = 0 });

            }

        }

        [HttpPost]
        public IActionResult Register(string userName, string pwd, string phone,string value)
        {            
            int i = 0;
            if (value == "1")
            {
                EntityTeacher teacher = new EntityTeacher();
                teacher.TeacherName = userName;
                teacher.TeacherPassword = pwd;
                teacher.PhoneNumber = phone;
                var list = SqlSugarHelper.Instance.Insertable<EntityTeacher>(teacher).ExecuteCommand();
                if (list > 0)
                {
                    i += 1;
                }
            }
            if (value == "2")
            {
                EntityStudent student = new EntityStudent();
                student.StudentName = userName;
                student.StudentPassword = pwd;
                student.PhoneNumber = phone;
                var list = SqlSugarHelper.Instance.Insertable<EntityStudent>(student).ExecuteCommand();
                if (list > 0)
                {
                    i += 1;
                }
            }
            if (value == "3")
            {
                EntityAdmin admin = new EntityAdmin();
                admin.AdminName = userName;
                admin.AdminPassword = pwd;
                admin.PhoneNumber = phone;
                var list = SqlSugarHelper.Instance.Insertable<EntityAdmin>(admin).ExecuteCommand();
                if (list > 0)
                {
                    i += 1;
                }
            }
            if (i != 0)
            {
                return Ok(new { Message = "注册成功", Code = 1 });
            }
            else
            {
                return Ok(new { Message = "注册失败", Code = 0 });

            }
        }

        [HttpPut]
        public IActionResult Forget(string userName, string pwd, string value)
        {
            int i = 0;
            if (value == "1")
            {
                EntityTeacher teacher = SqlSugarHelper.Instance.Queryable<EntityTeacher>().First(it => it.TeacherName == userName);
                teacher.TeacherPassword = pwd;
                var list = SqlSugarHelper.Instance.Updateable(teacher).WhereColumns(it => new { it.TeacherName }).ExecuteCommand();
                if (list > 0)
                {
                    i += 1;
                }
            }
            if (value == "2")
            {
                EntityStudent student = SqlSugarHelper.Instance.Queryable<EntityStudent>().First(it => it.StudentName == userName);
                student.StudentPassword = pwd;
                var list = SqlSugarHelper.Instance.Updateable(student).WhereColumns(it => new { it.StudentName }).ExecuteCommand();
                if (list > 0)
                {
                    i += 1;
                }
            }
            if (value == "3")
            {
                EntityAdmin admin = SqlSugarHelper.Instance.Queryable<EntityAdmin>().First(it => it.AdminName == userName);
                admin.AdminPassword = pwd;
                var list = SqlSugarHelper.Instance.Updateable(admin).WhereColumns(it => new { it.AdminName }).ExecuteCommand();
                if (list > 0)
                {
                    i += 1;
                }
            }
            if (i != 0)
            {
                return Ok(new { Message = "密码重置成功", Code = 1 });
            }
            else
            {
                return Ok(new { Message = "密码重置失败", Code = 0 });

            }
        }

        

    }
}