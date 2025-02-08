using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Interfaces
{
    public interface IValidationService
    {
        bool IsValidEmail(string mail);
        bool IsValidPassword(string password);
        bool IsValidTelephone(string telephone);
        bool ThereIsValue(string input);
    }
}
