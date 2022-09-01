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
    [Entity(TypeShortAlias = "Shesha.Enterprise.FinancialTransaction")]
    [Table("entpr_FinancialTransactions")]
    [Discriminator]
    public class FinancialTransaction : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual decimal? Amount { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual DateTime? TransactionDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual decimal? RunningBalance { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        [ReferenceList("Shesha.Enterprise", "TransactionType")]
        public virtual long? TransactionType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Reference { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual Guid? SourceEntityId { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual string SourceEntityType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        [ReferenceList("Shesha.Enterprise", "TransactionStatus")]
        public virtual long? Status { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string CancellationReason { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual FinancialAccount Account { get; set; }
    }
}