using Appilcation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Interfaces
{
    public interface IPropertyRepository
    {
        Task<long> AddProperty(AddPropertyModel addPropertyModel, long userId);
        Task<long> AddPropertyDetail(AddPropertyModel addPropertyModel,long PropertyId);
        Task<long> AddPropertyShabatDetails(AddPropertyModel addPropertyModel, long PropertyId);
        Task<bool> AddPhoneNumbers(AddPropertyModel addPropertyModel, long PropertyId);
    }
}
