using System;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
	public class vProductModelCatalogDescription
	{
		public virtual Int64 ProductModelID { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string Summary { get; set; }
		public virtual string Manufacturer { get; set; }
		public virtual string Copyright { get; set; }
		public virtual string ProductURL { get; set; }
		public virtual string WarrantyPeriod { get; set; }
		public virtual string WarrantyDescription { get; set; }
		public virtual string NoOfYears { get; set; }
		public virtual string MaintenanceDescription { get; set; }
		public virtual string Wheel { get; set; }
		public virtual string Saddle { get; set; }
		public virtual string Pedal { get; set; }
		public virtual string BikeFrame { get; set; }
		public virtual string Crankset { get; set; }
		public virtual string PictureAngle { get; set; }
		public virtual string PictureSize { get; set; }
		public virtual string ProductPhotoID { get; set; }
		public virtual string Material { get; set; }
		public virtual string Color { get; set; }
		public virtual string ProductLine { get; set; }
		public virtual string Style { get; set; }
		public virtual string RiderExperience { get; set; }
		public virtual Guid rowguid { get; set; }	// NOT NULL
		public virtual DateTime ModifiedDate { get; set; }	// NOT NULL
	}
}
