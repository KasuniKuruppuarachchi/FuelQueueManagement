﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FuelQueManagement_Service.Models
{
    public class QueueModel
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string VehicleType { get; set; }
        public string VehicleOwner { get; set; }
        public string? StationsId { get; set; }
        public string? FuelType { get; set; }
        public DateTime? LastModified { get; set; }

        public QueueModel(string vehicleType, int owner, DateTime? lastModified)
        {
            VehicleType = vehicleType;
            VehicleOwner = VehicleOwner;
            LastModified = lastModified;
        }

        public QueueModel()
        {
        }
    }
}
