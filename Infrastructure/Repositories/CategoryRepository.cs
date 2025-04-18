using Appilcation.Interfaces;
using Appilcation.Models;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetCategoriesList()
        {
            return await _context.Categories.Where(c => c.IsEnable).ToListAsync();
        }
        public async Task<Category> GetCategoryDetails(int categoryNumber)
        {
            return await _context.Categories.Where(c => c.CategoryId == categoryNumber).FirstOrDefaultAsync();
        }
        public async Task<List<Fields>> GetFields()
        {
            return await _context.Fields.ToListAsync();
        }
        public async Task<List<LevelsForCategory>> GetLevelsForCategory(int categoryNumber)
        {
            return await _context.LevelsForCategories.Where(c => c.CtegoryNumber == categoryNumber).ToListAsync();
        }
        public async Task<List<OptionsModel>> GetPropertyType()
        {
            return await _context.PropertyTypes.Select(p => new OptionsModel
            {
                Value = p.PropertyTypeId.ToString(),
                Label = p.PropertyTypeDescription
            }).ToListAsync();
        }
        public async Task<List<OptionsModel>> GetRoomsNumbers()
        {
            return await _context.NumberOfRooms.Select(p => new OptionsModel
            {
                Value = p.NumberOfRoomsId.ToString(),
                Label = p.NumberOfRoomsName
            }).ToListAsync();
        }
        public async Task<List<OptionsModel>> GetFurniture()
        {
            return await _context.Furniture.Select(p => new OptionsModel
            {
                Value = p.FurnitureId.ToString(),
                Label = p.FurnitureDescription
            }).ToListAsync();
        }
        public async Task<List<OptionsModel>> GetPropertyConditions()
        {
            return await _context.PropertyConditions.Select(p => new OptionsModel
            {
                Value = p.PropertyConditionId.ToString(),
                Label = p.PropertyConditionDescription
            }).ToListAsync();
        }
    }
}
