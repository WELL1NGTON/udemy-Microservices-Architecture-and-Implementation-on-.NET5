namespace AspnetRunBasics.Models
{
    using System.Collections.Generic;

    public class BasketModel
    {
        public string UserName { get; set; }

        public List<BasketItemModel> Items { get; set; } = new List<BasketItemModel>();

        public decimal TotalPrice { get; set; }
    }
}
