using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Model;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Options;
using MongoDB.Bson.Serialization.Serializers;


namespace MongoDB
{
    public class InsertRetrieveRecordFromObject : IMongoTestTask
    {
        public void Run(MongoDatabase database)
        {
            var collection = database.GetCollection("addresses");

            BsonClassMap.RegisterClassMap<Address>();

            var address = new Address();
            address.Line1 = "123 Main Street";
            address.Line2 = "";
            address.City = "New City";
            address.County = "Bergen";
            address.State = "New Jersey";

            // I feel like this is cheating.. Need to figure out how to actually serialize an object into a bson document, instead of
            // serializing into a byte array and then deserializing to a BsonDocument.
            var bson = address.ToBson();

            var doc = BsonSerializer.Deserialize<BsonDocument>(bson);
            
            var insert_task = collection.InsertOneAsync(doc);
            insert_task.Wait();

            Console.WriteLine("Inserted address");
            
            var count_task = collection.CountAsync(new BsonDocument()); // no filter

            count_task.Wait();
            var count = count_task.Result;

            Console.WriteLine("Count: " + count);
        }
    }
}
