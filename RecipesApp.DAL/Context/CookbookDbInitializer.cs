using System;
using System.Data.Entity;
using RecipesApp.DAL.Entities;

namespace RecipesApp.DAL.Context
{
    public class CookbookDbInitializer : DropCreateDatabaseAlways<CookbookContext>
    {
        protected override void Seed(CookbookContext db)
        {
            db.Recipes.Add(new Recipe
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
            });
            db.Recipes.Add(new Recipe
            {
                Id = 2,
                Name = "ONE-POT PASTA PRIMAVERA WITH SHRIMP",
                Description =
                    "This lightning-fast version of the classic pasta recipe calls for just the right amount of water that magically cooks down to create a " +
                    "silky sauce (no draining necessary!). Bright green vegetables, cherry tomatoes, and plump shrimp round out this springy meal that " +
                    "can be enjoyed all year round.",
                Ingredients =
                    "12 ounces short pasta, such as penne or fusilli; " +
                    "4 garlic cloves, thinly sliced; " +
                    "21/2 teaspoons(or more) kosher salt; " +
                    "3/4 teaspoon(or more) freshly ground black pepper; " +
                    "1(10 - ounce) bag frozen broccoli florets; " +
                    "6 ounces green beans, preferably haricots verts, trimmed; " +
                    "8 ounces large shrimp, peeled, deveined, tails left on; " +
                    "1 pint cherry tomatoes, sliced in half; " +
                    "1 cup frozen green peas; " +
                    "1/4 cup (1/2 stick) unsalted butter; " +
                    "1 teaspoon finely grated lemon zest; " +
                    "1 cup finely grated Parmesan, plus more for serving; " +
                    "1/4 cup coarsely chopped basil; " +
                    "Red pepper flakes(for serving; optional). ",
                Directions =
                    "Place pasta in a large, wide-bottomed pot or large, wide, straight-sided pan. Add garlic, salt, black pepper, and 3 1/2 cups hot water. " +
                    "Cover and bring to a boil. Once boiling, uncover and cook, setting a timer for cooking pasta according to package directions and " +
                    "stirring often. When 5 minutes remain on timer, stir in broccoli and green beans. Cover pot and return to a boil. " +
                    "(If pot starts to dry out at any point, add another 1/2 cup water.) When 2 minutes remain on timer, stir in shrimp, " +
                    "tomatoes, peas, and butter. Cover and continue to cook 2 minutes, then uncover and cook, stirring, until pasta is tender, shrimp are cooked " +
                    "through, and water is almost completely evaporated, about 1 minute more. " +
                    "Remove from heat. Stir in lemon zest and 1 cup Parmesan and toss to coat. Season with more salt and pepper, if needed. " +
                    "Divide pasta among plates. Top with basil, additional Parmesan, and red pepper, if using.",
                Type = "Pasta",
                ImageLink =
                    @"http://assets.epicurious.com/photos/5900de8e02cc6e7da4b28933/6:4/w_620%2Ch_413/One-Pot-Pasta-Primavera-with-Shrimp-recipe-26042017.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                Notes = "Sample notes"
            });
            db.Recipes.Add(new Recipe
            {
                Id = 3,
                Name = "PRESERVED LEMONS",
                Description =
                    "If you can find Meyer lemons, use them for this recipe. Their thinner skin has very little bitterness.",
                Ingredients =
                    "2 cups Diamond Crystal or 1 cup Morton kosher salt; " +
                    "1/2 cup sugar; " +
                    "5 lemons, preferably organic, scrubbed.",
                Directions =
                    "Combine salt and sugar in a medium bowl. Cut lemons into quarters lengthwise. Pack alternating layers of salt mixture and " +
                    "lemons into a 1-qt. glass jar or nonreactive container. Cover and chill at least 1 month and up to 1 year, shaking every day " +
                    "for the first 2 weeks to redistribute curing mixture and the brine that will form.",
                Type = "Lemons",
                ImageLink =
                    @"http://assets.epicurious.com/photos/58c6be287c80d64acc70ad23/6:4/w_620%2Ch_413/preserved-lemons-BA-031317.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                Notes = "Sample notes"
            });
            db.Recipes.Add(new Recipe
            {
                Id = 4,
                Name = "CLASSIC SNICKERDOODLE COOKIES",
                Description =
                    "These childhood favorites get their tangy flavor from an old-school leavener: cream of tartar. We\'ve kept the recipe super traditional " +
                    "by using an all-butter dough, omitting the vanilla to let the tart flavor shine, and rolling the cookies in plenty of cinnamon-sugar before " +
                    "baking for a glistening finish.",
                Ingredients =
                    "1 1/2 cups all-purpose flour; 1 teaspoon baking soda; 1 teaspoon cream of tartar; " +
                    "1/2 cup (1 stick) cold unsalted butter, cut into 1/2' pieces; " +
                    "1/4 teaspoon kosher salt; 1 cup sugar, divided; 1 large egg, room temperature; 2 teaspoons ground cinnamon.",
                Directions =
                    "Whisk flour, baking soda, and cream of tartar in a medium bowl. Using an electric mixer on medium speed, beat butter in a large bowl until " +
                    "pale yellow, 2–3 minutes. Scrape down sides, add salt and 3/4 cup sugar, and continue to beat until light and fluffy, 3–4 minutes more. " +
                    "Scrape down sides, add egg, and blend until just incorporated. Reduce mixer speed to low and gradually add dry ingredients, beating until " +
                    "just incorporated. " +
                    "Gather dough into a ball, wrap ball in plastic wrap, and chill until firm, about 30 minutes. " +
                    "Place racks in upper and lower thirds of oven; preheat to 375°F. Line 2 rimmed baking sheets with parchment paper. Mix cinnamon and " +
                    "remaining 1/4 cup sugar in a small bowl. Using your hands, roll tablespoonfuls of dough into balls. Roll balls in cinnamon sugar, " +
                    "then transfer to prepared sheets, spacing about 2' apart. " +
                    "Bake cookies, rotating sheets halfway through, until just golden brown around the edges, 8–10 minutes (cookies will firm up as they cool). " +
                    "Let cookies cool on sheets a few minutes, then transfer to wire racks and let cool completely. ",

                Type = "Cookies",
                ImageLink =
                    @"http://assets.epicurious.com/photos/58cfd77d1406b443e2a13780/6:4/w_620%2Ch_413/Snickerdoodle-recipe-20032017.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                Notes = "Sample notes"
            });
            db.Recipes.Add(new Recipe
            {
                Id = 5,
                Name = "GRAPEFRUIT MARMALADE WITH VANILLA AND ANISE",
                Description =
                    "The fruit-to-sugar ratio in this marmalade recipe makes it not too sweet and you can really taste the grapefruit.",
                Ingredients =
                    "1 3/4-pound ruby red grapefruit (about 2); 2 star anise pods; 1 vanilla bean, halved lengthwise; 2 cups sugar; 1/4 cup fresh lemon juice.",
                Directions =
                    "Using a sharp knife, remove peel and white pith from 1 grapefruit and thinly slice. Remove peel and white pith from remaining " +
                    "grapefruit and discard (you won’t want all of the peel and pith in the marmalade). Slice flesh of both grapefruits into rounds; remove any seeds. " +
                    "Combine sliced peel, grapefruit, and star anise in a large saucepan; scrape in seeds from vanilla bean and add pod. Toss to combine; " +
                    "pour in 4 cups water and bring mixture to a boil. Reduce heat and gently simmer until reduced by three-quarters, about 1 1/2 hours. " +
                    "Add sugar, return to a simmer, and cook until mixture is thickened and juices are syrupy (mixture will set up when a small amount is " +
                    "spooned onto a cold plate), 1–1 1/2 hours longer. " +
                    "Let marmalade cool slightly, then stir in lemon juice. Spoon into clean jars and let cool. ",
                Type = "MARMALADE",
                ImageLink =
                    @"http://assets.epicurious.com/photos/58c6be215eadb2183663cb9e/6:4/w_620%2Ch_413/grapefruit-marmalade-BA-031317.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                Notes = "Sample notes"
            });
            db.Recipes.Add(new Recipe
            {
                Id = 6,
                Name = "MIRROR CAKE GLAZE",
                Description =
                    "This creamy white-chocolate glaze sets with a mirror-like shine when poured over a smoothly frosted cake. For a gorgeous marbled effect, " +
                    "layer several colors of glaze into one bowl before pouring it over the cake.",
                Ingredients =
                    "2 tablespoons plus 1 teaspoon unflavored gelatin (3 packets); 1 3/4 cups sugar; 1/2 cup sweetened condensed milk; 1 teaspoon vanilla extract; 1/4 teaspoon kosher salt; " +
                    "2 1/2 cups white chocolate chips (about 15 ounces); 3–4 different shades of food coloring.",
                Directions =
                    "Stir gelatin and 1/2 cup lukewarm water in a small bowl and let sit 5 minutes. Cook sugar, condensed milk, vanilla, salt, and 3/4 cup water " +
                    "in a medium saucepan over medium heat, stirring occasionally, until mixture begins to bubble, about 4 minutes. Add bloomed gelatin and stir until dissolved." +
                    "Remove from heat and add chocolate chips, stirring constantly, until melted. Strain through a fine-mesh sieve into a large bowl, then divide " +
                    "glaze among 3 or 4 bowls. Color each with food coloring as desired. Let cool, stirring occasionally to stop a skin from forming, until glaze " +
                    "is just cool enough to touch (100–95°F), 10–12 minutes." +
                    "Pour half of color one into a large bowl, then pour half of color two into the center, followed by half of color three and half of color " +
                    " four, if using. Repeat with remaining glaze to form concentric circles of different colors in bowl." +
                    "Set a chilled, smoothly frosted cake on a cake pan or overturned bowl set inside a rimmed baking sheet or large tray to catch drips. " +
                    "Pour colored glaze over, sweeping back and forth across cake as you pour, to form a marbled pattern. Resist the temptation to touch glaze " +
                    "once it’s poured; it will start to set as soon as it hits the cold cake. Let glaze drip about 10 minutes, then clean up edges with a small " +
                    "offset spatula or butter knife. Transfer cake to a serving platter and chill at least 30 minutes or up to 1 day." +
                    "Using a warmed sharp knife, cut cleanly through cake, wiping knife with a warm damp towel between each slice. ",
                Type = "CAKE",
                ImageLink =
                    @"http://assets.epicurious.com/photos/589247a71dbf768a12c72f36/6:4/w_620%2Ch_413/valentintes-day-glass-cake-01022017.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                Notes =
                    "This recipe makes enough to cover one 13x9' sheet cake.For smaller cakes, divide the recipe accordingly."
            });
            db.Recipes.Add(new Recipe
            {
                Id = 7,
                Name = "3-INGREDIENT CINNAMON-SUGAR TWISTS",
                Description =
                    "In Epi's 3-Ingredient Recipes series, we show you how to make great food with just three ingredients (plus staples like oil, salt, and pepper). " +
                    "These buttery, flaky twists have a crispy, warmly spiced glaze.",
                Ingredients =
                    "1 cup sugar; 1 teaspoon ground cinnamon; Pinch of kosher salt; 14–17 ounces frozen puff pastry, thawed.",
                Directions =
                    "Arrange racks in upper and lower thirds of oven; preheat to 400°F. Line 2 rimmed baking sheets with parchment. Mix sugar, cinnamon, and salt on a large plate. " +
                    "Fill a small bowl or glass with cold water. " +
                    "Roll out pastry between 2 sheets of parchment until short side is 10' long and dough is about 1 / 8' thick. Freeze dough 5 minutes. " +
                    "Using a pizza cutter or sharp knife, cut dough crosswise into 1' strips. Transfer half of strips to refrigerator.Working one at a time " +
                    "brush strip lightly with water(or use your fingertips), then immediately transfer to sugar mixture and turn to coat. " +
                    "Starting from the middle, use both hands to twist dough to the ends. Transfer to prepared sheet, arranging twists vertically. " +
                    "Repeat with remaining dough. Freeze 10 minutes. " +
                    "Bake twists, rotating sheets front to back and top to bottom halfway through, until golden brown and beginning to caramelize, 18–20 minutes. " +
                    "Using tongs, immediately lift twists from parchment and let cool with 1 end on rim of baking sheet (work carefully, sugar coating will be very hot).",
                Type = "TWISTS",
                ImageLink =
                    @"http://assets.epicurious.com/photos/57eaf1ebf95e635c5f8ad9fa/6:4/w_620%2Ch_413/3-Ingredient-Cinnamon-Twists-27092016.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                Notes = "Sample notes"
            });
            db.Recipes.Add(new Recipe
            {
                Id = 8,
                Name = "3-INGREDIENT CINNAMON-SUGAR TWISTS",
                Description =
                    "Okay, fine, you've never heard of baobab—but that's about to change. (Remember when no one knew how to pronounce quinoa?) You'll find the powder " +
                    "from the tangy superfruit stocked at the health food store.",
                Ingredients =
                    "1 small green cabbage, outer leaves removed, cut into thin wedges; 1 medium fennel bulb, cored, cut into quarters; 2 green apples, halved; " +
                    "4 celery stalks; 1 lemongrass stalk, tough outer layers removed, root end trimmed (pale-green parts only); 12' piece ginger, peeled; 2 teaspoons baobab powder (optional).",
                Directions =
                    "Pass cabbage, fennel, apples, celery, lemongrass, and ginger through a juicer. Transfer juice to an airtight container; cover and chill until cold. " +
                    "Just before serving, add baobab powder to juice and stir until dissolved. Divide juice among glasses.",
                Type = "JUICE",
                ImageLink =
                    @"http://assets.epicurious.com/photos/555b5d8b644d45515b757400/6:4/w_620%2Ch_413/56389536_green-juice-baobab_1x1.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                Notes = "Sample notes"
            });

            db.RecipeVersions.Add(new RecipeVersion
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
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 2,
                RecipeId = 1,
                Name = "SALAD WITH CRISPY CHICKEN AND BACONY CROUTONS",
                Description =
                    "The rich flavors of crispy, tender chicken and smoky bacon compliment the fresh, bright notes of this hearty dinner salad perfect for two.",
                Ingredients =
                    "3 skin-on, bone-in chicken thighs (about 1 pound); Kosher salt, freshly ground pepper; 4 ounces thick-cut bacon, cut crosswise into " +
                    "1 pieces(about 3 strips); " +
                    "3 ounces country-style bread, sliced 3/4 thick, torn into misshapen 1 pieces (about 2 cups); ",
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
                    "tenting skillet with foil if skin becomes too dark halfway through, until skin crisps and meat is cooked through, 8–12 minutes.",
                Type = "Salad",
                ImageLink =
                    @"http://assets.epicurious.com/photos/5900d4d5ae189771fbcdb86e/6:4/w_620%2Ch_413/Spring-Salad-with-Crispy-Chicken-and-Bacony-Croutons-26042017.jpg",
                DateCreated = new DateTime(2017, 5, 10, 18, 00, 25),
                DateModified = DateTime.Now.AddHours(-1),
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 3,
                RecipeId = 2,
                Name = "ONE-POT PASTA PRIMAVERA WITH SHRIMP",
                Description =
                    "This lightning-fast version of the classic pasta recipe calls for just the right amount of water that magically cooks down to create a " +
                    "silky sauce (no draining necessary!). Bright green vegetables, cherry tomatoes, and plump shrimp round out this springy meal that " +
                    "can be enjoyed all year round.",
                Ingredients =
                    "12 ounces short pasta, such as penne or fusilli; " +
                    "4 garlic cloves, thinly sliced; " +
                    "21/2 teaspoons(or more) kosher salt; " +
                    "3/4 teaspoon(or more) freshly ground black pepper; " +
                    "1(10 - ounce) bag frozen broccoli florets; " +
                    "6 ounces green beans, preferably haricots verts, trimmed; " +
                    "8 ounces large shrimp, peeled, deveined, tails left on; " +
                    "1 pint cherry tomatoes, sliced in half; ",
                Directions =
                    "Place pasta in a large, wide-bottomed pot or large, wide, straight-sided pan. Add garlic, salt, black pepper, and 3 1/2 cups hot water. " +
                    "Cover and bring to a boil. Once boiling, uncover and cook, setting a timer for cooking pasta according to package directions and " +
                    "stirring often. When 5 minutes remain on timer, stir in broccoli and green beans. Cover pot and return to a boil. " +
                    "(If pot starts to dry out at any point, add another 1/2 cup water.) When 2 minutes remain on timer, stir in shrimp, " +
                    "tomatoes, peas, and butter. Cover and continue to cook 2 minutes, then uncover and cook, stirring, until pasta is tender, shrimp are cooked " +
                    "through, and water is almost completely evaporated, about 1 minute more.",
                Type = "Pasta",
                ImageLink =
                    @"http://assets.epicurious.com/photos/5900de8e02cc6e7da4b28933/6:4/w_620%2Ch_413/One-Pot-Pasta-Primavera-with-Shrimp-recipe-26042017.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now,
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 4,
                RecipeId = 2,
                Name = "ONE-POT PASTA PRIMAVERA WITH SHRIMP",
                Description =
                    "This lightning-fast version of the classic pasta recipe calls for just the right amount of water that magically cooks down to create a " +
                    "silky sauce (no draining necessary!). Bright green vegetables, cherry tomatoes, and plump shrimp round out this springy meal that " +
                    "can be enjoyed all year round.",
                Ingredients =
                    "12 ounces short pasta, such as penne or fusilli; " +
                    "4 garlic cloves, thinly sliced; " +
                    "21/2 teaspoons(or more) kosher salt; " +
                    "3/4 teaspoon(or more) freshly ground black pepper. ",
                Directions =
                    "Place pasta in a large, wide-bottomed pot or large, wide, straight-sided pan. Add garlic, salt, black pepper, and 3 1/2 cups hot water. " +
                    "Cover and bring to a boil. Once boiling, uncover and cook, setting a timer for cooking pasta according to package directions and " +
                    "stirring often. When 5 minutes remain on timer, stir in broccoli and green beans. Cover pot and return to a boil. ",
                Type = "Pasta",
                ImageLink =
                    @"http://assets.epicurious.com/photos/5900de8e02cc6e7da4b28933/6:4/w_620%2Ch_413/One-Pot-Pasta-Primavera-with-Shrimp-recipe-26042017.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now.AddHours(-1),
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 5,
                RecipeId = 3,
                Name = "PRESERVED LEMONS",
                Description =
                    "If you can find Meyer lemons, use them for this recipe. Their thinner skin has very little bitterness.",
                Ingredients =
                    "2 cups Diamond Crystal or 1 cup Morton kosher salt; " +
                    "1/2 cup sugar.",
                Directions =
                    "Combine salt and sugar in a medium bowl. Cut lemons into quarters lengthwise. Pack alternating layers of salt mixture and " +
                    "lemons into a 1-qt. glass jar or nonreactive container.",
                Type = "Lemons",
                ImageLink =
                    @"http://assets.epicurious.com/photos/58c6be287c80d64acc70ad23/6:4/w_620%2Ch_413/preserved-lemons-BA-031317.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now,
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 6,
                RecipeId = 3,
                Name = "PRESERVED LEMONS",
                Description =
                    "If you can find Meyer lemons, use them for this recipe. Their thinner skin has very little bitterness.",
                Ingredients =
                    "2 cups Diamond Crystal or 1 cup Morton kosher salt. ",
                Directions =
                    "Combine salt and sugar in a medium bowl. Cut lemons into quarters lengthwise.",
                Type = "Lemons",
                ImageLink =
                    @"http://assets.epicurious.com/photos/58c6be287c80d64acc70ad23/6:4/w_620%2Ch_413/preserved-lemons-BA-031317.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now.AddHours(-1),
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 7,
                RecipeId = 4,
                Name = "CLASSIC SNICKERDOODLE COOKIES",
                Description =
                    "These childhood favorites get their tangy flavor from an old-school leavener: cream of tartar. We\'ve kept the recipe super traditional " +
                    "by using an all-butter dough, omitting the vanilla to let the tart flavor shine, and rolling the cookies in plenty of cinnamon-sugar before " +
                    "baking for a glistening finish.",
                Ingredients =
                    "1 1/2 cups all-purpose flour; 1 teaspoon baking soda; 1 teaspoon cream of tartar; " +
                    "1/2 cup (1 stick) cold unsalted butter, cut into 1/2' pieces.",
                Directions =
                    "Whisk flour, baking soda, and cream of tartar in a medium bowl. Using an electric mixer on medium speed, beat butter in a large bowl until " +
                    "pale yellow, 2–3 minutes. Scrape down sides, add salt and 3/4 cup sugar, and continue to beat until light and fluffy, 3–4 minutes more. " +
                    "Scrape down sides, add egg, and blend until just incorporated. Reduce mixer speed to low and gradually add dry ingredients, beating until " +
                    "just incorporated. " +
                    "Gather dough into a ball, wrap ball in plastic wrap, and chill until firm, about 30 minutes. " +
                    "Place racks in upper and lower thirds of oven; preheat to 375°F. Line 2 rimmed baking sheets with parchment paper. Mix cinnamon and " +
                    "remaining 1/4 cup sugar in a small bowl. Using your hands, roll tablespoonfuls of dough into balls. Roll balls in cinnamon sugar, " +
                    "then transfer to prepared sheets, spacing about 2' apart.",
                Type = "Cookies",
                ImageLink =
                    @"http://assets.epicurious.com/photos/58cfd77d1406b443e2a13780/6:4/w_620%2Ch_413/Snickerdoodle-recipe-20032017.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now,
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 8,
                RecipeId = 4,
                Name = "CLASSIC SNICKERDOODLE COOKIES",
                Description =
                    "These childhood favorites get their tangy flavor from an old-school leavener: cream of tartar.",
                Ingredients =
                    "1 1/2 cups all-purpose flour; 1 teaspoon baking soda.",
                Directions =
                    "Whisk flour, baking soda, and cream of tartar in a medium bowl. Using an electric mixer on medium speed, beat butter in a large bowl until " +
                    "pale yellow, 2–3 minutes. Scrape down sides, add salt and 3/4 cup sugar, and continue to beat until light and fluffy, 3–4 minutes more. " +
                    "Scrape down sides, add egg, and blend until just incorporated. Reduce mixer speed to low and gradually add dry ingredients, beating until " +
                    "just incorporated.",
                Type = "Cookies",
                ImageLink =
                    @"http://assets.epicurious.com/photos/58cfd77d1406b443e2a13780/6:4/w_620%2Ch_413/Snickerdoodle-recipe-20032017.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now.AddHours(-1),
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 9,
                RecipeId = 5,
                Name = "GRAPEFRUIT MARMALADE WITH VANILLA AND ANISE",
                Description =
                    "The fruit-to-sugar ratio in this marmalade recipe makes it not too sweet and you can really taste the grapefruit.",
                Ingredients =
                    "1 3/4-pound ruby red grapefruit (about 2); 2 star anise pods; 1 vanilla bean, halved lengthwise.",
                Directions =
                    "Using a sharp knife, remove peel and white pith from 1 grapefruit and thinly slice. Remove peel and white pith from remaining " +
                    "grapefruit and discard (you won’t want all of the peel and pith in the marmalade). Slice flesh of both grapefruits into rounds; remove any seeds. " +
                    "Combine sliced peel, grapefruit, and star anise in a large saucepan; scrape in seeds from vanilla bean and add pod. Toss to combine; " +
                    "pour in 4 cups water and bring mixture to a boil. Reduce heat and gently simmer until reduced by three-quarters, about 1 1/2 hours.",
                Type = "MARMALADE",
                ImageLink =
                    @"http://assets.epicurious.com/photos/58c6be215eadb2183663cb9e/6:4/w_620%2Ch_413/grapefruit-marmalade-BA-031317.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now,
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 10,
                RecipeId = 5,
                Name = "GRAPEFRUIT MARMALADE WITH VANILLA",
                Description =
                    "The fruit-to-sugar ratio in this marmalade recipe makes it not too sweet and you can really taste the grapefruit.",
                Ingredients =
                    "1 3/4-pound ruby red grapefruit (about 2).",
                Directions =
                    "Using a sharp knife, remove peel and white pith from 1 grapefruit and thinly slice. Remove peel and white pith from remaining " +
                    "grapefruit and discard (you won’t want all of the peel and pith in the marmalade).",
                Type = "MARMALADE",
                ImageLink =
                    @"http://assets.epicurious.com/photos/58c6be215eadb2183663cb9e/6:4/w_620%2Ch_413/grapefruit-marmalade-BA-031317.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now.AddHours(-1),
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 11,
                RecipeId = 6,
                Name = "MIRROR CAKE GLAZE",
                Description =
                    "This creamy white-chocolate glaze sets with a mirror-like shine when poured over a smoothly frosted cake. For a gorgeous marbled effect, " +
                    "layer several colors of glaze into one bowl before pouring it over the cake.",
                Ingredients =
                    "2 tablespoons plus 1 teaspoon unflavored gelatin (3 packets); 1 3/4 cups sugar; 1/2 cup sweetened condensed milk; 1 teaspoon vanilla extract; 1/4 teaspoon kosher salt.",
                Directions =
                    "Stir gelatin and 1/2 cup lukewarm water in a small bowl and let sit 5 minutes. Cook sugar, condensed milk, vanilla, salt, and 3/4 cup water " +
                    "in a medium saucepan over medium heat, stirring occasionally, until mixture begins to bubble, about 4 minutes. Add bloomed gelatin and stir until dissolved." +
                    "Remove from heat and add chocolate chips, stirring constantly, until melted. Strain through a fine-mesh sieve into a large bowl, then divide " +
                    "glaze among 3 or 4 bowls. Color each with food coloring as desired. Let cool, stirring occasionally to stop a skin from forming, until glaze " +
                    "is just cool enough to touch (100–95°F), 10–12 minutes." +
                    "Pour half of color one into a large bowl, then pour half of color two into the center, followed by half of color three and half of color " +
                    " four, if using. Repeat with remaining glaze to form concentric circles of different colors in bowl.",
                Type = "CAKE",
                ImageLink =
                    @"http://assets.epicurious.com/photos/589247a71dbf768a12c72f36/6:4/w_620%2Ch_413/valentintes-day-glass-cake-01022017.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now,
                Notes =
                    "This recipe makes enough to cover one 13x9' sheet cake.For smaller cakes, divide the recipe accordingly."
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 12,
                RecipeId = 6,
                Name = "MIRROR CAKE GLAZE",
                Description =
                    "This creamy white-chocolate glaze sets with a mirror-like shine when poured over a smoothly frosted cake.",
                Ingredients =
                    "2 tablespoons plus 1 teaspoon unflavored gelatin (3 packets); 1 3/4 cups sugar; 1/2 cup sweetened condensed milk.",
                Directions =
                    "Stir gelatin and 1/2 cup lukewarm water in a small bowl and let sit 5 minutes. Cook sugar, condensed milk, vanilla, salt, and 3/4 cup water " +
                    "in a medium saucepan over medium heat, stirring occasionally, until mixture begins to bubble, about 4 minutes. Add bloomed gelatin and stir until dissolved." +
                    "Remove from heat and add chocolate chips, stirring constantly, until melted. Strain through a fine-mesh sieve into a large bowl, then divide " +
                    "glaze among 3 or 4 bowls. Color each with food coloring as desired. Let cool, stirring occasionally to stop a skin from forming, until glaze " +
                    "is just cool enough to touch (100–95°F), 10–12 minutes.",
                Type = "CAKE",
                ImageLink =
                    @"http://assets.epicurious.com/photos/589247a71dbf768a12c72f36/6:4/w_620%2Ch_413/valentintes-day-glass-cake-01022017.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now.AddHours(-1),
                Notes =
                    "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 13,
                RecipeId = 7,
                Name = "3-INGREDIENT CINNAMON-SUGAR TWISTS",
                Description =
                    "In Epi's 3-Ingredient Recipes series, we show you how to make great food with just three ingredients (plus staples like oil, salt, and pepper). " +
                    "These buttery, flaky twists have a crispy, warmly spiced glaze.",
                Ingredients =
                    "1 cup sugar; 1 teaspoon ground cinnamon; Pinch of kosher salt; 14–17 ounces frozen puff pastry, thawed.",
                Directions =
                    "Arrange racks in upper and lower thirds of oven; preheat to 400°F. Line 2 rimmed baking sheets with parchment." +
                    "Fill a small bowl or glass with cold water. " +
                    "Roll out pastry between 2 sheets of parchment until short side is 10' long and dough is about 1 / 8' thick. Freeze dough 5 minutes. " +
                    "Using a pizza cutter or sharp knife, cut dough crosswise into 1' strips. Transfer half of strips to refrigerator.Working one at a time " +
                    "brush strip lightly with water(or use your fingertips), then immediately transfer to sugar mixture and turn to coat. " +
                    "Starting from the middle, use both hands to twist dough to the ends. Transfer to prepared sheet, arranging twists vertically. ",
                Type = "TWISTS",
                ImageLink =
                    @"http://assets.epicurious.com/photos/57eaf1ebf95e635c5f8ad9fa/6:4/w_620%2Ch_413/3-Ingredient-Cinnamon-Twists-27092016.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now,
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 14,
                RecipeId = 7,
                Name = "3-INGREDIENT CINNAMON-SUGAR TWISTS",
                Description =
                    "In Epi's 3-Ingredient Recipes series, we show you how to make great food with just three ingredients (plus staples like oil, salt, and pepper).",
                Ingredients =
                    "1 cup sugar; 1 teaspoon ground cinnamon; Pinch of kosher salt.",
                Directions =
                    "Arrange racks in upper and lower thirds of oven; preheat to 400°F. Line 2 rimmed baking sheets with parchment." +
                    "Fill a small bowl or glass with cold water.",
                Type = "TWISTS",
                ImageLink =
                    @"http://assets.epicurious.com/photos/57eaf1ebf95e635c5f8ad9fa/6:4/w_620%2Ch_413/3-Ingredient-Cinnamon-Twists-27092016.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now.AddHours(-2),
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 15,
                RecipeId = 8,
                Name = "3-INGREDIENT CINNAMON-SUGAR TWISTS",
                Description =
                    "Okay, fine, you've never heard of baobab—but that's about to change. (Remember when no one knew how to pronounce quinoa?) You'll find the powder " +
                    "from the tangy superfruit stocked at the health food store.",
                Ingredients =
                    "1 small green cabbage, outer leaves removed, cut into thin wedges; 1 medium fennel bulb, cored, cut into quarters; 2 green apples, halved; " +
                    "4 celery stalks; 1 lemongrass stalk, tough outer layers removed, root end trimmed (pale-green parts only).",
                Directions =
                    "Pass cabbage, fennel, apples, celery, lemongrass, and ginger through a juicer. Transfer juice to an airtight container; cover and chill until cold.",
                Type = "JUICE",
                ImageLink =
                    @"http://assets.epicurious.com/photos/555b5d8b644d45515b757400/6:4/w_620%2Ch_413/56389536_green-juice-baobab_1x1.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now,
                Notes = "Sample notes"
            });
            db.RecipeVersions.Add(new RecipeVersion
            {
                VersionId = 16,
                RecipeId = 8,
                Name = "3-INGREDIENT CINNAMON-SUGAR TWISTS",
                Description =
                    "Okay, fine, you've never heard of baobab—but that's about to change.",
                Ingredients =
                    "1 small green cabbage, outer leaves removed, cut into thin wedges; 1 medium fennel bulb, cored, cut into quarters.",
                Directions =
                    "Pass cabbage, fennel, apples, celery, lemongrass, and ginger through a juicer.",
                Type = "JUICE",
                ImageLink =
                    @"http://assets.epicurious.com/photos/555b5d8b644d45515b757400/6:4/w_620%2Ch_413/56389536_green-juice-baobab_1x1.jpg",
                DateCreated = new DateTime(2017, 4, 10, 18, 00, 25),
                DateModified = DateTime.Now.AddHours(-2),
                Notes = "Sample notes"
            });

            base.Seed(db);
        }
    }
}