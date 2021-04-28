using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TJCU.CKSP.Models;
using TJCU.CKSP.Common;

namespace TJCU.CKSP.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Project_detail()
        {
            return View();
        }
       
        [HttpGet]
        public IActionResult FindCourse(int courseId)
        {
            var course = SqlSugarHelper.Instance.Queryable<EntityCourse>().Where(it => it.CourseId == courseId).ToList();
            return Ok(course);
        }


        [HttpGet]
        public IActionResult GetCourseList(int majorId)
        {
            var courseList = SqlSugarHelper.Instance.Queryable<EntityCourse>().Where(it => it.MajorId == majorId).ToList();
            //string data = JsonConvert.SerializeObject(courseList);
            return Ok(courseList);
        }

        [HttpGet]
        public IActionResult GetMajor()
        {
            var majorList = SqlSugarHelper.Instance.Queryable<EntityMajor>().ToList();
            //string data = JsonConvert.SerializeObject(courseList);
            return Ok(majorList);
        }


        [HttpPost]
        public IActionResult AddCourse(EntityCourse course)
        {
            var list = SqlSugarHelper.Instance.Insertable<EntityCourse>(course).ExecuteCommand();
            //var row = m_DBContenxt.Insert(book).ExecuteAffrows();
            if (list > 0)
            {
                return Ok(new { code = 200, msg = "新增课程成功！" });
            }
            return Ok(new { code = 400, msg = "新增课程失败！" });

        }

        [HttpDelete]
        public IActionResult DeteCourse(int courseId)
        {
            var delete = SqlSugarHelper.Instance.Deleteable<EntityCourse>().Where(new EntityCourse() { CourseId = courseId }).ExecuteCommand();
            if (delete > 0)
            {
                return Ok(new { code = 200, msg = "删除成功！" });
            }
            return Ok(new { code = 400, msg = "删除失败！" });
        }
        
        [HttpPut]
        public IActionResult CheckCourse(int courseId)
        {
            var check = 0;
            var course = SqlSugarHelper.Instance.Queryable<EntityCourse>().Where(it => it.CourseId == courseId).ToList();
            if (course[0].Status == EnumStatus.待审核.GetHashCode())
            {
                 check = SqlSugarHelper.Instance.Updateable<EntityCourse>().SetColumns(it => new EntityCourse() { Status = EnumStatus.开课中.GetHashCode() }).Where(it => it.CourseId == courseId).ExecuteCommand();
            }
            else
            {
                return Ok(new { code = 500, msg = "已审核过了！" }); ;
            }
            if (check > 0)
            {
                return Ok(new { code = 200, msg = "审核成功！" });
            }
            return Ok(new { code = 400, msg = "审核失败！" });

        }
    }
}