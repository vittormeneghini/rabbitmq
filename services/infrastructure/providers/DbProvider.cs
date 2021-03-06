using System.Data;
using System.Data.SqlClient;
using Microservices.Services.Core.Providers;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace Microservices.Services.Infrastructure.Providers
{
    public class DbProvider : IDbProvider
    {
        private readonly IConfiguration _config;

        public DbProvider(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Get or set the db connection of a microservice
        /// </summary>
        /// <value></value>
        public IDbConnection Connection
        {
            get { return new SqlConnection(_config.GetConnectionString("DapperConnectionString")); }
        }
    }
}