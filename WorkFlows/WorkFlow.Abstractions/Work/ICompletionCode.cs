using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    public interface ICompletionCode
    {
        int Id { get; set; }
        int WorkItemId { get; set; }
        int Code { get; set; }
        IEnumerable<IWorkGroup> NextWorkItemGroup { get; set; }
        string Description { get; set; }
        string TrackingPointCode { get; set; }
    }
}
