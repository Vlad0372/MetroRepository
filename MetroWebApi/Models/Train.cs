﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroWebApi.Models
{
    public class Train
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }    
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}