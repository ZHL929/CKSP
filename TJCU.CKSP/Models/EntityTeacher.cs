using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TJCU.CKSP.Models
{
    /// <summary>
    /// 老师实体表
    /// </summary>
    [Serializable]
    [DataContract]
    [SugarTable("CKSP_TEACHER")]
    public class EntityTeacher
    {
        /// <summary>
        /// 老师编号
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "TEACHER_ID", IsPrimaryKey = true, IsIdentity = false)]
        public int? TeacherId { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "TEACHER_NAME")]
        public string TeacherName { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "TEACHER_AGE")]
        public int? TeacherAge { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "TEACHER_SEX")]
        public int? TeacherSex { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "PROFESSIONAL_TITLE")]
        public int? ProfessionalTitle { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "INTRODUCTION")]
        public string Introduction { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "TEACHER_PASSWORD")]
        public string TeacherPassword { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
 
    }
}
