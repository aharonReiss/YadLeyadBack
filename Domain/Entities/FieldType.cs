﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class FieldType
    {
        [Key]
        public int FieldTypeId { get; set; }
        public string FieldTypeName { get; set; }
    }
}
