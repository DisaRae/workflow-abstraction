

using System;

namespace Nations.WorkFlow.Abstractions
{
    public interface IWorkFlag
    {
        int Id { get; set; }
        WorkFlagType WorkFlagType { get; set;}
        string UsernameEntered { get; set; }
        DateTime DateEntered { get; set; }
    }
}
