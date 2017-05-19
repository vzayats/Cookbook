using System;
using RecipesApp.DAL.Entities;

namespace RecipesApp.Web.Tests.Controllers
{
    public class TestData
    {
        public readonly Recipe RecipeData = new Recipe
        {
            Id = 1,
            Name = "SALAD WITH CRISPY CHICKEN AND BACONY CROUTONS",
            Description =
                "The rich flavors of crispy, tender chicken and smoky bacon compliment the fresh, bright notes of this hearty dinner salad perfect for two.",
            Ingredients =
                "3 skin-on, bone-in chicken thighs (about 1 pound); Kosher salt, freshly ground pepper; 4 ounces thick-cut bacon, cut crosswise into " +
                "1 pieces(about 3 strips); " +
                "3 ounces country-style bread, sliced 3/4 thick, torn into misshapen 1 pieces (about 2 cups); " +
                "3 tablespoons red wine vinegar, divided; 1 shallot, thinly sliced (about 1/3 cup); 1/4 cup plus 2 tablespoons fresh shelled " +
                "or frozen peas (2 ounces); " +
                "1 tablespoon olive oil; 4 cups trimmed escarole or frisée, torn into small pieces (about 3 ounces); " +
                "1/2 small fennel bulb, cored, thinly sliced; 2 medium radishes, thinly sliced; 1/3 cup mint leaves, torn if large",
            Directions =
                "Arrange a rack in center of oven; preheat to 475ºF. Pat chicken dry with paper towels. Using kitchen shears, remove bones, " +
                "keeping skin and flesh intact; discard bones. Season chicken all over with 1/2 tsp. salt and 1/4 tsp. pepper. " +
                "Heat a medium cast - iron or heavy ovenproof skillet over medium - high until hot but not smoking.Sear chicken skin side down, " +
                "undisturbed," +
                "2 minutes.Continue to cook," +
                "turning occasionally," +
                "until fat renders and skin is golden brown," +
                "4–6 minutes more.Transfer chicken to a plate.Carefully pour off all but 2 tsp.fat and wipe off any fat that drips onto side or " +
                "bottom of skillet.Return chicken to skillet skin side up.Transfer to oven and roast chicken," +
                "tenting skillet with foil if skin becomes too dark halfway through, until skin crisps and meat is cooked through, 8–12 minutes." +
                "Meanwhile, cook bacon in a large skillet over medium heat, turning occasionally, until just crispy, 4–5 minutes.Using a slotted spoon, " +
                "transfer bacon to a large heatproof bowl. Pour off all but 2 Tbsp.fat.Heat fat in skillet over medium.Add bread in an even layer, season " +
                "with a pinch of salt and pepper, and cook, turning pieces occasionally, until golden brown and crisp, 3–4 minutes.Remove from heat; " +
                "add 1 Tbsp.vinegar and toss until absorbed.Let cool a few minutes, then taste and season with more salt and pepper, if needed." +
                "Transfer croutons to bowl with bacon." +
                "Remove chicken from oven and transfer to a plate; reserve skillet with fat and pan drippings.Let chicken cool 5–10 minutes, then cut into " +
                "1 pieces." +
                "Cook shallot, peas, 1 / 8 tsp.salt, and 1 / 8 tsp.pepper in reserved skillet over medium-low heat, stirring, until shallots are softened " +
                "and peas are cooked, about 3 minutes.Remove from heat; stir in oil and remaining 2 Tbsp.vinegar(mixture will bubble) with a heatproof spatula. " +
                "(If you want to ensure bright green peas, cook them separately in a small saucepan of boiling water or in the microwave and sprinkle over " +
                "top of salad after plating.)" +
                "Add escarole, fennel, and radishes to bowl with bacon and croutons.Pour warm dressing over. Toss to combine and slightly wilt greens." +
                "Mound salad among plates; nestle in chicken pieces. Top with mint.Serve immediately.",
            Type = "Salad",
            ImageLink =
                @"http://assets.epicurious.com/photos/5900d4d5ae189771fbcdb86e/6:4/w_620%2Ch_413/Spring-Salad-with-Crispy-Chicken-and-Bacony-Croutons-26042017.jpg",
            DateCreated = new DateTime(2017, 5, 10, 18, 00, 25),
            Notes = "Sample notes"
        };

        public readonly RecipeVersion RecipeVersionData = new RecipeVersion
        {
            VersionId = 1,
            RecipeId = 1,
            Name = "SALAD WITH CRISPY CHICKEN AND BACONY CROUTONS",
            Description =
                "The rich flavors of crispy, tender chicken and smoky bacon compliment the fresh, bright notes of this hearty dinner salad perfect for two.",
            Ingredients =
                "3 skin-on, bone-in chicken thighs (about 1 pound); Kosher salt, freshly ground pepper; 4 ounces thick-cut bacon, cut crosswise into " +
                "1 pieces(about 3 strips); " +
                "3 ounces country-style bread, sliced 3/4 thick, torn into misshapen 1 pieces (about 2 cups). ",
            Directions =
                "Arrange a rack in center of oven; preheat to 475ºF. Pat chicken dry with paper towels. Using kitchen shears, remove bones, " +
                "keeping skin and flesh intact; discard bones. Season chicken all over with 1/2 tsp. salt and 1/4 tsp. pepper. " +
                "Heat a medium cast - iron or heavy ovenproof skillet over medium - high until hot but not smoking.Sear chicken skin side down, " +
                "undisturbed," +
                "2 minutes.Continue to cook," +
                "turning occasionally," +
                "until fat renders and skin is golden brown," +
                "4–6 minutes more.Transfer chicken to a plate.Carefully pour off all but 2 tsp.fat and wipe off any fat that drips onto side or " +
                "bottom of skillet.Return chicken to skillet skin side up.Transfer to oven and roast chicken," +
                "tenting skillet with foil if skin becomes too dark halfway through, until skin crisps and meat is cooked through, 8–12 minutes." +
                "Meanwhile, cook bacon in a large skillet over medium heat, turning occasionally, until just crispy, 4–5 minutes.Using a slotted spoon, " +
                "transfer bacon to a large heatproof bowl. Pour off all but 2 Tbsp.fat.Heat fat in skillet over medium.Add bread in an even layer, season " +
                "with a pinch of salt and pepper, and cook, turning pieces occasionally, until golden brown and crisp, 3–4 minutes.Remove from heat; " +
                "add 1 Tbsp.vinegar and toss until absorbed.Let cool a few minutes, then taste and season with more salt and pepper, if needed." +
                "Transfer croutons to bowl with bacon." +
                "Remove chicken from oven and transfer to a plate; reserve skillet with fat and pan drippings.Let chicken cool 5–10 minutes, then cut into " +
                "1 pieces." +
                "Cook shallot, peas, 1 / 8 tsp.salt, and 1 / 8 tsp.pepper in reserved skillet over medium-low heat, stirring, until shallots are softened " +
                "and peas are cooked, about 3 minutes.Remove from heat; stir in oil and remaining 2 Tbsp.vinegar(mixture will bubble) with a heatproof spatula. " +
                "(If you want to ensure bright green peas, cook them separately in a small saucepan of boiling water or in the microwave and sprinkle over " +
                "top of salad after plating.)" +
                "Add escarole, fennel, and radishes to bowl with bacon and croutons.Pour warm dressing over. Toss to combine and slightly wilt greens." +
                "Mound salad among plates; nestle in chicken pieces. Top with mint.Serve immediately.",
            Type = "Salad",
            ImageLink =
                @"http://assets.epicurious.com/photos/5900d4d5ae189771fbcdb86e/6:4/w_620%2Ch_413/Spring-Salad-with-Crispy-Chicken-and-Bacony-Croutons-26042017.jpg",
            DateCreated = new DateTime(2017, 5, 10, 18, 00, 25),
            DateModified = DateTime.Now,
            Notes = "Sample notes"
        };
    }
}