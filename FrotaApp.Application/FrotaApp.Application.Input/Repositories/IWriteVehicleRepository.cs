using FrotaApp.Domain.Entities;

namespace FrotaApp.Application.Input.Repositories
{
    public interface IWriteVehicleRepository
    {
         void InsertVehicle(VehicleEntity vehicle);
    }
}