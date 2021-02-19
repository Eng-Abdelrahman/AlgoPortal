using Data.Domain;
using Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Implementation
{
    public class ItemRepo : GenericRepository<Item> , IItemRepo
    {
        private readonly DbContext _dbContext;
        public ItemRepo(DbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }



    }
}
