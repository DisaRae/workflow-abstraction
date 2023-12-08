using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    /// <summary>
    /// The type of Work Item.  It associates Work Items across Work Flows
    /// This class is a database enum
    /// </summary>
    public class WorkItemType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
