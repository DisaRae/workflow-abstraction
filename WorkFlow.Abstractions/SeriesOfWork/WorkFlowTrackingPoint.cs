using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    /// <summary>
    /// Tracking points are strongly tied to Party Service Group Id and each party service shares some genenically used types of tracking points such as:
    /// Ordered, Canceled, ClientCorrespondence, VendorCorrespondence, SeeComments
    /// This class associates tracking point codes to a work flow with their generic use types (For example, you can pull any work flow's See Comments tracking point code)
    /// </summary>
    public class WorkFlowTrackingPoint
    {
        public int Id { get; set; }

        public int WorkFlowId { get; set; }

        public string StatusPoint { get; set; }

        public TrackingPointType TrackingPointType { get; set; }
    }
}
