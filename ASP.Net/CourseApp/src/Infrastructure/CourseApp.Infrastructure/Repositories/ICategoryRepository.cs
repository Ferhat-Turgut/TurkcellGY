﻿using CourseApp.Entities;
using CourseApp.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Infrastructure.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
    }
}
