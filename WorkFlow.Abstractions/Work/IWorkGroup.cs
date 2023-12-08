using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    public interface IWorkGroup
    {
        int Id { get; set; }
        int GroupId { get; set; }
        int WorkItemId { get; set; }
    }
}
