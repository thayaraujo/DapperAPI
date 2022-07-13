using Dapper;
using DapperAPI.Context;
using DapperAPI.Contracts;
using DapperAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperAPI.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly DapperContext _context;

        public CityRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetCities()
        {
            var query = "Select Id, Name, Population from Cities";

            //abrir conexão segura com o banco
            using (var connection = _context.CreateConnection())
            {
                var cities = await connection.QueryAsync<City>(query);
                return cities;
            }
        }

        public async Task<City> GetCity(int id)
        {
            var query = "Select Id, Name, Population from Cities Where Id = @id";

            //abrir conexão segura com o banco
            using (var connection = _context.CreateConnection())
            {
                var city = await connection.QuerySingleAsync<City>(query, new { id });
                return city;
            }
        }
    }
}
