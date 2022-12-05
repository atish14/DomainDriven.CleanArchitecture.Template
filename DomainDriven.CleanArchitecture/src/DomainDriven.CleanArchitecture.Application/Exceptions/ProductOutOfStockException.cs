using System;

namespace DomainDriven.CleanArchitecture.Application
{
    public class ProductOutOfStockException : Exception
    {
        public ProductOutOfStockException()
        {
        }

        public ProductOutOfStockException(string message)
            : base(message)
        {
        }

        public ProductOutOfStockException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
