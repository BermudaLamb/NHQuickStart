using System;
using System.Text;
using System.Collections.Generic;

namespace NHQuickStart.Models.Sales
{
    public class Currencyrate
    {
        public Currencyrate() { }
		public virtual long Currencyrateid { get; set; }	// NOT NULL
		public virtual DateTime Currencyratedate { get; set; }	// NOT NULL
		public virtual string Fromcurrencycode { get; set; }	// NOT NULL
		public virtual Currency FromCurrency { get; set; }
		public virtual string Tocurrencycode { get; set; }	// NOT NULL
		public virtual Currency ToCurrency { get; set; }
		public virtual decimal Averagerate { get; set; }	// NOT NULL
		public virtual decimal Endofdayrate { get; set; }	// NOT NULL
		public virtual DateTime Modifieddate { get; set; }	// NOT NULL
    }
}
