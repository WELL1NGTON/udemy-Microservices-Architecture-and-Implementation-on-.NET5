namespace Shopping.Aggregator.Models
{
    using System.Collections.Generic;

    public class BasketModel
    {
        public string UserName { get; set; }

        public List<BasketItemExtendedModel> Items { get; set; }

        public decimal TotalPrice { get; set; }
    }
}