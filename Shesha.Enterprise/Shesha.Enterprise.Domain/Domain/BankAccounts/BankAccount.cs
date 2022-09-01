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
    [Entity(TypeShortAlias = "Shesha.Enterprise.BankAccount")]
    [Table("entpr_BankAccounts")]
    [Discriminator]
    public class BankAccount : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual string AccountName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        [ReferenceList("Shesha.Enterprise", "Bank")]
        public virtual long? Bank { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string BranchName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual string BranchCode { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [ReferenceList("Shesha.Enterprise", "AccountType")]
        public virtual long? AccountType { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual string AccountNumber { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        [ReferenceList("Shesha.Enterprise", "BankAccountStatus")]
        public virtual long? Status { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual decimal? CurrentBalance { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Person OwnerPerson { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Organisation OwnerOrganisation { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual Currency Currency { get; set; }
    }
}