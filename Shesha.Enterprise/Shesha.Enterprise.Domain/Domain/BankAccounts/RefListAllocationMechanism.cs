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
    [ReferenceList("Shesha.Enterprise", "AllocationMechanism")]
    public enum RefListAllocationMechanism : long
    {
        /// <summary>
        /// Manual
        /// </summary>
        [Description("Manual")]
        Manual = 1,

        /// <summary>
        /// Automated
        /// </summary>
        [Description("Automated")]
        Automated = 2
    }
}