using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB
{
    public class CountRecords : IMongoTestTask
    {
        public void Run(MongoDatabase database)
        {
            var collection = database.GetCollection("foobar");

            var temp = collection.CountAsync(new BsonDocument()); // no filter

            temp.Wait();
            var count = temp.Result;

            Console.WriteLine("Count: " + count);
        }
    }
}
