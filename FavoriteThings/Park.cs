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
                return $"This park is located in {_area}";
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
        public Park()  // Constructor Method
        {
            _name = Name;
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
    }
}
