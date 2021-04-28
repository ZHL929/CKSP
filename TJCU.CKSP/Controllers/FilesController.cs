using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using TJCU.CKSP.Common;
using TJCU.CKSP.Models;

namespace TJCU.CKSP.Controllers
{
    public class FilesController : Controller
    {
        private IHostingEnvironment host = null;

        public FilesController(IHostingEnvironment host)
        {
            this.host = host;
        }

        [HttpPost]
        public IActionResult AddFile(EntityFiles files)
        {
            files.FileURL = @"\UploadingFiles\"+files.FileName;
            var list = SqlSugarHelper.Instance.Insertable<EntityFiles>(files).ExecuteCommand();
            if (list > 0)
            {
                return Ok(new { code = 200, msg = "上传文件成功！" });
            }
            return Ok(new { code = 400, msg = "上传文件失败！" });
        }

        [HttpPost]
        [DisableFormValueModelBinding]
        public async Task<IActionResult> Upload()
        {
            var list = 0;
            //FormValueProvider formModel = await Request.StreamFiles(@"D:\Users\INEREST\source\repos\TJCU.CKSP\TJCU.CKSP\UploadingFiles");
            FormValueProvider formModel = await Request.StreamFiles(host.WebRootPath + @"\UploadingFiles");
            //formModel = await Request.StreamFiles(@"D:\Users\INEREST\source\repos\TJCU.CKSP\TJCU.CKSP\UploadingFiles\"+file.CourseId.ToString());
            var viewModel = new MyViewModel();

            var bindingSuccessful = await TryUpdateModelAsync(viewModel, prefix: "", valueProvider: formModel);

            if (!bindingSuccessful)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
            }
            else
            {
                
            }
            //return View();
            return Ok(new { code = 400, msg = "上传文件成功！" });
           //return Ok(viewModel);
        }

        [HttpGet]
        public IActionResult ShowCheckFiles(int courseId)
        {
            var filesList = SqlSugarHelper.Instance.Queryable<EntityFiles>().Where(it => it.CourseId == courseId && it.Status == EnumFileStatus.审核通过.GetHashCode()).ToList();
            return Ok(filesList);
           
            //return View();
        }

        [HttpGet]
        public IActionResult ShowNoCheckFiles()
        {
            var filesList = SqlSugarHelper.Instance.Queryable<EntityFiles>().Where(it => it.Status == EnumFileStatus.待审核.GetHashCode()).ToList();
            return Ok(filesList);
        }

        [HttpPut]
        public IActionResult CheckFiles(int fileId)
        {
            var check = SqlSugarHelper.Instance.Updateable<EntityFiles>().SetColumns(it => new EntityFiles() { Status = EnumFileStatus.审核通过.GetHashCode() }).Where(it => it.FileId == fileId).ExecuteCommand();
            if (check > 0)
            {
                return Ok(new { code = 200, msg = "审核资料成功！" });
            }
            return Ok(new { code = 400, msg = "审核资料失败！" });

        }

        [HttpPut]
        public IActionResult CheckNoFiles(int fileId)
        {
            var check = SqlSugarHelper.Instance.Updateable<EntityFiles>().SetColumns(it => new EntityFiles() { Status = EnumFileStatus.作废.GetHashCode() }).Where(it => it.FileId == fileId).ExecuteCommand();
            if (check > 0)
            {
                return Ok(new { code = 200, msg = "作废资料成功！" });
            }
            return Ok(new { code = 400, msg = "作废资料失败！" });

        }

        [HttpDelete]
        public IActionResult DeteFile(int fileId)
        {
            var delete = SqlSugarHelper.Instance.Deleteable<EntityFiles>().Where(new EntityFiles() { FileId = fileId }).ExecuteCommand();
            if (delete > 0)
            {
                return Ok(new { code = 200, msg = "删除成功！" });
            }
            return Ok(new { code = 400, msg = "删除失败！" });
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}