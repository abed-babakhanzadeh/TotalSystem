using System;
using System.Collections.Generic;
using System.Text;

namespace DomainTotoalSystem.Entities
{
	using DomainTotoalSystem.Entities.Common;

	public class Product : BaseEntity
	{
		public string ProductCode { get; set; }
		public string Type { get; set; }
		public string Unit { get; set; }
		public int Weight { get; set; }
	}
}
