namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    public string RegNo { get; set; }
    public string Customer { get; set; }
    public int KmRented { get; set; }
    public int KmReturned { get; set; }
    public string DateRented { get; set; }
    public string DateReturned { get; set; }
    //public int Cost { get; set; }  kostnaden tas fram i klassen med hjälp av beräkning för returnvehicle 
    public int Status { get; set; }

    void ReturnVehicle();
   
}
