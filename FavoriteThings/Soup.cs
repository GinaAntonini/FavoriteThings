using System;

namespace FavoriteThings.Favorites
{
    class Soup
    {
        protected string _type;
        protected string _spiceLevel;
        protected bool _isVegetarian;
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public string SpiceLevel
        {
            get
            {
                return $"This soup is {_spiceLevel} spicy.";
            }
            set
            {
                _spiceLevel = value;
            }
        }
        public Soup()  // Constructor Method
        {
            _type = Type;
        }

        public bool IsVegetarian
        {
            get
            {
                return _isVegetarian;
            }
            set
            {
                if (value)
                {
                    _isVegetarian = true;
                }
                if (!value)
                {
                    _isVegetarian = false;
                }
            }
        }
        public string VegetarianSafety(bool IsVegetarian)
        {
            if (!IsVegetarian)
            {
                Console.WriteLine($"{_type} has meat in it.");
                return "Not safe for vegetarians!";
            }
            Console.WriteLine($"{_type} is meat free.");
            return "Vegetarians may proceed.";
        }
    }
}
