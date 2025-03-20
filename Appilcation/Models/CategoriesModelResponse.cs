using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Models
{
    public class CategoriesModelResponse
    {
        public int CategoryNumber { get; set; }
        public int Priority { get; set; }
        public string CategoryName { get; set; }
        public List<CityModel> Cities { get; set; }
    }
}
