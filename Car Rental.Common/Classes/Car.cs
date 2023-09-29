using Car_Rental.Common.Interfaces;


namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    public string RegNo { get; set; }
    public string CarMake { get; set; }
    public string OdoMeter { get; set; }
    public string CostKm { get; set; }
    public string VType { get; set; }
    public string CostDay { get; set; }
    public int VStatus { get; set; }

    public Car(string regNo, string carMake, string odoMeter, string costKm, string vType, string costDay, int vStatus)
    {
        RegNo = regNo;
        CarMake = carMake;
        OdoMeter = odoMeter;
        CostKm = costKm;
        VType = vType;
        CostDay = costDay;
        VStatus = vStatus;
    }

}
