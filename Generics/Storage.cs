﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Storage<T>
    {
        public Storage()
        {

        }

        public List<T> Bin{ get; set; } = new List<T>();


    }
}
