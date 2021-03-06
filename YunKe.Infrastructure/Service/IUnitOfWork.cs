﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YunKe.Infrastructure.Service
{
    public interface IUnitOfWork
    {
        DbContext Context { get; }

        void Commit();

        void Rollback();
    }
}
