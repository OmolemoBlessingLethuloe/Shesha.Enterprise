using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.Invoices
{
    /// <summary>
    /// 
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "ContractStatus")]
    public enum RefListContractStatus : long
    {
        /// <summary>
        /// Active
        /// </summary>
        [Description("Active")]
        Active = 1,

        /// <summary>
        /// Deactivated
        /// </summary>
        [Description("Deactivated")]
        Deactivated = 2
    }
}