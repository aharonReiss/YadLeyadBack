using Appilcation.Interfaces;
using Appilcation.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public async Task<List<StepCategoriesModel>> GetStepsByCategory(int categoryNumer)
        {
            List<StepCategoriesModel> stepCategoriesModels = new List<StepCategoriesModel>();
            var categoryLevels = await _categoryRepository.GetLevelsForCategory(categoryNumer);
            var fields = await _categoryRepository.GetFields();
            foreach(var catLevel in categoryLevels)
            {
                var fieldsPerCategory = fields.Where(f => catLevel.Fields.Split(',')
                                  .Select(int.Parse)
                                  .Contains(f.FieldId)).Select(f => new FieldModel
                                  {
                                      FieldType = f.FieldType,
                                      Label = f.Label,
                                      Name = f.Name,
                                      PlaceHolder = f.PlaceHolder,
                                      Required = f.Reqired,
                                      Title = f.Title,
                                      Options = f.FieldType == 2 ? GetOptionsByFieldName(f.Name).Result : null
                                  }).ToList();

                stepCategoriesModels.Add(new StepCategoriesModel
                {
                    LevelTitle = catLevel.LevelTitle,
                    Fields = fieldsPerCategory
                });
            }
            return stepCategoriesModels;
        }
        public async Task<List<OptionsModel>> GetOptionsByFieldName(string fieldName)
        {
            switch (fieldName)
            {
                case "numberOfRoomsId":
                    return await _categoryRepository.GetRoomsNumbers();
                    break;
                case "propertyTypeId":
                    return await _categoryRepository.GetPropertyType();
                    break;
                case "furniture":
                    return await _categoryRepository.GetFurniture();
                    break;
                case "propertyConditionId":
                    return await _categoryRepository.GetPropertyConditions();
                    break;
                default:
                    return null;
                    break;
            }

        }
        public async Task<List<CategoriesModelResponse>> GetCategoriesList()
        {
            List<Category> categoriesFromDb = await _categoryRepository.GetCategoriesList();
            List<CityModel> cities = await _apartmentFiltersRepository.GetCities();
            return categoriesFromDb.Select(c => new CategoriesModelResponse
            {
                CategoryName = c.CategoryName,
                CategoryNumber = c.CategoryId,
                Priority = c.Priority,
                Cities = cities
            }).OrderBy(c => c.Priority).ToList();

        }
    }
}
