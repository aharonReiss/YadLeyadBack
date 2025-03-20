using Appilcation.Interfaces;
using Appilcation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ApartmentFiltersRepository : IApartmentFiltersRepository
    {
        private readonly ApplicationDbContext _context;
        public ApartmentFiltersRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<CityModel>> GetCities()
        {
            return await _context.Cities.Select(c => new CityModel
            {
                CityId = c.CityID,
                CityName = c.CityName
            }).ToListAsync();
        }
    }
}
