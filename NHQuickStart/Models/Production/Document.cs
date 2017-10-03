using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Document
    {
        public Document() { }
		public virtual string Documentnode { get; set; }	// NOT NULL
		public virtual int? Documentlevel { get; set; }
		public virtual string Title { get; set; }	// NOT NULL
		public virtual long Owner { get; set; }	// NOT NULL
		public virtual HumanResources.Employee Employee { get; set; }
		public virtual bool Folderflag { get; set; }	// NOT NULL
		public virtual string Filename { get; set; }	// NOT NULL
		public virtual string Fileextension { get; set; }	// NOT NULL
		public virtual string Revision { get; set; }	// NOT NULL
		public virtual long Changenumber { get; set; }	// NOT NULL
		public virtual short Status { get; set; }	// NOT NULL
		public virtual string Documentsummary { get; set; }
		public virtual byte[] Documentval { get; set; }
		public virtual System.Guid Rowguid { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
