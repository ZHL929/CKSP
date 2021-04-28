using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TJCU.CKSP.Models
{
    /// <summary>
    /// 用户表实体
    /// </summary>
    [Serializable]
    [DataContract]
    [SugarTable("CKSP_ADMIN")]
    public class EntityAdmin
    {
        /// <summary>
        /// 编号
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "ADMIN_ID", IsPrimaryKey = true, IsIdentity = false)]
        public long? AdminId { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "ADMIN_NAME")]
        public string AdminName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "ADMIN_PASSWORD")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "PHONE_NUMBER")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "ADMIN_AGE")]
        public string AdminAge { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "ADMIN_SEX")]
        public string AdminSex { get; set; }
    }
}
