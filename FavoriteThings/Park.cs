using System;

namespace FavoriteThings.Favorites
{
    class Park
    {
        protected string _area;
        protected string _name;
        protected bool _openInWinter;
        public string Area
        {
            get
            {
                return _area;
            }
            set
            {
                _area = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Park() //Constructor Method
        {
            _area = Area;
        }

        public bool OpenInWinter
        {
            get
            {
                return _openInWinter;
            }
            set
            {
                if (value)
                {
                    _openInWinter = true;
                }
                if (!value)
                {
                    _openInWinter = false;
                }
            }

        }
        public string WinterParkSearch(bool OpenInWinter)
        {
            if (!OpenInWinter)
            {
                Console.WriteLine($"{_name} is empty.");
                return "It's a warm weather park.";
            }
            Console.WriteLine($"{_name} is open for business.");
            return "Winter friendly!";
        }
    }
}
