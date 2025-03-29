using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Models
{
    public class AddPropertyModel
    {
        public int CategoryType { get; set; }
        public string AddressCityStreet { get; set; }
        public int? HouseNumber { get; set; }
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
        public string FullName { get; set; }
        public string PhoneNumbers { get; set; }
        public int? PropertyTax { get; set; }
        public int? HouseCommittee { get; set; }
        public bool? IsThereAirCondition { get; set; }
        public int? PropertyTypeId { get; set; }
        public int? PropetyConditionId { get; set; }
        public PropertyForShabatDetailsDTO? PropertyForShabatDetails { get; set; }
    }
}
