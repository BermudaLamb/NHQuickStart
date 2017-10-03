using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Product
    {
        public Product() { }
		public virtual long Productid { get; set; }	// NOT NULL
		public virtual string Name { get; set; }	// NOT NULL
		public virtual string Productnumber { get; set; }	// NOT NULL
		public virtual bool Makeflag { get; set; }	// NOT NULL
		public virtual bool Finishedgoodsflag { get; set; }	// NOT NULL
		public virtual string Color { get; set; }
		public virtual int Safetystocklevel { get; set; }	// NOT NULL
		public virtual int Reorderpoint { get; set; }	// NOT NULL
		public virtual decimal Standardcost { get; set; }	// NOT NULL
		public virtual decimal Listprice { get; set; }	// NOT NULL
		public virtual string Size { get; set; }
		public virtual string Sizeunitmeasurecode { get; set; }
		public virtual Unitmeasure SizeUnitmeasure { get; set; }
		public virtual string Weightunitmeasurecode { get; set; }
		public virtual Unitmeasure WeightUnitmeasure { get; set; }
		public virtual decimal? Weight { get; set; }
		public virtual long Daystomanufacture { get; set; }	// NOT NULL
		public virtual string Productline { get; set; }
		public virtual string Class { get; set; }
		public virtual string Style { get; set; }
		public virtual long? Productsubcategoryid { get; set; }
		public virtual Productsubcategory Productsubcategory { get; set; }
		public virtual long? Productmodelid { get; set; }
		public virtual Productmodel Productmodel { get; set; }
		public virtual DateTime Sellstartdate { get; set; }	// NOT NULL
		public virtual DateTime? Sellenddate { get; set; }
		public virtual DateTime? Discontinueddate { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
