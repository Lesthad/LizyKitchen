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

        public IMongoCollection<Recipe> Recipes
        {
            get
            {
                var collection = database.GetCollection<Recipe>("Recipe");

                return collection;
            }
        }
    }
}
