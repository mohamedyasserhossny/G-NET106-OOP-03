using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_asigment_3
{
    internal sealed class compeletedshipment : Shipment
    {
        public compeletedshipment(string Trackingcode, string Description, decimal Weight, decimal Delevaryfee, Delevaryadress Destiontion) : base(Trackingcode, Description, Weight, Delevaryfee, Destiontion)
        {
        }
    }
}
