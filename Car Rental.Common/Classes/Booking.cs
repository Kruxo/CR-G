using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{
    public string RegNo { get; set; }
    public string Customer { get; set; }
    public int KmRented { get; set; }
    public int KmReturned { get; set; }
    public string DateRented { get; set; }
    public string DateReturned { get; set; }
    public int Cost { get; set; }
    public int Status { get; set; }

    public Booking(string regNo, string customer, int kmRented, int kmReturned, string dateRented, string dateReturned, int cost, int status)
    {
        RegNo = regNo;
        Customer = customer;
        KmRented = kmRented;
        KmReturned = kmReturned;
        DateRented = dateRented;
        DateReturned = dateReturned;
        Cost = cost;
        Status = status;
    }

    public void ReturnVehicle(IVehicle vehicle)
    {
        // Assign values to the class' properties with values from the vehicle parameter 
        // Cost = days * vehicle.CostDay + km * vehicle.CostKm; 

    }
}
