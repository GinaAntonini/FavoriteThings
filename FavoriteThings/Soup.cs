using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Soup
    {
        protected string _type;
        protected string _spiceLevel;
        public string Type
        {
            get
            {
                return $"This is {_type} soup.";
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
    }
}
