using System;
using LizyKitchen.Models;
using MongoDB.Driver;

namespace LizyKitchen.App_Start
{
    public class JalapenioContext
    {
        public IMongoDatabase database;

        public JalapenioContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("jalapenio");
        }

        //Shorter way
        public IMongoCollection<Recipe> Recipes => database.GetCollection<Recipe>("Recipe");
    }
}
