using ApplicationTotalSystem.Dto.Products;

namespace ApplicationTotalSystem.Services.Product
{
	using ApplicationTotalSystem.DataBase;

	using AutoMapper;

	public class ProductService : IProductService
	{
		private readonly IDataBaseContext _context;
		private readonly IMapper _mapper;

		public ProductService(IDataBaseContext context , IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}


		public List<ProductListDto> GetProductsAsync()
		{
			var products = _context.Products;
			var productListDto = _mapper.Map<List<ProductListDto>>(products);
			return productListDto;
		}
	}
}
