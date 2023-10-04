using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using System;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{
    public string RegNo { get; set; }
    public string Customer { get; set; }
    public double KmRent { get; set; }
    public double KmReturned { get; set; }
    public DateTime StartRent { get; set; }
    public DateTime EndRent { get; set; }
    //public double Cost { get; set; }
    public BookingStatuses Status { get; set; }

    public Booking(string regNo, string customer, double kmRent, double kmReturned, DateTime startRent, DateTime endRent, BookingStatuses status)
    {
        RegNo = regNo;
        Customer = customer;
        KmRent = kmRent;
        KmReturned = kmReturned;
        StartRent = startRent;
        EndRent = endRent;
        //GetCost(cost);
        Status = status;
    }

    public double _cost;
    /*public IVehicle Vehicle { get; set; } 
    public IBooking Book { get; set; }

    public void CalculateCost()
    {
        ReturnVehicle(Vehicle, Book);
    }*/

    public void ReturnVehicle(IVehicle vehicle, IBooking booking)
    {
        DateTime startDate = new DateTime(2023, 10, 1);
        DateTime endDate = new DateTime(2023, 11, 4);

        //DateTime startDate = booking.StartRent;
        //DateTime endDate = booking.EndRent;

        //double daysDifference = (endDate - startDate).TotalDays;

        double daysDifference = DateDifference(startDate, endDate);

        _cost = daysDifference * vehicle.CostDay + booking.KmReturned * vehicle.CostKm;

    }
    public static double DateDifference(DateTime startDate, DateTime endDate)
    {
        TimeSpan difference = endDate.Subtract(startDate);
        return Math.Round(difference.TotalDays);
    }

    public double GetCost()
    {
        return _cost;
    }

    public void ReturnVehicle()
    {
        throw new NotImplementedException();
    }

    /* public void ReturnVehicle(IVehicle vehicle, DateTime daysRented, DateTime daysReturned, int kmRented)
   {

       int rented = (int)(daysReturned - daysRented).TotalDays;

       double Cost = rented * vehicle.CostDay + kmRented * vehicle.CostKm;
   } */


}

