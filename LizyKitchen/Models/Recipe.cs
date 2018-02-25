using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LizyKitchen.Models
{
    public class Recipe
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string CookTime { get; set; }
        public string Level { get; set; }

        [Required]
        [Display(Name = "Modo de Preparacion 1")]
        public string LongDescription1 { get; set; }

        [Display(Name = "Modo de Preparacion 2")]
        public string LongDescription2 { get; set; }

        [Display(Name = "Modo de Preparacion 3")]
        public string LongDescription3 { get; set; }

        [Required]
        [Display(Name = "Photo Url")]
        public string ImageUrl { get; set; }

        public Recipe()
        {

        }

        /*public Recipe(PostRecipe postRecipe)
        {
            Title = postRecipe.Title;
            ShortDescription = postRecipe.ShortDescription;
            LongDescription1 = postRecipe.LongDescription1;
            LongDescription2 = postRecipe.LongDescription2;
            LongDescription3 = postRecipe.LongDescription3;
            ImageUrl = postRecipe.ImageUrl;
        }*/
    }
}
