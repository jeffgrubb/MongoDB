using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB
{
    public class MongoDatabase
    {
        private IMongoDatabase _Database = null;
        private IMongoClient _Client = null;
        private string _ServerAddress = "localhost";
        private string _DatabaseName = "test_db";

        private int _TimeoutMilliseconds = -1;

        public MongoDatabase(string ServerAddress, string DatabaseName)
        {
            _ServerAddress = ServerAddress;
            _DatabaseName = DatabaseName;
        }

        public void Connect()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress(_ServerAddress);

            if(_TimeoutMilliseconds != -1)
            {
                settings.ConnectTimeout = new TimeSpan(TimeSpan.TicksPerMillisecond * _TimeoutMilliseconds);
            }
            
            _Client = new MongoClient(settings);

            _Database = _Client.GetDatabase(_DatabaseName);
        }

        public void SetTimeout(int TimeoutMilliseconds)
        {
            _TimeoutMilliseconds = TimeoutMilliseconds;
        }

        public IMongoCollection<BsonDocument> GetCollection(string name)
        {

            var collection = _Database.GetCollection<BsonDocument>(name);

            return collection;
        }
    }
}
