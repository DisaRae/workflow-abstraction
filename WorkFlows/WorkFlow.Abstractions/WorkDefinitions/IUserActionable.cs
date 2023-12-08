using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    /// <summary>
    /// The type of user allowed to perform action on or complete a Work Item
    /// (IE. Vendors can only complete Work Items through their portal that are associated with the UserType of Vendor)
    /// </summary>
    public interface IUserActionable
    {
        /// <summary>
        /// User Actionable Row Id
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// The associated Work Item
        /// </summary>
        int WorkItemId { get; set; }

        /// <summary>
        /// The type of user associated
        /// </summary>
        UserType UserType { get; set; }
    }
}
