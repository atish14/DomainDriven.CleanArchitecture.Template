using System;

namespace DomainDriven.CleanArchitecture.Contracts.v1
{
    public class AddProductRequest
    {
        public string ProductCode { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }

        public int ExpiryInMonths { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int StockQuantity { get; set; }
    }
}
