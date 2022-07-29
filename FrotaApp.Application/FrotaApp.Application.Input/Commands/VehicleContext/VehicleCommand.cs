using FrotaApp.Application.Input.Commands.Interfaces;
using FrotaApp.Domain.Enums;

namespace FrotaApp.Application.Input.Commands.VehicleContext
{
    public class VehicleCommand : ICommand
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int ModelYear { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public EVehicleType Type { get; set; }
    }
}