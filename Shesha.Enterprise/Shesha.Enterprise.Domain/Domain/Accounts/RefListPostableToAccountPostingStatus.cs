using System.ComponentModel;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Enum", Version = "1.0")]

namespace Shesha.Enterprise.Accounts
{
    /// <summary>
    /// 
    /// </summary>
    [ReferenceList("Shesha.Enterprise", "PostableToAccountPostingStatus")]
    public enum RefListPostableToAccountPostingStatus : long
    {
        /// <summary>
        /// Not Required
        /// </summary>
        [Description("Not Required")]
        NotRequired = 1,

        /// <summary>
        /// Posted As Finalised
        /// </summary>
        [Description("Posted As Finalised")]
        PostedAsFinalised = 2,

        /// <summary>
        /// Awaiting Posting
        /// </summary>
        [Description("Awaiting Posting")]
        AwaitingPosting = 3,

        /// <summary>
        /// Awaiting Transaction Ready
        /// </summary>
        [Description("Awaiting Transaction Ready")]
        AwaitingTransactionReady = 4,

        /// <summary>
        /// Posted As Pending
        /// </summary>
        [Description("Posted As Pending")]
        PostedAsPending = 5
    }
}