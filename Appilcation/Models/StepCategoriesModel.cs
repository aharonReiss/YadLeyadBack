using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Models
{
    public class StepCategoriesModel
    {
        public string LevelTitle { get; set; }
        public List<FieldModel> Fields { get; set; }
    }
}
