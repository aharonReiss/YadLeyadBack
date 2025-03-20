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
        private readonly IApartmentFiltersRepository _apartmentFiltersRepository;
        public CategoryService(ICategoryRepository categoryRepository,IApartmentFiltersRepository apartmentFiltersRepository) 
        {
            _apartmentFiltersRepository = apartmentFiltersRepository;
            _categoryRepository = categoryRepository;
        }
        public async Task<List<CategoriesModelResponse>> GetCategoriesList()
        {
            List<Category> categoriesFromDb = await _categoryRepository.GetCategoriesList();
            List<CityModel> cities = await _apartmentFiltersRepository.GetCities();
            return categoriesFromDb.Select(c => new CategoriesModelResponse 
            { 
                CategoryName  = c.CategoryName,
                CategoryNumber = c.CategoryId,
                Priority = c.Priority,
                Cities  = cities
            }).OrderBy(c => c.Priority).ToList();

        }
    }
}
