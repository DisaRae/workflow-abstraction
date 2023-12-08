using System;
using System.Collections.Generic;

namespace Nations.WorkFlow.Abstractions
{
    /// <summary>
    /// A Work Flow is a series of portions of work.  The results of each portion of work lead to a next portion of work.
    /// </summary>
    public interface IWorkFlow
    {
        /// <summary>
        /// Id of the Work Flow
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Name of the Work Flow
        /// Usually associated with the work performed for a specific product
        /// </summary>
        string Name { get; set; } 

        /// <summary>
        /// A description of what happens in the process as a whole
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// A list of generic tracking points associated with a work flow but not any specific step in the process.
        /// The allowed tracking points are tied to the associated Party Service Group Id
        /// </summary>
        IEnumerable<WorkFlowTrackingPoint> TrackingPointGroup { get; set; }

        /// <summary>
        /// Work Flow is tied to the product indicated by the Party Service Group Id in the dbo.order_companies table
        /// </summary>
        int PartyServiceGroupId { get; set; }

        /// <summary>
        /// Linking the Work Flow to the Specific Service Id allows variations in work process based on product sub-type
        /// </summary>
        int SpecificServiceId { get; set; }

        /// <summary>
        /// When a unit (order, document, work order) gets put into a Work Flow, this is the first Work Item state that it gets placed in
        /// (IE.  Check-In, Verify Order)
        /// </summary>
        int FirstWorkItemId { get; set; }

        /// <summary>
        /// In some cases, Work Flows may need to be deactivated to allow changes to the company's work process
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// The date the Work Flow is deactivated
        /// </summary>
        DateTime? DateDeactivated { get; set; }
    }
}