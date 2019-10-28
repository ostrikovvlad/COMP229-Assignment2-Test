using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;
using Assignment2.Models.ViewModels;

namespace Assignment2.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeRepository repository;
        public int PageSize = 4;

        public RecipeController(IRecipeRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Tasty Recipes";
            return View("Index");
        }
        [HttpGet]
        public ViewResult AddRecipe()
        {
            ViewBag.Title = "Add Recipe";
            return View();
        }
        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe, int recipePage = 1)
        {
            repository.Add(recipe);
            return View("List", new RecipeListViewModel
            {
                Recipes = repository.Recipes.OrderBy(r => r.RecipeId).Skip((recipePage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = recipePage,
                    RecipesPerPage = PageSize,
                    TotalRecipes = repository.Recipes.Count()
                }
            });
        }
        [HttpGet]
        public ViewResult LeaveReview()
        {
            ViewBag.Title = "Leave a Review";
            return View();
        }
        [HttpPost]
        public ViewResult LeaveReview(Recipe recipe, int recipePage = 1)
        {
            return View("List", new RecipeListViewModel
            {
                Recipes = repository.Recipes.OrderBy(r => r.RecipeId).Skip((recipePage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = recipePage,
                    RecipesPerPage = PageSize,
                    TotalRecipes = repository.Recipes.Count()
                }
            });
        }

        public ViewResult List(int recipePage = 1)
        {
            ViewBag.Title = "Our Recipes";
            return View("List", new RecipeListViewModel
            {
                Recipes = repository.Recipes.OrderBy(r => r.RecipeId).Skip((recipePage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = recipePage,
                    RecipesPerPage = PageSize,
                    TotalRecipes = repository.Recipes.Count()
                }
            });
        }

        public ViewResult ViewRecipe(int recipeId, string returnUrl)
        {
            Recipe recipe = repository.Recipes.FirstOrDefault(r => r.RecipeId == recipeId);

            ViewBag.Title = recipe.Title;
            return View("ViewRecipe", repository.Recipes.Where(r => r.RecipeId == recipe.RecipeId).FirstOrDefault());
        }
    }
}
