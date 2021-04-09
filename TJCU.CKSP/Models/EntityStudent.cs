using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TJCU.ZHl.CKSP.Models
{
    /// <summary>
    /// 用户表实体
    /// </summary>
    [Serializable]
    [DataContract]
    [SugarTable("CKSP_STUDENT")]
    public class EntityStudent
    {
        /// <summary>
        /// 学生编号
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "STUDENT_ID", IsPrimaryKey = true, IsIdentity = false)]
        public long? StudentId { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "STUDENT_NAME")]
        public string StudentName { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "STUDENT_AGE")]
        public int? StudentAge { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "STUDENT_SEX")]
        public int? StudentSex { get; set; }

        /// <summary>
        /// 所属专业
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "MAJOR_ID")]
        public int? MajorId { get; set; }

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
        [SugarColumn(ColumnName = "STUDENT_PASSWORD")]
        public string StudentPassword { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
    }
}
