using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Threading.Tasks;


namespace DapperAPI.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;

        public DapperContext(IConfiguration config, string connectionString)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection() 
        {
            return new SqlConnection(_connectionString);
        }
    }
}
