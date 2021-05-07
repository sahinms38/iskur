using System.Collections.Generic;
using IskurNorthwindApi.Models.Entities;

namespace IskurNorthwindApi.Business
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
    }
}