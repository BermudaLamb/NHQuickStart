using System;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
	public class vProductModelInstructions
	{
		public virtual Int64 ProductModelID { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string Instructions { get; set; }
		public virtual Int64 LocationID { get; set; }
		public virtual decimal SetupHours { get; set; }
		public virtual decimal MachineHours { get; set; }
		public virtual decimal LaborHours { get; set; }
		public virtual Int64 LotSize { get; set; }
		public virtual string Step { get; set; }
		public virtual Guid rowguid { get; set; }	// NOT NULL
		public virtual DateTime ModifiedDate { get; set; }	// NOT NULL
	}
}
