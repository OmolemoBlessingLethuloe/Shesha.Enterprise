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
    [ReferenceList("Shesha.Enterprise", "InvoiceStatus")]
    public enum RefListInvoiceStatus : long
    {
        /// <summary>
        /// Draft
        /// </summary>
        [Description("Draft")]
        Draft = 1,

        /// <summary>
        /// Finalised
        /// </summary>
        [Description("Finalised")]
        Finalised = 2,

        /// <summary>
        /// Cancelled
        /// </summary>
        [Description("Cancelled")]
        Cancelled = 3
    }
}