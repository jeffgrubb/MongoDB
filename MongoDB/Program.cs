using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
    class Program
    {
        static void Main(string[] args)
        {
            MongoDatabase database = new MongoDatabase();

            //IMongoTestTask task = new InsertRecords();
            //IMongoTestTask task = new CountRecords();
            //IMongoTestTask task = new CountFilterGT();

            IMongoTestTask task = new InsertRetrieveRecordFromObject();
            task.Run(database);

           
            
        }
    }
}
