﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MetroWebApi.Models
{
    public class Railway
    {
        public int Id { get; set; }
        public string TrainCode { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DepartureDate { get; set; }
        public double DepartureTime { get; set; }
        public double ArrivalTime { get; set; }
        //public RailwayCarriegeType CarriegeType { get; set; }
        public string CarriegeType { get; set; }
        public int FreePlacesAmount { get; set; }
        public double TicketPrice { get; set; }

    }
    //public enum RailwayCarriegeType
    //{
    //    Lux,
    //    Compartment ,
    //    ReservedSeat 
    //}
}
