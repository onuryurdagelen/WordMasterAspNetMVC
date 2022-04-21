﻿using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LanguageRepository:RepositoryBase<Language>, ILanguageRepository
    {
        public LanguageRepository(WordMasterDbContext context):base(context)
        {
        }

    
    }
}
