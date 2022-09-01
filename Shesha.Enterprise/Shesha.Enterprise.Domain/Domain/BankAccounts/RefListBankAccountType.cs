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
    [ReferenceList("Shesha.Enterprise", "BankAccountType")]
    public enum RefListBankAccountType : long
    {
        /// <summary>
        /// CurrentAccount
        /// </summary>
        [Description("CurrentAccount")]
        CurrentAccount = 1
    }
}