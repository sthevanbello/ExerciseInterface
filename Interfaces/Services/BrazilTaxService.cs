﻿
namespace Interfaces.Services
{
    class BrazilTaxService
    {

        public double Tax(double amount)
        {
            if (amount > 100)
            {
                return amount * 0.15;
            }
            else
            {
                return amount * 0.2;
            }
        }
    }
}
