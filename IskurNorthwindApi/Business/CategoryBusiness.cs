using System.Collections.Generic;
using IskurNorthwindApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace IskurNorthwindApi.Business
{
    public class CategoryBusiness : ICategoryService
    {
        private readonly DbContext _dbContext;

        public CategoryBusiness(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _dbContext.Set<Category>();
        }
    }
}
