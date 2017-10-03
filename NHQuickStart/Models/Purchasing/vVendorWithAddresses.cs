using System;
using System.Collections.Generic;

namespace NHQuickStart.Models.Purchasing
{
	public class vVendorWithAddresses
	{
		public virtual Int64 BusinessEntityID { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string AddressType { get; set; }	// NOT NULL
		public virtual string AddressLine1 { get; set; }	// NOT NULL
		public virtual string AddressLine2 { get; set; }
		public virtual string City { get; set; }	// NOT NULL
		public virtual string StateProvinceName { get; set; }	// NOT NULL
		public virtual string PostalCode { get; set; }	// NOT NULL
		public virtual string CountryRegionName { get; set; }	// NOT NULL
	}
}
