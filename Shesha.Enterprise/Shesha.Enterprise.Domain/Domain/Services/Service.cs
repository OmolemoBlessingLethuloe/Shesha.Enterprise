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
    [Entity(TypeShortAlias = "Shesha.Enterprise.Service")]
    [Table("entpr_Services")]
    [Discriminator]
    public class Service : FullAuditedEntity<Guid>
    {
        /// <summary> 
        /// 
        /// </summary>
        [EntityDisplayName]
        [StringLength(200)]
        public virtual string ServiceName { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(300)]
        public virtual string Description { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        [StringLength(300)]
        public virtual string Comments { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? TenantId { get; set; }

        /// <summary> 
        /// 
        /// </summary>
        public virtual int? ServiceCategory { get; set; }
    }
}