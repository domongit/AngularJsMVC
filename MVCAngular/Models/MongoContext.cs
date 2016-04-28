using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB;
using MongoDB.Bson.Serialization.Attributes;

namespace MVCAngular.Models
{
    public class MongoContext
    {
        public MongoDB.Driver.IMongoDatabase Db;
        public MongoContext()
        {
            var client = new MongoClient("mongodb://localhost");
            Db = client.GetDatabase("test");
              
        }

        public IMongoCollection<Person> People {
            get
            {
                return Db.GetCollection<Person>("persons");
            }
        }
         
    }

    public class Person
    {
        [BsonRepresentation(BsonType.Int32)]
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(User user)
        {
            Id = user.Id;
           FirstName = user.FirstName;
           LastName = user.LastName;
        }
        public Person()
        {
        }
    }
}