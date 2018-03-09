using System;
using System.ComponentModel.DataAnnotations;

namespace LizyKitchen.Models
{
    public class PostRecipe
    {
        [Required]
        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Descripcion Corta")]
        public string ShortDescription { get; set; }
        public string CookTime { get; set; }
        public string Level { get; set; }

        [Required]
        [Display(Name = "Modo de Preparacion 1")]
        public string LongDescription1 { get; set; }

        [Required]
        [Display(Name = "Modo de Preparacion 2")]
        public string LongDescription2 { get; set; }

        [Display(Name = "Modo de Preparacion 3")]
        public string LongDescription3 { get; set; }
        public string ImageUrl { get; set; }
    }
}
