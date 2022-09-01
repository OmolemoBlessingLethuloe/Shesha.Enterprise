using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.Accounts.Payments
{
    /// <summary>
    /// 
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "PaymentMethod")]
    public enum RefListPaymentMethod : long
    {
    }
}