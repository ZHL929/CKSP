using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TJCU.CKSP.Models
{
    /// <summary>
    /// 存储文件的实体类
    /// </summary>    
    [SugarTable("CKSP_FILE")]
    public class EntityFiles
    {
        /// <summary>
        /// 文件编号
        /// </summary>
        [SugarColumn(ColumnName = "FILE_ID", IsPrimaryKey = true, IsIdentity = false)]
        public long? FileId { get; set; }

        /// <summary>
        /// 文件标题
        /// </summary>
        [SugarColumn(ColumnName = "FILE_NAME")]
        public string FileName { get; set; }
       
        /// <summary>
        /// 文件路径
        /// </summary>
        [SugarColumn(ColumnName = "FILE_URL")]
        public string FileURL { get; set; }

        /// <summary>
        /// 文件上传时间
        /// </summary>
        [SugarColumn(ColumnName = "FILE_TIME")]
        public DateTime? FileTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string FileTimeStr
        {

            get
            {
                if (FileTime != null)
                {
                    return FileTime.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 文件上传人
        /// </summary>
        [SugarColumn(ColumnName = "UPLOAD_NAME")]
        public string UploadName { get; set; }

        /// <summary>
        /// 课程编号
        /// </summary>
        [SugarColumn(ColumnName = "COURSE_ID")]
        public long? CourseId { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [SugarColumn(ColumnName = "STATUS")]
        public int? Status { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string StatusStr
        {

            get
            {
                if (Status >= 0)
                {
                    return ((EnumFileStatus)this.Status).ToString();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
