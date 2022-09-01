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
    [ReferenceList("Shesha.Enterprise", "Bank")]
    public enum RefListBank : long
    {
        /// <summary>
        /// First National Bank
        /// </summary>
        [Description("First National Bank")]
        FNB = 1,

        /// <summary>
        /// ABSA
        /// </summary>
        [Description("ABSA")]
        ABSA = 2,

        /// <summary>
        /// Standard Bank
        /// </summary>
        [Description("Standard Bank")]
        StandardBank = 3
    }
}