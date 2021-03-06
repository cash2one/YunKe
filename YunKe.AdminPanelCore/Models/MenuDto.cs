﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using YunKe.Infrastructure.Extentions;
using YunKe.AdminPanelCore.Enum;

namespace YunKe.AdminPanelCore.Models
{
    /// <summary>
    /// 菜单模型
    /// </summary>
    public class MenuDto
    {
        /// <summary>
        /// 菜单ID
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 上级ID
        /// </summary>
        [DisplayName("上级菜单")]
        public string ParentId { get; set; }

        /// <summary>
        /// 上级菜单名称
        /// </summary>
        [DisplayName("上级菜单")]
        public string ParentName { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [DisplayName("菜单名称"), Required, MinLength(2), MaxLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [DisplayName("菜单网址"), Required, MaxLength(300)]
        public string Url { get; set; }

        /// <summary>
        /// 排序越大越靠后
        /// </summary>
        [DisplayName("排序数字")]
        public int Order { get; set; }

        /// <summary>
        /// 菜单类型
        /// </summary>
        [DisplayName("菜单类型")]
        public MenuType Type { get; set; }

        /// <summary>
        /// 菜单类型名称
        /// </summary>
        public string TypeName
        {
            get { return Type.ToDescription(); }
        }
    }
}
