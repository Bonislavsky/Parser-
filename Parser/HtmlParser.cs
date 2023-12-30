using AngleSharp;

namespace Parser
{
    public static class HtmlParser
    {
        public static async Task<List<Product>> ParseHtml(string html)
        {
            var context = BrowsingContext.New(Configuration.Default);
            var document = await context.OpenAsync(req => req.Content(html));

            var productList = document.QuerySelector("#layer-product-list");
            var productsGrid = productList?.QuerySelector(".products.wrapper.grid.products-grid");
            var products = productsGrid?.QuerySelectorAll(".products.list.items.product-items > li.item.product.product-item");


            var result = new List<Product>();
            foreach (var product in products)
            {
                var productData = product.QuerySelector(".product-item-info");
                // далее парсим к примеру цену, путь к цене указан в скриншоте 
                result.Add(new Product()
                {
                    Manufacturer = "",
                    Name = "",
                    Price = 0m,
                    SKU = "",
                });
            }

            return result;
        }
    }
}
