using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.CheckLists
{
    /// <summary>
    /// Checklist selection type (yes/no/na)
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "CheckListSelectionType")]
    public enum RefListCheckListSelectionType : long
    {
        /// <summary>
        /// Yes
        /// </summary>
        [Description("Yes")]
        Yes = 1,

        /// <summary>
        /// No
        /// </summary>
        [Description("No")]
        No = 2,

        /// <summary>
        /// N/A
        /// </summary>
        [Description("N/A")]
        NotAvailable = 3
    }
}