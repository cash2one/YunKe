﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YunKe.AdminPanelCore.Models
{
    /// <summary>
    /// 用户DTO
    /// </summary>
    public class UserAddDto
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [DisplayName("登录账号"), Required, MinLength(4), MaxLength(20)]
        [RegularExpression("^[^_][a-zA-Z0-9_]*$",ErrorMessage = "登录账号必须是字母、数字或者下划线的组合")]
        public string LoginName { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        [DisplayName("真实姓名"), Required, MinLength(2), MaxLength(20)]
        public string RealName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [DisplayName("邮箱"), Required, MinLength(5), MaxLength(36)]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$",ErrorMessage = "请输入正确的邮箱地址")]
        public string Email { get; set; }

        ///<summary>
        /// 密码
        ///</summary>
        [DisplayName("登录密码")]
        [Required, MinLength(6), MaxLength(12)]
        public string Password { get; set; }

        ///<summary>
        /// 确认密码
        ///</summary>
        [DisplayName("确认密码")]
        [Required, MinLength(6), MaxLength(12), Compare("Password")]
        public string ConfirmPwd { get; set; }
    }
}
