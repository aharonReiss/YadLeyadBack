using Appilcation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoriesModelResponse>> GetCategoriesList();
        Task<CategoryStepModel> GetStepsByCategory(int categoryNumer);
        Task<List<OptionsModel>> GetOptionsByFieldName(string fieldName);
    }
}
