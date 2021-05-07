using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IskurNorthwindApi.Business;
using IskurNorthwindApi.Contexts;
using IskurNorthwindApi.Infrastructure;
using IskurNorthwindApi.Models.Entities;

namespace IskurNorthwindApi.Controllers
{
    public class CategoriesController : ApiControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categories = _categoryService.GetAllCategories();

            return Ok(categories);
        }
    }
}
