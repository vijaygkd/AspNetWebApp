﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper
{
    public interface IDataProvider<T>
    {
        IEnumerable<T> GetData();
    }
}
