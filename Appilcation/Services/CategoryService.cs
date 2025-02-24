using Appilcation.Interfaces;
using Appilcation.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<CategoriesModelResponse>> GetCategoriesList()
        {
            List<Category> categoriesFromDb = await _categoryRepository.GetCategoriesList();
            return categoriesFromDb.Select(c => new CategoriesModelResponse 
            { 
                CategoryName  = c.CategoryName,
                CategoryNumber = c.CategoryId
            }).ToList();

        }
    }
}
