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
    [Entity(TypeShortAlias = "Shesha.Enterprise.OrganisationBankAccount")]
    [Table("entpr_OrganisationBankAccounts")]
    [Discriminator]
    public class OrganisationBankAccount : RelationshipEntityBase<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        public virtual int? Role { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual Organisation Organisation { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [Required]
        public virtual BankAccount BankAccount { get; set; }
    }
}