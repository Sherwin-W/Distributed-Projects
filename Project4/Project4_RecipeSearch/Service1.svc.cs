using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Project4_RecipeSearch
{
    public class Service1 : IService1
    {
        public string FindRecipes(string ingredients)
        {
            string result = "";
            string[] parts = ingredients.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(part => part.Trim())
                             .ToArray();

            //join ingredients for url formatting
            string formattedString = string.Join("%2C", parts);

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/recipes/findByIngredients?ingredients={formattedString}&number=5&ignorePantry=true&ranking=1"),
                Headers =
                {
                    { "X-RapidAPI-Key", "25cd25298amsh3c34490bdd6f705p150bedjsn37fa6b2b59d8" },
                    { "X-RapidAPI-Host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com" },
                },
            };
            using (var response = client.SendAsync(request).Result)
            {
                response.EnsureSuccessStatusCode();
                var responseContent = response.Content.ReadAsStringAsync().Result;

                // Parse the JSON response
                var recipes = JsonConvert.DeserializeObject<List<Recipe>>(responseContent);

                // Display the title and image URL for each recipe
                foreach (var recipe in recipes)
                {
                    result += ($"{recipe.title}#");
                    result += ($"{recipe.image}####");
                }
            }
            return result;
        }

        public class Recipe
        {
            public string title { get; set; }
            public string image { get; set; }
        }
    }
}
