using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TJCU.CKSP.Models
{
    /// <summary>
    /// 文件审核状态枚举类
    /// </summary>
    public enum EnumFileStatus
    {
        /// <summary>
        /// 待审核为0
        /// </summary>
        待审核 = 0,
        /// <summary>
        /// 审核通过为1
        /// </summary>
        审核通过 = 1,
        /// <summary>
        /// 作废为2
        /// </summary>
        作废=2

      
    }
}
