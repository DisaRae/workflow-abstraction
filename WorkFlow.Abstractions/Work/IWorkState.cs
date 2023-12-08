using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    public interface IWorkState<T>
    {
        string WorkStateId { get; set; }
        string OrderNumber { get; set; }
        /// <summary>
        ///   Id relevant to any product identifier that work is being done on (I.E. OrderNumber, RecordingDocumentId)
        ///   SELECT recording_document_id AS 'ReferenceId'
        ///   FROM workflow.document_state
        ///   SELECT order_number AS 'ReferenceId'
        ///   FROM dbo.order_status
        /// </summary>
        T ReferenceId { get; set; }

        int WorkItemId { get; set; }

        string UsernameEntered { get; set; }

        string UsernameCompleted { get; set; }

        DateTime DateEntered { get; set; }

        /// <summary>
        /// Completion date is null until state is completed
        /// </summary>
        DateTime? DateCompleted { get; set; }

        int CompletionCode { get; set; }

        /// <summary>
        /// Tracking point is only entered upon state completion
        /// </summary>
        int? TrackingPointIdEntered { get; set; }

        IEnumerable<IWorkFlag> Flags { get; set; }
    }
}
