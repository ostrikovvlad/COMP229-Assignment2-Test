using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> Recipes { get; }
        Recipe Add(Recipe recipe);
    }
}
