namespace Car_Rental.Common.Interfaces;

public interface IVehicle
{
    public string RegNo { get; set; }
    public string CarMake { get; set; }
    public string OdoMeter { get; set; }
    public string CostKm { get; set; }
    public string VType { get; set; }
    public string CostDay { get; set; }
    public int VStatus { get; set; }

}
