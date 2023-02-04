namespace ApplicationTotalSystem.Dto.Products
{
	public class ProductListDto
	{
		public string ProductCode { get; set; }
		public string Name { get; set; }
		public int? TypeId { get; set; }
		public string? Unit { get; set; }
		public float? Weight { get; set; }
	}
}
