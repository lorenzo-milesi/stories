﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Stories.Models;

namespace Stories.Data
{
    public class StoriesRepository : Repository<Story>, IRepository<Story>
    {
        public StoriesRepository(StoriesContext context) : base(context)
        {
        }

        public new IEnumerable<Story> Index(int offset, int limit)
        {
            return Table
                .Include(s => s.Project)
                .Include(s => s.Type)
                .Include(s => s.State)
                .Skip(offset).Take(limit).ToList();
        }

        public new Story Find(int id)
        {
            return Table
                .Include(s => s.Project)
                .Include(s => s.Type)
                .Include(s => s.State)
                .Include(s => s.BusinessRules)
                .Include(s => s.Scenarios)
                .FirstOrDefault(s => s.Id == id);
        }
    }
}