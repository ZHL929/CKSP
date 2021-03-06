using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TJCU.CKSP.Models
{

    public static class CurrentUser
    {
        /// <summary>
        /// 用户名字
        /// </summary>
        public static string UserName { get; set; }
        
        /// <summary>
        /// 用户角色
        /// </summary>
        public static string UserRole { get; set; }
   
    }
    // public static class CurrentUser
    //  {
    //    #region Initialize

    //    private static IHttpContextAccessor _httpContextAccessor;

    //    private static ISession _session => _httpContextAccessor.HttpContext.Session;

    //    public static void Configure(IHttpContextAccessor httpContextAccessor)
    //    {
    //        _httpContextAccessor = httpContextAccessor;
    //    }

    //    #endregion

    //    #region Attribute

    //    /// <summary>
    //    /// 用户主键
    //    /// </summary>
    //    //public static string UserOID
    //    //{
    //    //    get => _session == null ? "" : _session.GetString("CurrentUser_UserOID");
    //    //    set => _session.SetString("CurrentUser_UserOID", !string.IsNullOrEmpty(value) ? value : "");
    //    //}

    //    /// <summary>
    //    ///用户编号 
    //    /// </summary>
    //    public static long UserId
    //     {
    //         get => _session == null ? 0 : Convert.ToInt64(_session.GetString("CurrentUser_UserId"));
    //         set => _session.SetString("CurrentUser_UserId", value != 0 ? value.ToString() : "0");
    //     }

    //      /// <summary>
    //     /// 用户姓名
    //     /// </summary>
    //     public static string UserName
    //     {
    //         get => _session == null ? "" : _session.GetString("CurrentUser_UserName");
    //        set => _session.SetString("CurrentUser_UserName", !string.IsNullOrEmpty(value) ? value : "");
    //     }

    //     /// <summary>
    //     /// 用户登录账户
    //     /// </summary>
    //     public static string UserAccount
    //     {
    //         get => _session == null ? "" : _session.GetString("CurrentUser_UserAccount");
    //         set => _session.SetString("CurrentUser_UserAccount", !string.IsNullOrEmpty(value) ? value : "");
    //    }

    //     /// <summary>
    //     /// 用户头像地址
    //     /// </summary>
    //     //public static string UserImage
    //     //{
    //     //   get => _session == null ? "" : _session.GetString("CurrentUser_UserImage");
    //     //    set => _session.SetString("CurrentUser_UserImage", !string.IsNullOrEmpty(value) ? value : "");
    //     //}

    //     /// <summary>
    //     /// 用户角色
    //     /// </summary>
    //     public static string UserRole
    //     {
    //         get => _session == null ? "" : _session.GetString("CurrentUser_UserRole");
    //         set => _session.SetString("CurrentUser_UserRole", !string.IsNullOrEmpty(value) ? value : "");
    //     }

    //    /// <summary>
    //    /// 主页地址
    //    /// </summary>
    //    public static string UserPage
    //    {
    //        get => _session == null ? "" : _session.GetString("CurrentUser_UserPage");
    //        set => _session.SetString("CurrentUser_UserPage", !string.IsNullOrEmpty(value) ? value : "");
    //    }

    //    #endregion
    //}


}
