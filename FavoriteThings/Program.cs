using System;
using FavoriteThings.Favorites;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var puppy = new Puppy
            {
                Breed = "German Shepherd",
                Size = "Medium",
                IsHypoallergenic = false
            };
            puppy.InducingSneezes(puppy.IsHypoallergenic);

            var park = new Park
            {
                Area = "East Nashville",
                Name = "Two Rivers Waterpark",
                OpenInWinter = false
            };
            park.WinterParkSearch(park.OpenInWinter);

            var soup = new Soup
            {
                Type = "Vegetarian Chili", 
                SpiceLevel = "Ghost pepper hot",
                IsVegetarian = true
            };
            soup.VegetarianSafety(soup.IsVegetarian);
        }

    }
}

