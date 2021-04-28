using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TJCU.CKSP.Models
{
    /// <summary>
    /// 专业实体类
    /// </summary>
    [Serializable]
    [DataContract]
    [SugarTable("CKSP_MAJOR")]
    public class EntityMajor
    {
        /// <summary>
        /// 专业编号
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "MAJOR_ID", IsPrimaryKey = true, IsIdentity = false)]
        public int? MajorId { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "MAJOR_NAME")]
        public string MajorName { get; set; }

        /// <summary>
        /// 所属学院
        /// </summary>
        [DataMember]
        [SugarColumn(ColumnName = "INSTITUTE_ID")]
        public int? InstituteId { get; set; }
    }
}
