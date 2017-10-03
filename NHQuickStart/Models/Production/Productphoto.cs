using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Production
{
    public class Productphoto
    {
        public Productphoto() { }
		public virtual long Productphotoid { get; set; }	// NOT NULL
		public virtual byte[] Thumbnailphoto { get; set; }
		public virtual string Thumbnailphotofilename { get; set; }
		public virtual byte[] Largephoto { get; set; }
		public virtual string Largephotofilename { get; set; }
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
