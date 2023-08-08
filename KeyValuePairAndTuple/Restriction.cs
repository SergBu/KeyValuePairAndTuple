using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KeyValuePairAndTuple
{

    public class Restriction
    {
        public Restriction()
        {
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public DateTime? Expired { get; set; }
        public bool Shared { get; set; }
        public int CombinationCropWithParameterId { get; set; }
        public int VehiclesCount { get; set; }
        public int MaxVehiclesCount { get; set; }

        //public virtual TerminalGate TerminalGate { get; set; }

        public int? TerminalGateId { get; set; }

        public int[] Reservations { get; set; }

        public bool ShouldSerializeParentId() => !ParentId.Equals(0);
    }
}