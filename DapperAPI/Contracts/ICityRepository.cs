using DapperAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAPI.Contracts
{
    public interface ICityRepository
    {
        public Task<IEnumerable<City>> GetCities();

        public Task<City> GetCity(int id);
    }
}
