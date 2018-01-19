using System;
using FavoriteThings.Favorites;
using System.Collections.Generic;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var puppies = new List<Puppy>
            {
                new Puppy {Breed = "German Shepherd", Size = "large", IsHypoallergenic = false},
                new Puppy {Breed = "Golden Doodle", Size = "large", IsHypoallergenic = true},
                new Puppy {Breed = "Mastiff", Size = "extra large", IsHypoallergenic = false}
            };

            foreach (var puppy in puppies)
            {
                Console.WriteLine($"{puppy.Breed} dogs are {(puppy.IsHypoallergenic ? "allergy safe" : "sneeze inducers")}");
            }

            var parks = new List<Park>
            {
                new Park {Area = "East Nashville", Name = "Two Rivers Waterpark", OpenInWinter = false},
                new Park {Area = "Cumberland Plateau", Name = "Fiery Gizzard Trail", OpenInWinter = true},
                new Park {Area = "East Nashville", Name = "Shelby Park", OpenInWinter = true}
            };

            foreach (var park in parks)
            {
            }

            var soups = new List<Soup>
            {
                new Soup {Type = "Vegetarian Chili", SpiceLevel = "Ghost pepper hot", IsVegetarian = true},
                new Soup {Type = "Clam Chowder", SpiceLevel = "Not spicy", IsVegetarian = false},
                new Soup {Type = "Tom Yum", SpiceLevel = "Medium", IsVegetarian = false}
            };

            foreach (var soup in soups)
            {
            }

            var foods = new List<Food>
            {
                new Food {Cuisine = "Thai", SampleDish = "Pad Kra Prow", EatWithHands = false},
                new Food {Cuisine = "Etiophian", SampleDish = "Injera", EatWithHands = true},
                new Food {Cuisine = "Vietnamese", SampleDish = "Bahn Mi", EatWithHands = true}
            };

            foreach (var food in foods)
            {
            }
        }

    }
}

