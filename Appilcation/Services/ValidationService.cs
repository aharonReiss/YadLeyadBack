using Appilcation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Appilcation.Services
{
    public class ValidationService : IValidationService
    {
        public bool ThereIsValue(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
        public bool IsValidEmail(string mail)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mail);
            if (match.Success)
                return true;
            return false;
        }

        public bool IsValidPassword(string password)
        {
            return ThereIsValue(password) && password.Length > 6;
        }

        public bool IsValidTelephone(string telephone)
        {
            Regex regex = new Regex(@"^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
            Match match = regex.Match(telephone);
            if (match.Success)
                return true;
            return false;
        }
    }
}
