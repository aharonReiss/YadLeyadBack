﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Models
{
    public class CategoryStepModel
    {
        public bool IsSupportMediation { get; set; }
        public List<StepCategoriesModel> StepCategoriesModel { get; set; }
    }
}
