using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.Suppliers
{
    /// <summary>
    /// 
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "SupplierStatus")]
    public enum RefListSupplierStatus : long
    {
        /// <summary>
        /// Active
        /// </summary>
        [Description("Active")]
        Active = 1,

        /// <summary>
        /// DeActivated
        /// </summary>
        [Description("DeActivated")]
        DeActivated = 2
    }
}