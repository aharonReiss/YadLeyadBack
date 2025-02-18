using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class StreetToNeighborhood
    {
        [Key]
        public int Id { get; set; }
        public int StreetId { get; set; }
        public int NeighborhoodId { get; set; }
        public int CityId { get; set; }
    }
}
