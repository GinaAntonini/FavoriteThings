using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Park
    {
        protected string _area;
        protected string _name;
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

    }
}
