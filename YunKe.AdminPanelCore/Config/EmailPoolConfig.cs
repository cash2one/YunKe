﻿/*******************************************************************************
* Copyright (C) JuCheap.Com
* 
* Author: dj.wong
* Create Date: 09/04/2015 11:47:14
* Description: Automated building by service@JuCheap.com 
* 
* Revision History:
* Date         Author               Description
*
*********************************************************************************/

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using YunKe.AdminPanelCore.Entity;

namespace YunKe.AdminPanelCore.Config
{
    /// <summary>
    /// 邮件表配置
    /// </summary>
    public class EmailPoolConfig : EntityTypeConfiguration<EmailPoolEntity>
    {
        public EmailPoolConfig()
        {
            ToTable("EmailPool");
            HasKey(item => item.Id);
            Property(item => item.Id).HasColumnType("varchar").HasMaxLength(20);
            Property(item => item.Title).HasColumnType("varchar").IsRequired().HasMaxLength(100);
            Property(item => item.Content).HasColumnType("text").IsRequired();
            Property(item => item.FailTimes).IsRequired();
        }
    }
}
