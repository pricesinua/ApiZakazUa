using ApiZakazUa.Resources;

namespace ApiZakazUa;

public partial class Client
{
    public Task<IReadOnlySet<Category>?> GetCategoriesAsync(int storeId)
    {
        return Task.Factory.StartNew(() => GetCategories(storeId));
    }

    public Task<IReadOnlySet<Product>?> GetProductsAsync(int storeId, string categoryId)
    {
        return Task.Factory.StartNew(() => GetProducts(storeId, categoryId));
    }

    public Task<IReadOnlySet<Store>?> GetStoresAsync()
    {
        return Task.Factory.StartNew(() => GetStores());
    }
}