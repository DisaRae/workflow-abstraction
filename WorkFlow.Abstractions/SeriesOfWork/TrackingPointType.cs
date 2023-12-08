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
    /// This class is a database enum
    /// </summary>
    public class TrackingPointType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
