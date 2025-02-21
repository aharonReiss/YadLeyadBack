using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyForShabatDetail
    {
        [Key]
        public long PropertyForShabatDetailId { get; set; }
        public long PropertyDetailId { get; set; }
        [ForeignKey("PropertyDetailId")]
        public PropertyDetail PropertyDetail { get; set; }
        public int CountBeds { get; set; }
        public int ParashaId { get; set; }

    }
}
