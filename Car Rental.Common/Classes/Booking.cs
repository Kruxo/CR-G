using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{
    public string RegNo { get; set; }
    public string Customer { get; set; }
    public int KmRented { get; set; }
    public int KmReturned { get; set; }
    public DateTime DaysRented { get; set; }
    public DateTime DaysReturned { get; set; }
    public int Cost { get; set; }
    public BookingStatuses Status { get; set; }

    public Booking(string regNo, string customer, int kmRented, int kmReturned, DateTime daysRented, DateTime daysReturned, int cost, BookingStatuses status)
    {
        RegNo = regNo;
        Customer = customer;
        KmRented = kmRented;
        KmReturned = kmReturned;
        DaysRented = daysRented;
        DaysReturned = daysReturned;
        Cost = cost;
        Status = status;
    }

    public void ReturnVehicle(IVehicle vehicle, DateTime daysRented, DateTime daysReturned, int kmRented)
    {

        int rented = (int)(daysReturned - daysRented).TotalDays;

        double Cost = rented * vehicle.CostDay + kmRented * vehicle.CostKm;
    }


    public void ReturnVehicle()
    {
        throw new NotImplementedException();
    }
}
