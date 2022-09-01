using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Intent.RoslynWeaver.Attributes;
using Shesha.Domain;
using Shesha.Domain.Attributes;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Boxfusion.Modules.Domain.Entity", Version = "1.0")]

namespace Shesha.Enterprise.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Entity(TypeShortAlias = "Shesha.Enterprise.AccountTransfer")]
    [Table("entpr_AccountTransfers")]
    [Discriminator]
    public class AccountTransfer : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual string FromReference { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string ToReference { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? Amount { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "TransactionStatu")]
        public virtual long? Status { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime? DateCompleted { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string AdditionalInfoJson { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "RejectionReason")]
        public virtual long? RejectionReason { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "TransferReason")]
        public virtual long? TransferReason { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "TransferMethod")]
        public virtual long? TransferMethod { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string SignedRequest { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual FinancialAccount FromAccountEntity { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual FinancialAccount ToAccount { get; set; }
    }
}