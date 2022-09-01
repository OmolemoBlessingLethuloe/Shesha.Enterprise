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
    [Entity(TypeShortAlias = "Shesha.Enterprise.BankTransaction")]
    [Table("entpr_BankTransactions")]
    [Discriminator]
    public class BankTransaction : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual string Reference { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual decimal Amount { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual DateTime TransactionDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual decimal Balance { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "AllocationMechanism")]
        public virtual long? AllocationMechanism { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime AllocatedDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual DateTime AllocationApprovedDate { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "AllocationStatus")]
        public virtual long? AllocationStatus { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string AllocationRejectedComments { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string Comments { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "TransactionType")]
        public virtual long? TransactionType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual BankAccount BankAccount { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person AllocatedBy { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person AllocationApprovedBy { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person AllocatedPerson { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Organisation AllocatedOrganisation { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual FinancialAccount AllocatedAccount { get; set; }
    }
}