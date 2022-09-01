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
    [ReferenceList("Shesha.Enterprise", "BankTransactionType")]
    public enum RefListBankTransactionType : long
    {
        /// <summary>
        /// Bank Charge
        /// </summary>
        [Description("Bank Charge")]
        BankCharge = 1,

        /// <summary>
        /// Client Payment By Stitch
        /// </summary>
        [Description("Client Payment By Stitch")]
        ClientPaymentByStitch = 2,

        /// <summary>
        /// Client Payment By EFT
        /// </summary>
        [Description("Client Payment By EFT")]
        ClientPaymentByEFT = 3,

        /// <summary>
        /// Allocation Not Required
        /// </summary>
        [Description("Allocation Not Required")]
        AllocationNotRequired = 4
    }
}