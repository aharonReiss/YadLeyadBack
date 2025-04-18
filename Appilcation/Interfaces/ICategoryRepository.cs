using Appilcation.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategoriesList();
        Task<Category> GetCategoryDetails(int categoryNumber);
        Task<List<Fields>> GetFields();
        Task<List<LevelsForCategory>> GetLevelsForCategory(int categoryNumber);
        Task<List<OptionsModel>> GetPropertyType();
        Task<List<OptionsModel>> GetRoomsNumbers();
        Task<List<OptionsModel>> GetFurniture();
        Task<List<OptionsModel>> GetPropertyConditions();
    }
}
