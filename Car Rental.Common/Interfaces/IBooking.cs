using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    public string RegNo { get; set; }
    public string Customer { get; set; }
    public double KmRent { get; set; }
    public double KmReturned { get; set; }
    public DateTime StartRent { get; set; }
    public DateTime EndRent { get; set; }
    //public double Cost { get; set; }  
    public BookingStatuses Status { get; set; }

    void ReturnVehicle();

    public double GetCost();

    public void CalculateCost();

}
