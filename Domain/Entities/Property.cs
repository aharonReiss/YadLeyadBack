using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Property
    {
        [Key]
        public long ProprtyId { get; set; }
        public int CityId { get; set; }
        public int StreeId { get; set; }
        public int? AdressNumber { get; set; }
        public int? HouseNumber { get; set; }
        public long UserId { get; set; }
    }
}
