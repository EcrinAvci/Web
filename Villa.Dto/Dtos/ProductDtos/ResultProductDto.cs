﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Villa.Dto.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public ObjectId Id { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public int BedroomCount { get; set; }
        public int BathroomCount { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public int ParkingCounts { get; set; }
    }
}
