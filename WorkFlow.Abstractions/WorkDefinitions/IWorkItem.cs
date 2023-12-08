using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWorkItem
    {
        /// <summary>
        /// Id of Work Item
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Name of Work Item
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The Work Flow that the Work Item belongs to
        /// </summary>
        int WorkFlowId { get; set; }

        /// <summary>
        /// The type of work item (IE. Vendor Assign)
        /// There can be multiple work items that share a Work Item Type across Work Flows
        /// </summary>
        WorkItemType WorkItemType { get; set; }

        /// <summary>
        /// A list of user who are allowed to work and/or complete this work item
        /// </summary>
        IEnumerable<IUserActionable> UsersActionable { get; set; }

        /// <summary>
        /// The user that created the Work Item
        /// </summary>
        string UsernameCreated { get; set; }

        /// <summary>
        /// The user that last modified the Work Item
        /// </summary>
        string UsernameModified { get; set; }

        /// <summary>
        /// Date that the Work Item was created
        /// </summary>
        DateTime DateCreated { get; set; }

        /// <summary>
        /// Date that the Work Item was last modified
        /// </summary>
        DateTime DateModified { get; set; }

        /// <summary>
        /// The display order of the work item queues
        /// If zero, do not display.  This also allows queues to be displayed or hidden on database change instead of software deployment.
        /// </summary>
        int DisplayOrder { get; set; }
    }
}
