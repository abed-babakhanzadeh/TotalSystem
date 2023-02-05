namespace ApplicationTotalSystem.Services.Product
{
	using ApplicationTotalSystem.Dto.Products;

	public interface IProductService
	{
		List<ProductListDto> GetProductsAsync();
	}
}
