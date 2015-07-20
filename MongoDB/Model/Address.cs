using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Options;
using MongoDB.Bson.Serialization.Serializers;


namespace MongoDB.Model
{
    public class Address
    {
        [BsonElement]
        public string Line1 { get; set; }
        
        [BsonElement]
        public string Line2 { get; set; }

        [BsonElement]
        public string City { get; set; }

        [BsonElement]
        public string County { get; set; }

        [BsonElement]
        public string State { get; set; }   
    }
}
