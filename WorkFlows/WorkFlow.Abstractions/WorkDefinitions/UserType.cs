using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nations.WorkFlow.Abstractions
{
    /// <summary>
    /// The type of user
    /// (IE. Automation, Employee, Client, Vendor)
    /// This class is a database enum
    /// </summary>
    public class UserType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
