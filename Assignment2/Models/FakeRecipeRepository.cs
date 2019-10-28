using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class FakeRecipeRepository
    {
        public IQueryable<Recipe> Recipes => new List<Recipe>
        {
            new Recipe {Name = "Martha Stewart",
                Title = "Potato perogies",
                Description = "Perogies were traditionally served as a meatless dish during Lent, but evolved into a popular side dish. Pierogi bob to the surface of the cooking water when they're done. This recipe Martha Stewart got from her mother. Martha says: My mother used to make it every year on one particular holiday where all of our family would sit together and eat and just enjoy their life. So perogies always bring good memories that warms my heart to me.",
                Ingredients = "1 large egg; 2 tablespoon sour cream; 1 cup milk; 1 cup water; 4 1/2 to 5 cups all-purpose flour plus more for dusting; 5 pounds (about 10 medium) baking potatoes, peeled and quartered; 12 tablespoons (1 1/2 sticks) unsalted butter, melted; 2 ounces cheddar cheese, (about 1/2 cup), grated; 4 ounces cream cheese",
                Instruction = "Make the dough: In a medium bowl, whisk egg. Add sour cream, and whisk until smooth. Add milk and 1 cup water, and whisk until combined. Slowly add about 3 cups flour, and stir with a wooden spoon to combine.;Turn dough out onto a well-floured surface and work in about 1 cup flour as you knead." +
                " Use a plastic scraper to lift dough as it will stick to the counter before flour is worked in. Continue kneading for 8 to 10 minutes, working in another 1/2 cup flour. The dough should be elastic in texture and no longer sticky." +
                " Be careful not to add too much flour, as this will toughen dough. Place dough in a lightly floured bowl and cover with plastic wrap and let rest while you prepare filling.;Make the filling: Place potatoes in a large pot, and cover with cold water. Add salt. " +
                "Place over high heat, and bring to a boil. Cook until fork-tender. Drain and mash with a potato masher. Add 4 tablespoons melted butter and the cheeses, and continue to mash until well incorporated. Season with salt and pepper to taste. " +
                "Place a large pot of salted water over high heat, and bring to a boil. Lay a clean linen towel on your counter, and evenly distribute cornmeal on it to prevent sticking.;On a floured surface, roll out dough to about 1/8 inch thick." +
                "Using a glass or cookie cutter measuring 2 1/2 inches in diameter, cut out as many circles as possible. Gather dough scraps together, rolling them out again, and continue cutting.;Form filling into 1 1/2-inch balls, and place a ball in the center of each dough circle. " +
                "Holding a circle in your hand, fold dough over filling, and pinch the edges, forming a well-sealed crescent.Transfer to linen towel.Continue this process until all dough circles are filled.; Place pierogi in boiling water in batches.They will sink to the bottom of the pot and then rise to the top.Once they rise, let them cook for about a minute more. Meanwhile, drizzle platter with remaining 8 tablespoons melted butter.Remove pierogi from pot, and transfer to platter to prevent sticking.Serve immediately. "}
        }.AsQueryable<Recipe>();
    }
}
