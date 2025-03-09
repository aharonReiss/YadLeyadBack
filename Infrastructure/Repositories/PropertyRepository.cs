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
            var result = _context.Properties.Add(new Domain.Entities.Property 
            { 
                AdressNumber = 0,
                CityId = addPropertyModel.CityId,
                HouseNumber = addPropertyModel.HouseNumber,
                StreeId = addPropertyModel.StreetId,
                UserId = userId
            });
            await _context.SaveChangesAsync();
            return result.Entity.ProprtyId;
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
                PropertySizeInMeters = addPropertyModel.PropertySizeInMeters
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
