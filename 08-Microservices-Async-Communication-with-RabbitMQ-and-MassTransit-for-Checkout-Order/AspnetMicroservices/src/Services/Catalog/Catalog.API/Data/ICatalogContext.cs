namespace Catalog.API.Data
{
    using Catalog.API.Entities;
    using MongoDB.Driver;

    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}