using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Recipe
    {
        private int recipeId;
        [Key]
        public int RecipeId { get { return recipeId; } set { recipeId = UniqueId.GetId(); } }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instruction { get; set; }
    }
}