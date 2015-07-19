using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB
{
    public class MongoDB
    {
        private IMongoDatabase _Database = null;
        private IMongoClient _Client = null;
        private string _ServerAddress = "localhost";
        private string _DatabaseName = "test_db";

        public MongoDB()
        {
            MongoClientSettings settings = new MongoClientSettings();

            settings.Server = new MongoServerAddress(_ServerAddress);
            
            _Client = new MongoClient(settings);

            _Database = _Client.GetDatabase(_DatabaseName);
        }

        public IMongoCollection<BsonDocument> GetCollection(string name)
        {
            var collection = _Database.GetCollection<BsonDocument>(name);

            return collection;
        }
    }
}
