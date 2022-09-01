using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.Enum
{
    /// <summary>
    /// 
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "InteractionType")]
    public enum RefListInteractionType : long
    {
        /// <summary>
        /// FAQ
        /// </summary>
        [Description("FAQ")]
        FAQ = 1,

        /// <summary>
        /// LogCase
        /// </summary>
        [Description("LogCase")]
        LogCase = 2,

        /// <summary>
        /// Repeat
        /// </summary>
        [Description("Repeat")]
        Repeat = 3,

        /// <summary>
        /// Loadshedding
        /// </summary>
        [Description("Loadshedding")]
        Loadshedding = 4
    }
}