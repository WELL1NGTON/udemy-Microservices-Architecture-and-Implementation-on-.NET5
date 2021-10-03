namespace AspnetRunBasics.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AspnetRunBasics.Models;

    public interface ICatalogService
    {
        Task<IEnumerable<CatalogModel>> GetCatalog();

        Task<IEnumerable<CatalogModel>> GetCatalogByCategory(string category);

        Task<CatalogModel> GetCatalog(string id);

        Task<CatalogModel> CreateCatalog(CatalogModel model);
    }
}
