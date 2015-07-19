using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDB database = new MongoDB();

            //IMongoTestTask task = new InsertRecords();
            //IMongoTestTask task = new CountRecords();
            IMongoTestTask task = new CountFilterGT();

            task.Run(database);
        }
    }
}
