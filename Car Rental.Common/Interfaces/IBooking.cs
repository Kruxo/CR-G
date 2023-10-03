using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    public string RegNo { get; set; }
    public string Customer { get; set; }
    public int KmRented { get; set; }
    public int KmReturned { get; set; }
    public DateTime DaysRented { get; set; }
    public DateTime DaysReturned { get; set; }
    public int Cost { get; set; }  
    public BookingStatuses Status { get; set; }

    void ReturnVehicle();
   
}
