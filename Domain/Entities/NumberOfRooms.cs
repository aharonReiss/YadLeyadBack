using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NumberOfRooms
    {
        [Key]
        public int NumberOfRoomsId { get; set; }
        public string NumberOfRoomsName { get; set; }
    }
}
