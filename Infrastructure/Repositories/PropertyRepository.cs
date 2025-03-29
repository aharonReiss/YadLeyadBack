using Appilcation.Interfaces;
using Appilcation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly ApplicationDbContext _context;
        public PropertyRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<long> AddProperty(AddPropertyModel addPropertyModel, long userId)
        {
            int[] address = addPropertyModel.AddressCityStreet.Split('_')
                             .Select(int.Parse)
                             .ToArray();
            var result = _context.Properties.Add(new Domain.Entities.Property 
            { 
                AdressNumber = 0,
                CityId = address[0],
                HouseNumber = addPropertyModel.HouseNumber,
                StreeId = address[1],
                UserId = userId
            });
            await _context.SaveChangesAsync();
            return result.Entity.ProprtyId;
        }
        public async Task<bool> AddPhoneNumbers(AddPropertyModel addPropertyModel, long PropertyId)
        {
            var phones = addPropertyModel.PhoneNumbers.Split(";");
;           foreach (var phone in phones)
            {
                _context.PhoneNumbers.Add(new Domain.Entities.PhoneNumber
                {
                    Phone = phone,
                    PropertyDetailId = PropertyId
                });
            }
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<long> AddPropertyDetail(AddPropertyModel addPropertyModel, long PropertyId)
        {
            var result = _context.PropertyDetails.Add(new Domain.Entities.PropertyDetail
            {
                Floor = addPropertyModel.Floor,
                IsFurnished = addPropertyModel.IsFurnished,
                IsMediation = addPropertyModel.IsMediation,
                IsPrivateHouse = addPropertyModel.IsPrivateHouse,
                IsThereLandscape = addPropertyModel.IsThereLandscape,
                IsTherElevator = addPropertyModel.IsTherElevator,
                IsThereOptions = addPropertyModel.IsThereOptions,
                IsThereParcking =  addPropertyModel.IsThereParcking,
                IsThereSafeRoom = addPropertyModel.IsThereSafeRoom,
                IsThereSukaPorch = addPropertyModel.IsThereSukaPorch,
                IsThereWarehouse = addPropertyModel.IsThereWarehouse,
                NumberOfRoomsId = addPropertyModel.NumberOfRoomsId,
                PorchCount = addPropertyModel.PorchCount,
                Price = addPropertyModel.Price,
                PropertyId = PropertyId,
                PropertySizeInMeters = addPropertyModel.PropertySizeInMeters,
                FullName = addPropertyModel.FullName,
                HouseCommittee = addPropertyModel.HouseCommittee,
                IsThereAirCondition = addPropertyModel.IsThereAirCondition,
                PropertyTax = addPropertyModel.PropertyTax,
                PropertyTypeId = addPropertyModel.PropertyTypeId,
                PropertyConditionId = addPropertyModel.PropetyConditionId
            });
            await _context.SaveChangesAsync();
            return result.Entity.PropertyDetailId;
        }

        public async Task<long> AddPropertyShabatDetails(AddPropertyModel addPropertyModel, long PropertyId)
        {
            var result = _context.PropertyForShabatDetails.Add(new Domain.Entities.PropertyForShabatDetail
            {
                CountBeds = addPropertyModel.PropertyForShabatDetails.CountBads,
                ParashaId = addPropertyModel.PropertyForShabatDetails.ParashaId,
                PropertyDetailId = PropertyId
            });
            await _context.SaveChangesAsync();
            return result.Entity.PropertyForShabatDetailId;
        }
    }
}
