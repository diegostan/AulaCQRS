using System.Data;
using FrotaApp.Application.Input.Repositories;
using FrotaApp.Domain.Entities;
using FrotaApp.Infrastructure.Input.Queries;
using Dapper;
using FrotaApp.Infrastructure.Shared.Factory;

namespace FrotaApp.Infrastructure.Input.Repositories
{
    public class WriteVehicleRepository : IWriteVehicleRepository
    {
        private readonly IDbConnection _connection;
        public WriteVehicleRepository(SqlFactory factory)
        {
            _connection = factory.SqlConnection();
        }
        public void InsertVehicle(VehicleEntity vehicle)
        {
            var query = new VehicleQuery().InsertVehicleQuery(vehicle);

            try
            {
                using (_connection)
                {
                    _connection.Execute(query.Query, query.Parameters);
                }
            }
            catch
            {
                throw new Exception("Erro ao inserir veiculo");
            }

        }
    }
}