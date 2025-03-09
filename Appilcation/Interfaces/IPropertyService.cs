using Appilcation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Interfaces
{
    public interface IPropertyService
    {
        Task<bool> AddProperty(AddPropertyModel addPropertyModel);
    }
}
