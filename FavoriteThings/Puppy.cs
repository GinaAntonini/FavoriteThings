using System;

namespace FavoriteThings.Favorites

{
    class Puppy
    {
        protected string _breed;
        protected string _size;
        protected bool _isHypoallergenic;
        public string Breed
        {
            get
            {
                return $"This puppy is a {_breed}";
            }
            set
            {
                _breed = value;
            }
        }
        public string Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
            }
        }
        public Puppy()  //Constructor Method
        {
            _breed = Breed;
        }

        public bool IsHypoallergenic
        {
            get
            {
                return _isHypoallergenic;
            }
            set
            {
                if (value)
                {
                    _isHypoallergenic = true;
                }
                if (!value)
                {
                    _isHypoallergenic = false;
                }
            }
        }
        public string InducingSneezes(bool IsHypoallergenic)
        {
            if (!IsHypoallergenic)
            {
                Console.WriteLine($"{_breed} makes me sneeze.");
                return "This dog is definitely not allergy friendly.";
            }
            Console.WriteLine($"{_breed} doesn't make me sneeze!");
            return "We can get this dog!";
        }
    }
}
