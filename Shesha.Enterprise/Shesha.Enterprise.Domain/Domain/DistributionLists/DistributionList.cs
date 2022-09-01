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
    [Entity(TypeShortAlias = "Shesha.Enterprise.DistributionList")]
    [Table("entpr_DistributionLists")]
    [Discriminator]
    public class DistributionList : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [StringLength(255)]
        public virtual string Name { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(255)]
        public virtual string Namespace { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? TenantId { get; set; }
    }
}