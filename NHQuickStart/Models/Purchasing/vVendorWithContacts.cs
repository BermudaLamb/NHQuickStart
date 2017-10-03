using System;
using System.Collections.Generic;

namespace NHQuickStart.Models.Purchasing
{
	public class vVendorWithContacts
	{
		public virtual Int64 BusinessEntityID { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string ContactType { get; set; }	// NOT NULL
		public virtual string Title { get; set; }
		public virtual string FirstName { get; set; }	// NOT NULL
		public virtual string MiddleName { get; set; }
		public virtual string LastName { get; set; }	// NOT NULL
		public virtual string Suffix { get; set; }
		public virtual string PhoneNumber { get; set; }
		public virtual string PhoneNumberType { get; set; }
		public virtual string EmailAddress { get; set; }
		public virtual Int64 EmailPromotion { get; set; }	// NOT NULL
	}
}
