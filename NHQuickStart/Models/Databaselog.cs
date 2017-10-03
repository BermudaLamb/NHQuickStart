using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models
{
    public class Databaselog
    {
        public Databaselog() { }
		public virtual long Databaselogid { get; set; }	// NOT NULL
		public virtual DateTime Posttime { get; set; }	// NOT NULL
		public virtual string Databaseuser { get; set; }	// NOT NULL
		public virtual string Event { get; set; }	// NOT NULL
		public virtual string Schema { get; set; }
		public virtual string Object { get; set; }
		public virtual string Tsql { get; set; }	// NOT NULL
		public virtual string Xmlevent { get; set; }	// NOT NULL
    }
}
