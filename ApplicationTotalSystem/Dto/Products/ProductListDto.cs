namespace ApplicationTotalSystem.Dto.Products
{
	public class ProductListDto
	{
		public string ProductCode { get; set; }
		public string Name { get; set; }
		public int? TypeId { get; set; }
		public string? Unit { get; set; }
		public float? Weight { get; set; }

		//public int Id { get; set; }
		//public DateTime? DateModify { get; set; }
		//public DateTime? DateChanged { get; set; }
		//public int? UserModify { get; set; }
	}
}
