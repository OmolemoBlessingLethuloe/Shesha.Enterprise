using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.CheckLists
{
    /// <summary>
    /// Type of the check list item
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "CheckListItemType")]
    public enum RefListCheckListItemType : long
    {
        /// <summary>
        /// Group
        /// </summary>
        [Description("Group")]
        Group = 1,

        /// <summary>
        /// Two state (yes/no)
        /// </summary>
        [Description("Two state (yes/no)")]
        TwoState = 2,

        /// <summary>
        /// Tri state (yes/no/na)
        /// </summary>
        [Description("Tri state (yes/no/na)")]
        ThreeStateTriState = 3
    }
}