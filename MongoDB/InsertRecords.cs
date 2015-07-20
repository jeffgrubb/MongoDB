using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB
{
    public class InsertRecords : IMongoTestTask
    {
        public void Run(MongoDatabase database)
        {
            var collection = database.GetCollection("foobar");

            for (int i = 1; i < 100000; i++)
            {
                BsonDocument document = new BsonDocument
                {
                    { "foo", i }
                };

                var task = collection.InsertOneAsync(document);
                task.Wait();

                Console.WriteLine("Inserted: " + i);
            }
        }
    }
}
