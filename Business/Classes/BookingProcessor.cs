using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

    public IEnumerable<Customer> GetCustomers()
    {
        return 
    }
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default)
    {

    }
    public IEnumerable<IBooking> GetBookings()
    {

    }

    //BookingProcessor klassens metoder anropar metoder i CollectionData klassen i Data projektet för
    //att hämta data som skickas vidare till gränssnittet i WebAssembly projektet
}
