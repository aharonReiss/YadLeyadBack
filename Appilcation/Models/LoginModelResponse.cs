using Appilcation.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Models
{
    public class LoginModelResponse
    {
        public UserDTO User { get; set; }
        public string Token { get; set; }
    }
}
