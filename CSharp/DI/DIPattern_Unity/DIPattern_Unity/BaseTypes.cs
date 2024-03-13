﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern_Unity
{
    public interface IProducts
    {
        string InsertProducts();
    }

    public interface IOrders
    {
        void DisplayOrders();
    }
}
