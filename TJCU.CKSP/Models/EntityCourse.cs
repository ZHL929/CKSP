using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TJCU.CKSP.Models
{
    /// <summary>
    /// 课程实体表
    /// </summary>
    [SugarTable("CKSP_COURSE")]
    public class EntityCourse
    {
        /// <summary>
        /// 课程编号
        /// </summary>
        [SugarColumn(ColumnName = "COURSE_ID", IsPrimaryKey = true, IsIdentity = false)]
        public long? CourseId { get; set; }

        /// <summary>
        /// 课程名
        /// </summary>
        [SugarColumn(ColumnName = "COURSE_NAME")]
        public string CourseName { get; set; }

        /// <summary>
        /// 课程学时
        /// </summary>
        [SugarColumn(ColumnName = "COURSE_PERIOD")]
        public int? CoursePeriod { get; set; }

        /// <summary>
        /// 课程资料
        /// </summary>
        [SugarColumn(ColumnName = "COURSE_INFO")]
        public string CourseInfo { get; set; }

        /// <summary>
        /// 所属专业
        /// </summary>
        [SugarColumn(ColumnName = "MAJOR_ID")]
        public int? MajorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(ColumnName = "CREATE_TIME")]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public string CreateTimeStr {

            get {
                if (CreateTime!=null)
                {
                    return CreateTime.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// 状态
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
                    return ((EnumStatus)this.Status).ToString();
                }
                else
                {
                    return null;
                }
            }
        }

    }
    
}
