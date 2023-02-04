namespace DomainTotoalSystem.Entities
{
	using DomainTotoalSystem.Entities.Common;

	public class Product : BaseEntity
	{
		public string ProductCode { get; set; }
		public string Name { get; set; }
		public int? TypeId { get; set; }
		public string? Unit { get; set; }
		public float? Weight { get; set; }
	}
}
