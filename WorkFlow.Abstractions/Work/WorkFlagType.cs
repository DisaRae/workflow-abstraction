using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    /// <summary>
    /// Overdue, MissingBorrowerPhone, MissingNotarySignature
    /// </summary>
    public class WorkFlagType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
