using Appilcation.Interfaces;
using Appilcation.Models;
using Appilcation.Utils;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IPropertyRepository _propertyRepository;

        public PropertyService(IHttpContextAccessor httpContextAccessor, IPropertyRepository propertyRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _propertyRepository = propertyRepository;
        }
        public async Task<bool> AddProperty(AddPropertyModel addPropertyModel)
        {
            var token = _httpContextAccessor.HttpContext?.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            long userId = JwtMethods.GetUserIdFromJWT(token);
            var propertyId = await _propertyRepository.AddProperty(addPropertyModel, userId);
            await _propertyRepository.AddPropertyDetail(addPropertyModel, propertyId);
            if (addPropertyModel.CategoryType == 5)
                await _propertyRepository.AddPropertyShabatDetails(addPropertyModel, propertyId);
            return true;
        }
    }
}
