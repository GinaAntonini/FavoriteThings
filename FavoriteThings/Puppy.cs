﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Puppy
    {
        protected string _breed;
        protected string _size;
        public string breed
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
        public string size
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
    }
}
