using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using MongoDB;


namespace MongoDB.Test
{
    [TestFixture]
    public class TestClass
    {
        [TestCase]
        public void TestDatabase()
        {
            MongoDatabase db = new MongoDatabase();
            db.GetCollection("foo");
        }
    }
}
