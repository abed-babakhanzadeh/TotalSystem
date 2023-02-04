using System;
using System.Collections.Generic;
using System.Text;

namespace DomainTotoalSystem.Entities.Common
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public DateTime DateModify { get; set; }

		public DateTime DateChanged { get; set; }

		public int UserModify { get; set; }
	}
}
