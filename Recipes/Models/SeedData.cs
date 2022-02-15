using Microsoft.EntityFrameworkCore;
using Recipes.Data;

namespace Recipes.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RecipesContext>>()))
            {
                // Look for any movies.
                if (context.Recipe.Any())
                {
                    return;   // DB has been seeded
                }

                context.Recipe.AddRange(
                    new Recipe
                    {
                        Name = "Pepper steak with noodles",
                        Description = "Try our pepper steak with noodles for a simple, balanced, midweek meal that's full of flavour. Top with sesame seeds and crushed peppercorns to serve",
                        TimeToMake = "27mins",
                        Difficulty = "Easy",
                        Healthy = false,
                        DietaryRequirements = "None",
                        Servings = "4",
                        Ingredients = "2 tbsp light soy sauce4 tbsp shaohsing wine (or dry sherry)3 garlic cloves, crushed1-inch piece of ginger, peeled and grated450g steak (skirt steak works well)1 tbsp vegetable oil2 tbsp cornflour1 tbsp sesame oil1 onion, cut into thick slices1 red and 1 yellow pepper, both cut into 1-inch piecespinch of sesame seeds1-2 tsp crushed black peppercorns500g cooked noodles, to serve",
                        Method = "STEP 1Mix 1 tbsp of the soy with 1 tbsp of the shaohsing wine, 1 crushed garlic clove and half the ginger. Pour over the steak and leave for at least 20 mins or up to 1 hr. Heat a frying pan over a high heat until very hot. Take the steak out of the marinade and scrape off as much of it as you can. Rub with the vegetable oil and put in the frying pan. Leave for 2 mins, then gently move it around to catch any bits of char, which will add to the flavour. After another 30 seconds, turn the steak and cook for 2½ mins on the other side. Transfer to a plate and set aside.STEP 2Mix the cornflour into the remaining soy sauce and shaohsing wine and add 150ml water. Heat the sesame oil in a wok or frying pan over a medium-high heat and add the onion. Cook for 1 min, stirring, then add the peppers. Cook for 4 mins, stirring regularly. Once they are starting to soften with bits of char on them, add the remaining garlic and ginger, and soy mixture. As soon as the sauce starts to thicken, remove from the heat.STEP 3Slice the steak thinly and add to the wok, just stirring through. Sprinkle with the sesame seeds and crushed peppercorns and serve with the noodles."
                    },

                    new Recipe
                    {
                        Name = "One-pan egg & veg brunch",
                        Description = "With courgette, peppers and eggs, this vegetarian dish is a filling, healthy breakfast for all the family – kids will enjoy dipping toast into soft egg yolk",
                        TimeToMake = "Romantic Comedy",
                        Difficulty = "30mins",
                        Healthy = false,
                        DietaryRequirements = "None",
                        Servings = "3",
                        Ingredients = "STEP 1300g baby new potatoes , halved½ tbsp rapeseed oil1 knob of butter1 courgette , cut into small chunks1 yellow pepper , cut into small chunks1 red pepper , cut into small chunks2 spring onions , finely sliced1 garlic clove , crushed1 sprig thyme , leaves picked4 eggstoast , to serveSTEP 2Mix the cornflour into the remaining soy sauce and shaohsing wine and add 150ml water. Heat the sesame oil in a wok or frying pan over a medium-high heat and add the onion. Cook for 1 min, stirring, then add the peppers. Cook for 4 mins, stirring regularly. Once they are starting to soften with bits of char on them, add the remaining garlic and ginger, and soy mixture. As soon as the sauce starts to thicken, remove from the heat.STEP 3Slice the steak thinly and add to the wok, just stirring through. Sprinkle with the sesame seeds and crushed peppercorns and serve with the noodles.",
                        Method = "STEP 1 Boil the new potatoes for 8 mins, then drain. STEP 2 Heat the oil and butter in a large non-stick frying pan, then add the courgette, peppers, potatoes and a little salt and pepper. Cook for 10 mins, stirring from time to time until everything is starting to brown. Add the spring onions, garlic and thyme and cook for 2 mins more. STEP 3 Make four spaces in the pan and crack in the eggs. Cover with foil or a lid and cook for around 4 mins, or until the eggs are cooked (with the yolks soft for dipping into). Sprinkle with more thyme leaves and ground black pepper if you like. Serve with toast."
                    }, 
                    
                    new Recipe
                    {
                        Name = "Teriyaki salmon & green beans",
                        Description = "Buy a whole piece of salmon for this traybake if you're feeding a family and cut into adult and children-sized portions. It's cooked in a delicious teriyaki sauce",
                        TimeToMake = "45mins",
                        Difficulty = "More effort",
                        Healthy = true,
                        DietaryRequirements = "None",
                        Servings = "4",
                        Ingredients = "4 salmon fillets (or a 500g piece to cut up yourself)100g green beans , ends trimmed1 lemon , cut into wedges2 tbsp low-salt soy sauce1 tbsp honey1 tbsp mirin1 garlic clove , crushednoodles or rice, to serve",
                        Method = "STEP 1Heat oven to 180C/160C fan/gas 4. If you have a whole piece of salmon, cut it into four fillets. Place a sheet of baking parchment on a baking tray and lay the salmon diagonally across it.STEP 2Cook the beans in boiling water for 1 min and drain. Arrange the beans in piles around the salmon and add the lemon wedges to the baking tray. Mix the soy sauce, honey, mirin and garlic, and pour half of it over the beans and salmon. STEP 3Cook for 15 mins, then pour the rest of the sauce over the salmon. Cook for another 5 mins. Squeeze over the lemon and serve with noodles or rice."
                    },
                    
                    new Recipe
                    {
                        Name = "Chicken & bean enchiladas",
                        Description = "Make the most of your roast dinner by using up leftover chicken in these filling wraps",
                        TimeToMake = "40mins",
                        Difficulty = "Easy",
                        Healthy = true,
                        DietaryRequirements = "Gluten-Free",
                        Servings = "4",
                        Ingredients = "1 tbsp vegetable oil1 red onion , chopped1 garlic clove , crushed1 tbsp fajita seasoning2 x 395g cans kidney beans in chilli sauce2 roast chicken legs , meat shredded off the bone195g can sweetcorn , drained8 flour tortillas140g hard cheese , grated",
                        Method = "STEP 1Heat oven to 180C/160C fan/gas 4. Heat the oil in a frying pan and cook the onion and garlic for 5 mins. Stir in the fajita seasoning and cook for 1 min more before adding the kidney beans, shredded chicken and sweetcorn.STEP 2Divide the mixture between the tortillas, sprinkle over half the cheese, then roll up and place into a baking dish. Sprinkle over the remaining cheese, then bake for 20-25 mins until golden and bubbling"
                    }, 
                    
                    new Recipe
                    {
                        Name = "Simple stir-fry",
                        Description = "Kids getting into cooking? This simple stir-fry with prawns, veggies and noodles is great for aspiring chefs and will make a quick meal for busy weeknights",
                        TimeToMake = "25mins",
                        Difficulty = "Not too tricky",
                        Healthy = false,
                        DietaryRequirements = "None",
                        Servings = "4",
                        Ingredients = "500g vegetables such as carrots, baby corn, broccoli, courgettes, red peppers and cabbage or pak choi1 tbsp rapeseed oil1 garlic clove, sliced1cm fresh ginger, grated1½ tbsp reduced salt soy sauce2 tbsp sweet chilli sauce (optional)200g cooked prawns, salmon (flaked) or chicken breast (shredded)200g egg noodles, cooked",
                        Method = "STEP 1Finely chop or slice the vegetables into pieces roughly the same size. Slice the carrots diagonally, slice the baby corn, cut the broccoli into small florets, then slice the stem, and finely slice the peppers, cabbage or pak choi. Heat the oil in a large frying pan or wok, then fry the garlic and ginger for 1 min.STEP 2Add the veg and toss to coat. Fry for 2-3 mins, then add the soy sauce and chilli sauce, if using, and mix well. Cook for 2-3 mins more until the veg is tender. Stir in the prawns, salmon or chicken and heat through. Serve over the noodles."
                    }, 
                    
                    new Recipe
                    {
                        Name = "Dude ranch tacos",
                        Description = "Sure to be a family favourite, serve up these simple beef steak wraps with avocado, soured cream and tomato sauces, and let everyone mix and match",
                        TimeToMake = "40mins",
                        Difficulty = "Not too tricky",
                        Healthy = false,
                        DietaryRequirements = "None",
                        Servings = "4",
                        Ingredients = "The meata big ol' 400g sirloin or rib-eye steak, or 2 smaller steaks100ml good-quality barbecue sauce50ml chilli sauceThe wrappack of 8 flour tortillasThe red sauce4 large ripe tomatoes , finely dicedjuice 1 lime2 spring onions , chopped1 red chilli , choppedThe green sauce1 ripe avocado , stoned and peeled50ml soured cream1 green chilli , choppedjuice 1 limesmall handful chopped mint leavessmall handful chopped coriander leavesThe white sauce100ml mayonnaise100ml soured cream3 spring onions , chopped1 green chilli , finely sliced1 tsp ground cumin1 tsp cider vinegar1 tsp sugarThe cheese100g grated cheddarThe crunchshredded cabbage or crisp lettucejuice 1 lime",
                        Method = "STEP 1In a bowl, mix all the ingredients for the red sauce together with some seasoning, then do the same for the white sauce. To make the green sauce, mash the avocado, then mix with the rest of the ingredients and season. Dress the cabbage with a squeeze of lime and tip onto a plate.STEP 2Season the steak, and pan-fry or barbecue until cooked to your liking. Rest for 5 mins, then slice into strips and toss in the BBQ and chilli sauces.STEP 3Warm the wraps on a barbecue or in a dry frying pan for a few secs each side. Lay out everything and let everyone make their own taco."
                    }, 
                    
                    new Recipe
                    {
                        Name = "Easy vegan tacos",
                        Description = "Make these tasty vegan tacos with a smoky-sweet salsa and pack in all of your 5-a-day in one meal. Kiwi brings a moreish, fruity dimension to the salsa",
                        TimeToMake = "40mins",
                        Difficulty = "Easy",
                        Healthy = true,
                        DietaryRequirements = "Vegan",
                        Servings = "2",
                        Ingredients = "175g pack baby corn1 large red onion , sliced (190g)1 red pepper , deseeded and roughly chopped½ tsp cumin seeds2 tsp olive oil1large ripe kiwi , halved lengthways (110g)1large tomato , halved (115g)100g wholemeal flour , plus extra for rolling1 large garlic clove15g fresh coriander , chopped1 tsp vegan bouillon powder½ tsp smoked paprika85g red cabbage , finely shredded",
                        Method = "STEP 1Heat oven to 220C/200C fan/gas 7. Pile the corn, red onion and pepper into a large shallow roasting tin and toss with the cumin seeds and oil. Add the kiwi and tomato on one side of the tin and roast for 20 mins.STEP 2Meanwhile, mix 60ml water into the flour with the blade of a knife to make a dough. Knead briefly until smooth, then cut equally into four and roll out each piece on a lightly floured surface into a 16cm round tortilla. Cover with a tea towel to stop them drying out.STEP 3Remove the cooked tomato and kiwi from the tin and return the veg to the oven for 10 mins. Remove the skin from the kiwi and scoop the flesh into a bowl with the tomato, garlic, half the coriander, bouillon and paprika. Use a hand blender to blitz to a smooth salsa.STEP 4Heat a large non-stick frying pan, without oil, and cook the tortillas one at a time for a minute on one side and about 10 seconds on the other, until you see them puff up a little. Spread a tortilla with some salsa, top with cabbage and roasted veg, then scatter with the remaining coriander. Add a spoonful more salsa and eat with your hands."
                    }, 
                    
                    new Recipe
                    {
                        Name = "Goan - style vegetable curry with kitchari",
                        Description = "Eat all 5 of your 5-a-day in one delicious curry, served with brown rice and lentils. It's healthy, vegan, gluten-free and provides vitamin C and iron, too.",
                        TimeToMake = "45mins",
                        Difficulty = "More effort",
                        Healthy = true,
                        DietaryRequirements = "Vegan",
                        Servings = "3",
                        Ingredients = "225g brown basmati rice1 tsp olive oil1 tsp ground coriander390g can green lentils , drainedFor the curry1 tbsp olive oil2 large onions (330g), 1 finely chopped, 1 sliced2 red chillies , deseeded and sliced25g ginger , finely chopped1 tsp ground turmeric1 tsp smoked paprika1 tsp ground cumin3 tsp ground coriander3 garlic cloves , chopped1 tbsp vegetable bouillon powder (check it’s vegan if you need it to be), made up with 500ml boiling water360g cauliflower florets (about 1/4 cauliflower)1 ½ tsp tamarind320g fine beans , trimmed and halved if large4 large tomatoes , cut into wedges2 large courgettes (320g), halved lengthways and thickly sliced100g coconut yogurt½ x 30g pack fresh coriander , chopped, to serve",
                        Method = "STEP 1Boil the rice in a pan of water for 25 mins until tender, then drain.STEP 2Meanwhile, make the curry. Heat the oil in a large pan and fry the onions, chillies and ginger for 8-10 mins until softened. Add the spices and garlic, stir briefly, then pour in the bouillon and stir in the cauliflower. Cover and simmer for 5 mins.STEP 3Stir in the tamarind with the beans, tomatoes and courgettes, then cover the pan and cook for 10-15 mins more until the veg are tender, but still retain a little bite. Remove the lid for the last 5 mins to reduce the sauce a little. Remove from the heat and stir in the yogurt and half the fresh coriander.STEP 4Meanwhile, for the kitchari, heat the oil in a non-stick pan and add the ground coriander. Warm briefly, then tip in the rice and drained lentils. Warm through for 1 min, then stir through the remaining fresh coriander.STEP 5If you're following our Healthy Diet Plan, serve half the curry and rice now, then chill the rest to eat another night (cool the rice quickly on a wide tray, then chill immediately). Reheat the rice and curry in the microwave or on the hob. You may need to add a drop of water to the rice to stop it sticking."
                    },
                    
                    new Recipe
                    {
                        Name = "Caramel-drizzled banoffee bake",
                        Description = "Enjoy this bake with all the gorgeous elements of banoffee: a crumbly biscuit base, creamy cheesecake-style filling, bananas and caramel",
                        TimeToMake = "1hr 35mins",
                        Difficulty = "More effort",
                        Healthy = false,
                        DietaryRequirements = "None",
                        Servings = "9",
                        Ingredients = "For the base175g unsalted butter, melted, plus extra for the tin250g digestive biscuits, crushed to a fine powder1/2 tsp ground cinnamonFor the banana ripple2 tbsp icing sugar1 tbsp cocoa1/2 tsp cinnamon3 medium bananas, choppedFor the creamy filling750g full-fat soft cheese200g mascarpone175g light brown soft sugar2 tsp vanilla bean extract3 eggs2 1/2 tbsp plain flour100g caramelTo serve300ml double cream2 tbsp caster sugar2 tbsp caramelcocoa, for dustinglarge handful baked banana chips (optional)",
                        Method = "STEP 1Butter and line the base and sides of a 23cm square loose-bottomed cake tin. Put the biscuit crumbs in a bowl with the butter, cinnamon and a small pinch of salt, and mix until it resembles wet sand. Tip into the base of the tin, then level off and press the mixture down using the back of a spoon to compact it. Put in the fridge while you make the filling.STEP 2Heat the oven to 120C/100C fan/gas 1. Mix the icing sugar, cocoa and cinnamon in a bowl, then stir in the banana to coat. Set aside.STEP 3To make the creamy filling, put the soft cheese, mascarpone, sugar, vanilla extract, eggs and flour in a bowl. Beat using an electric whisk until smooth, about 3-4 mins. Gently fold in the banana mixture.STEP 4Take the base out of the fridge and pour over the filling. Level off the top using the back of a spoon, then drizzle the 100g caramel on top.STEP 5Bake in the oven for 1 hr with a tray placed underneath the tin to catch any drips of butter. Turn the oven off and leave the door ajar, using a spoon or spatula to prop it open. Leave inside until the oven is completely cool. Remove from the oven, then transfer to the fridge to chill overnight.STEP 6When ready to serve, make the sweet cream topping. Beat the cream and sugar in a bowl until it forms soft peaks. Remove the cheesecake from the tin and spread the cream over the top, drizzle with the 2 tbsp caramel, dust with cocoa and scatter with the banana chips, if using. Cut into nine pieces or 16 bite-sized squares to serve."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
