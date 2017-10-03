using System;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
	public class vProductAndDescription
	{
		public virtual Int64 ProductID { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string ProductModel { get; set; }	// NOT NULL
		public virtual string CultureID { get; set; }	// NOT NULL
		public virtual string Description { get; set; }	// NOT NULL
	}
}
