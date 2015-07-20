using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB
{
    public class CountFilterGT : IMongoTestTask
    {
        public void Run(MongoDatabase database)
        {
            var collection = database.GetCollection("foobar");

            var filter = Builders<BsonDocument>.Filter.Gt("foo", 9999);

            var temp = collection.CountAsync(filter);

            temp.Wait();
            var count = temp.Result;

            Console.WriteLine("Count: " + count);
        }
    }
}
