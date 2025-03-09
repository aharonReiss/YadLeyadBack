using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyDetail
    {
        [Key]
        public long PropertyDetailId { get; set; }
        public long PropertyId { get; set; }
        public int NumberOfRoomsId { get; set; }
        public bool IsPrivateHouse { get; set; }
        public int PorchCount { get; set; }
        public bool IsThereSukaPorch { get; set; }
        public bool IsThereParcking { get; set; }
        public bool IsThereWarehouse { get; set; }
        public bool IsThereOptions { get; set; }
        public bool IsThereLandscape { get; set; }
        public int PropertySizeInMeters { get; set; }
        public int Floor { get; set; }
        public bool IsTherElevator { get; set; }
        public double? Price { get; set; }
        public bool IsThereSafeRoom { get; set; }
        public bool IsFurnished { get; set; }
        public bool IsMediation { get; set; }
    }
}
