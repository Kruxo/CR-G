﻿using Car_Rental.Common.Enums;
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
    public BookingStatuses Status { get; set; }

    public Booking(string regNo, string customer, double kmRent, double kmReturned, DateTime startRent, DateTime endRent, BookingStatuses status)
    {
        RegNo = regNo;
        Customer = customer;
        KmRent = kmRent;
        KmReturned = kmReturned;
        StartRent = startRent;
        EndRent = endRent;
        Status = status;
    }

    private double _cost;

    public void ReturnVehicle(IVehicle vehicle, IBooking booking)
    {
        //Test
        //DateTime startDate = new DateTime(2023, 10, 1);
        //DateTime endDate = new DateTime(2023, 10, 4);

        DateTime startDate = booking.StartRent;
        DateTime endDate = booking.EndRent;

        /*if (startDate == null || endDate == null) 
        {
            return;
        } */

        double daysDifference = Math.Round((endDate - startDate).TotalDays);

        _cost = daysDifference * vehicle.CostDay + booking.KmReturned * vehicle.CostKm;

    }

    public double GetCost(IVehicle vehicle, IBooking booking)
    {
        ReturnVehicle(vehicle, booking);
        return _cost;
    }

    public void ReturnVehicle()
    {
        throw new NotImplementedException();
    }

}

