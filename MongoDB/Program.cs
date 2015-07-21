using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDatabase database = new MongoDatabase("localhost", "test_db");
            database.SetTimeout(500);
            database.Connect();

            //IMongoTestTask task = new InsertRecords();
            //IMongoTestTask task = new CountRecords();
            //IMongoTestTask task = new CountFilterGT();

            IMongoTestTask task = new InsertRetrieveRecordFromObject();
         
            task.Run(database);
        }
    }
}
