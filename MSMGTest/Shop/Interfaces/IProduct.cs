﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Interfaces
{
    public interface IProduct
    {
        int Id { get; }
        decimal Price { get; }
    }
}
