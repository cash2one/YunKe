﻿using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace YunKe.AdminPanelCore.Models
{
    /// <summary>
    /// 用户DTO
    /// </summary>
    public class UserDto
    {
        public bool IsSuperMan;

        /// <summary>
        /// 用户ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDateTime { get; set; }

        /// <summary>
        /// 用户拥有的角色
        /// </summary>
        public virtual IList<UserRoleDto> UserRoles { get; set; }
    }
}
