﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLibrary
{
    public class Hashtag
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public virtual Post Post { get; set; }
    }
}
