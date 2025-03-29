using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyCondition
    {
        [Key]
        public int PropertyConditionId { get; set; }
        public string PropertyConditionDescription { get; set; }
    }
}
