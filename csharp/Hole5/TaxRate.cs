﻿using System;

namespace Hole5
{
    public class TaxRate
    {
        private readonly int percent;

        public TaxRate(int percent)
        {
            this.percent = percent;
        }

        public static TaxRate Of(int percent)
        {
            return new TaxRate(percent);
        }

        public Money Apply(Money total)
        {
            Double amount = total.value * (percent / 100d);
            return Money.Create(Convert.ToInt32(amount), total.currency);
        }
    }
}