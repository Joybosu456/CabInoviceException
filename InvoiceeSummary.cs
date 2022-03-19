using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInoviceGenarator
{
    public class InvoiceeSummary
    {
        private int numberOfRiders;
        private double totalFare;
        private double avarageFare;
         public InvoiceeSummary(int numberOfRiders,double totalfare)
        {
            this.numberOfRiders = numberOfRiders;
            this.totalFare = totalfare;
            this.avarageFare = this.totalFare/this.numberOfRiders;
        }
        public override bool Equals(object obj)
        {
            if(obj==null) return false;
            if (!(obj is InvoiceeSummary)) return false;
            InvoiceeSummary inpubObject = (InvoiceeSummary)obj;

            return this.numberOfRiders== inpubObject.numberOfRiders && this.totalFare== inpubObject.totalFare && this.avarageFare== inpubObject.avarageFare;
        }
        public override int GetHashCode()
        {
            return this.numberOfRiders.GetHashCode();
        }
    }
}
