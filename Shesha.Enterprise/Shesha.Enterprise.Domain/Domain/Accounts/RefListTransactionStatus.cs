using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.Accounts
{
    /// <summary>
    /// 
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "TransactionStatus")]
    public enum RefListTransactionStatus : long
    {
        /// <summary>
        /// Pending
        /// </summary>
        [Description("Pending")]
        Pending = 1,

        /// <summary>
        /// Finalised
        /// </summary>
        [Description("Finalised")]
        Finalised = 2,

        /// <summary>
        /// Reversed
        /// </summary>
        [Description("Reversed")]
        Reversed = 3
    }
}