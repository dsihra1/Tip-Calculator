﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_TipCalc
{
    public static class Tip
    {
        public static double tip(double amount, double percent)
        {
            return amount * percent / 100d;
        }
        public static double tipNoTax(double amount, double percent)
        {
            return (amount / 1.13d) * percent / 100d;
        }
    }
}
