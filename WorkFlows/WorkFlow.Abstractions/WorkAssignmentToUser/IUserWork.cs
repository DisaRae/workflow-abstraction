using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    // TODO: Determine if this class should reference the Work State Id or the Reference Id

    /// <summary>
    /// This class allows Work States to be assigned to a user by themselves or another user.  
    /// This can be used for users or managers to create to-do lists for employees.
    /// </summary>
    public interface IUserWork
    {
        /// <summary>
        /// Row Id
        /// </summary>
        long Id { get; set; }

        /// <summary>
        /// The user that the Work State is assigned to
        /// </summary>
        string UsernameAssigned { get; set; }

        /// <summary>
        /// The user who created the record / assigned the work
        /// </summary>
        string UsernameEntered { get; set; }

        /// <summary>
        /// The id of the Work State assigned to the user
        /// </summary>
        long WorkStateId { get; set; }

        /// <summary>
        /// Date that the record was created
        /// </summary>
        DateTime DateAssigned { get; set; }

        /// <summary>
        /// The date that the assignment is marked completed
        /// </summary>
        DateTime? DateCompleted { get; set; }

        /// <summary>
        /// Assignment has been marked completed
        /// </summary>
        bool IsCompleted { get; set; }
    }
}
