using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.Orders
{
    /// <summary>
    /// 
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "OrderStatus")]
    public enum RefListOrderStatus : long
    {
        /// <summary>
        /// Order Received
        /// </summary>
        [Description("Order Received")]
        OrderReceived = 1,

        /// <summary>
        /// Ready for Collection
        /// </summary>
        [Description("Ready for Collection")]
        ReadyForCollection = 2,

        /// <summary>
        /// Order Cancelled
        /// </summary>
        [Description("Order Cancelled")]
        OrderCancelled = 3,

        /// <summary>
        /// Awaiting Supplier Delivery
        /// </summary>
        [Description("Awaiting Supplier Delivery")]
        AwaitingSupplierDelivery = 4,

        /// <summary>
        /// Order submitted
        /// </summary>
        [Description("Order submitted")]
        OrderSubmitted = 5,

        /// <summary>
        /// Draft
        /// </summary>
        [Description("Draft")]
        Draft = 6,

        /// <summary>
        /// Completed
        /// </summary>
        [Description("Completed")]
        Completed = 7
    }
}