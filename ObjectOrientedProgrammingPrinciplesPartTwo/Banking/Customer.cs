using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class Customer
    {
        private bool isIndividual;

        public bool IsIndividual
        {
            get { return this.isIndividual; }
            set
            {
                this.isIndividual = value;
            }
        }

        public Customer(bool isIndividual)
        {
            this.isIndividual = isIndividual;
        }
    }
}
