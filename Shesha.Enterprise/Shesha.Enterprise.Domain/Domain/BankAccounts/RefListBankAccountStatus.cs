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
    [ReferenceList("Shesha.Enterprise", "BankAccountStatus")]
    public enum RefListBankAccountStatus : long
    {
        /// <summary>
        /// Active
        /// </summary>
        [Description("Active")]
        Active = 1,

        /// <summary>
        /// Closed
        /// </summary>
        [Description("Closed")]
        Closed = 2
    }
}