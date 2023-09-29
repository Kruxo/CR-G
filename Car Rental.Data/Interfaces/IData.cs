using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Data.Interfaces;

public interface IData
{
    public IEnumerable<IPerson> GetCustomers();
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default);
    public IEnumerable<IBooking> GetBookings();

    //IPerson GetPerson(string socialSecurityNumber);
    //IPerson GetPerson(int id);
    //IVehicle GetVehicle(string registrationNumber);
    //IVehicle GetVehicle(int id);
    //IBooking GetBooking(int vehicleId);
}