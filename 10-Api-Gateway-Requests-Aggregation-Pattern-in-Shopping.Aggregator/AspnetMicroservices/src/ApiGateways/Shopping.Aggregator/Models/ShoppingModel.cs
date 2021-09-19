namespace Shopping.Aggregator.Models
{
    using System.Collections.Generic;

    public class ShoppingModel
    {
        public string UserName { get; set; }

        public BasketModel BasketWithProducts { get; set; }

        public IEnumerable<OrderResponseModel> Orders { get; set; }
    }
}
