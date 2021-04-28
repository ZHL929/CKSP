using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TJCU.CKSP.Models
{
    /// <summary>
    /// 学院实体类
    /// </summary>
    [SugarTable("CKSP_INSTITUTE")]
    public class EntityInstitute
    {
        /// <summary>
        /// 学院编号
        /// </summary>
        [SugarColumn(ColumnName = "INSTITUTE_ID", IsPrimaryKey = true, IsIdentity = false)]
        public int? InstituteId { get; set; }

        /// <summary>
        /// 学院名
        /// </summary>
        [SugarColumn(ColumnName = "INSTITUTE_NAME")]
        public string InstituteName { get; set; }

    }
}
