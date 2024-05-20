﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvertionDataEx.Entities
{
    public class User
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public Profile Profile { get; set; }

        override public string ToString()
        {
            return UserName;
        }

    }
}
