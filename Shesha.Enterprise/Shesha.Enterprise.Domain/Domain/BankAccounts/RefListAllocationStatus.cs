using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.BankAccounts
{
    /// <summary>
    /// 
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "AllocationStatus")]
    public enum RefListAllocationStatus : long
    {
        /// <summary>
        /// Allocated
        /// </summary>
        [Description("Allocated")]
        Allocated = 1,

        /// <summary>
        /// Unallocated
        /// </summary>
        [Description("Unallocated")]
        Unallocated = 2,

        /// <summary>
        /// Awaiting Approval
        /// </summary>
        [Description("Awaiting Approval")]
        AwaitingApproval = 3,

        /// <summary>
        /// Allocation Rejected
        /// </summary>
        [Description("Allocation Rejected")]
        AllocationRejected = 4,

        /// <summary>
        /// Not Applicable
        /// </summary>
        [Description("Not Applicable")]
        NotApplicable = 5
    }
}