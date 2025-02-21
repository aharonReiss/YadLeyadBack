using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PhoneNumber
    {
        [Key]
        public int PhoneNumberId { get; set; }
        public string Phone { get; set; }
        public long PropertyDetailId { get; set; }
        [ForeignKey("PropertyDetailId")]
        public PropertyDetail PropertyDetail { get; set; }
    }
}
