using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class LevelsForCategory
    {
        [Key]
        public int LevelId { get; set; }
        public string LevelTitle { get; set; }
        public int CtegoryNumber { get; set; }
        public string Fields { get; set; }
    }
}
