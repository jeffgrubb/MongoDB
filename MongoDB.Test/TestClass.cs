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
            MongoDatabase db = new MongoDatabase("localhost", "test_db");
            db.Connect();
            db.GetCollection("foo");
        }

        [TestCase]
        [ExpectedException(typeof(System.TimeoutException))]
        public void TestUnresponsiveDatabase()
        {
            // This test was supposed to test trying to connect to a MongoDB server that was either a) not responsive, or
            // b) not available/invalid. Looks like my testing method won't work at the moment due to limitations in the API.
            // Leaving this here to revisit in the future.
            // Issue: CHARP-1231, https://jira.mongodb.org/browse/CSHARP-1231

            //MongoDatabase db = new MongoDatabase("this.is.not.a.valid.host.com", "test_db");
            //db.SetTimeout(1);
            //db.Connect();
            //db.GetCollection("foo");
        }
    }
}
